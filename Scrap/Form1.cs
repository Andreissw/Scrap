using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List.Items.AddRange(Objects); //Вывод списка меню
            ListMethods = new List<DelegateMethodths>() { OpenScanReject, ReportReject, RemoveScrap, CloseApp };
        }

        readonly string[] Objects = { "Сканирование брака", "Отчёт по браку", "Удалить плату из брака", "Выход" }; //Список меню

        delegate void DelegateMethodths();

        List<DelegateMethodths> ListMethods;
        private void BT_OK_Click(object sender, EventArgs e)
        {
            GBVisibleOff(); //Отключаем все меню     
            ListMethods[List.SelectedIndex](); //Открываем меню которое пользоатель выделил

        }
        private void List_DoubleClick(object sender, EventArgs e)
        {
            GBVisibleOff(); //Отключаем все меню     
            ListMethods[List.SelectedIndex](); //Открываем меню которое пользоатель выделил
        }

        private void TBScanScrap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TBScanScrap.Text == string.Empty)
                { Error($"{TBScanScrap.Text} Пустое поле"); TBScanScrap.Clear(); TBScanScrap.Select(); return; }

                var IdLazer = CheckLazer(TBScanScrap.Text);
                if (IdLazer == 0) //Проверка LazerBase

                { Error($"{TBScanScrap.Text} Decode не найден в таблице LazerBase (Лазерный гравировщик)"); TBScan.Clear(); TBScan.Select(); return; }

                var ResultScan = CheckScrapData(IdLazer); //Проверка таблицы ScrapData, был ли номер отсканирован ранее

                if (!ResultScan)
                { Error($"{TBScanScrap.Text} Decode не найден браке"); TBScanScrap.Clear(); TBScanScrap.Select(); return; }

                var result = CheckStatusScrap(IdLazer);

                if (result == 1)
                { Error($"{TBScanScrap.Text} Плата уже выведена из брака"); TBScanScrap.Clear(); TBScanScrap.Select(); return; }

                var confim = new ConfimUser(); //Подтверждение пользователя
                var Result = confim.ShowDialog();

                if (Result == DialogResult.Cancel) //Отмена
                    return;

                UpdateStatus(IdLazer);
                addOppLog(IdLazer, confim.UserID);
                addLog(IdLazer, confim.UserID);

                FormInfo info = new FormInfo(IdLazer);
                info.ShowDialog();

                TBScanScrap.Clear(); TBScanScrap.Select();
            }

        }

        void addOppLog(int pcbid, int userid)
        {
            #region EF6
            //using (var fas = new FASEntities())
            //{
            //    Ct_OperLog oper = new Ct_OperLog()
            //    {
            //       PCBID = pcbid,
            //       StepID = 31,
            //       TestResultID = 3,
            //       StepDate = DateTime.UtcNow.AddHours(2),
            //       StepByID = (short)userid,
            //    };

            //    fas.Ct_OperLog.Add(oper);
            //    fas.SaveChanges();
            //}
            #endregion
            LoadGrid.SelectString($@" use fas insert into  [FAS].[dbo].[Ct_OperLog] (PCBID,StepID,TestResultID,StepDate,StepByID) values
                                  ('{pcbid}','{31}','{2}',CURRENT_TIMESTAMP,'{userid}')");
        }

        private void TBScan_KeyDown(object sender, KeyEventArgs e) //Сканирование БарКода
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TBScan.Text == string.Empty)
                { Error($"{TBScan.Text} Пустое поле"); TBScan.Clear(); TBScan.Select(); return; }

                var IdLazer = CheckLazer(TBScan.Text);
                if (IdLazer == 0) //Проверка LazerBase

                { Error($"{TBScan.Text} этот Decode не найден в таблице LazerBase (Лазерный гравировщик)"); TBScan.Clear(); TBScan.Select(); return; }

                var ResultScan = CheckScrapData(IdLazer); //Проверка таблицы ScrapData, был ли номер отсканирован ранее

                //if (CheckBox.Checked)//Работа по пул номеров
                //{

                //    return;
                //}


                if (ResultScan) //Был отсканирован ранее
                {
                    if (CheckBox.Checked) //Если в режиме пулла номеров скнируем повторно плату
                    {
                        ErrorLabel.Visible = true;
                        ErrorLabel.Text = $"Номер платы '{TBScan.Text}' был отсканирован ранее\n Невозможно отсканировать повторно плату в режиме 'пулл номеров'"; TBScan.Clear(); TBScan.Select(); return;
                    }

                    //Если работает без пулла номеров
                    var Description = new Scrap_DescriptionForm(IdLazer, true);
                    var ResultDesc = Description.ShowDialog();

                    if (ResultDesc == DialogResult.Cancel)
                    {
                        TBScan.Clear(); TBScan.Select();
                    }
                    return;
                }

                //Если номера такого не было

                if (CheckBox.Checked) //Если в режиме пулла номеров сканируем первый раз плату
                {
                    if (ListDecodes.Items.Contains(TBScan.Text))
                    {
                        ErrorLabel.Visible = true;
                        ErrorLabel.Text = $"Номер платы '{TBScan.Text}' уже есть в списке "; TBScan.Clear(); TBScan.Select();
                        return;
                    }

                    ListDecodes.Items.Add(TBScan.Text);
                    BtAccept.Enabled = true;
                    TBScan.Clear(); TBScan.Select(); ErrorLabel.Visible = false;
                    return;
                }


                var desc = new Scrap_DescriptionForm(IdLazer);
                var Result = desc.ShowDialog();

                if (Result == DialogResult.Cancel)
                {
                    TBScan.Clear(); TBScan.Select(); return;
                }


            }
        }

        void Error(string Error)
        {
            MessageBox.Show(Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TBScan.Clear(); TBScan.Select();
        }

        void OpenScanReject() //Открытие формы для сканирования
        {
            OpenForm(GBScan, 1040, 272);
            CheckBox.Checked = false;
            TBScan.Clear();
            TBScan.Select();
        }     
       

        private void ReportBT_Click(object sender, EventArgs e)
        {
            Report();      
        }

        private void BT_Click(object sender, EventArgs e)
        {
            var columname = GridList.Columns[0].Name; 

            if (columname != "Акт")
            {
                GetReport();
            }
        }

        private void Report()
        {
           
            var columname = GridList.Columns[0].Name;
            if (columname == "Акт")           
            {
              
                var actname = GridList[0, GridList.CurrentRow.Index].Value.ToString();
                GetList($@"use qa 
                 select Content Barcode, date Дата, ProductName Модель,'',''
                 from Scrap_Description d
                 left join SMDCOMPONETS.dbo.LazerBase l on d.IdLazer = l.IDLaser
                 where namedoc = '{actname}'
                 order by date desc ");

                var grid = new DataGridView() { Visible = false };
                Controls.Add(grid);

                LoadGrid.Loadgrid(grid, $@"	  use qa 
                              select Content,  concat(cul.Code,' - ',cul.Description) Ответственный, concat(Def.Code,' - ',Def.Description) код_Дефекта,log.Date
                              from Scrap_Log log
                              left join SMDCOMPONETS.dbo.LazerBase l on log.IdLazer = l.IDLaser							 
								left join Scrap_Description d on log.IdLazer = d.IdLazer
								left join Scrap_DefectCode Def on log.defectcode = Def.Code
								left join Scrap_Culprit cul on log.Code = cul.Code
								where NameDoc = '{actname}'
                              order by Content, log.Date desc");

                for (int i = 0; i < GridList.RowCount; i++)
                    for (int k = 0; k < grid.RowCount; k++)
                        if (GridList[0, i].Value.ToString() == grid[0, k].Value.ToString())
                        { GridList[3, i].Value = grid[1, k].Value; GridList[4, i].Value = grid[2, k].Value; break; }

                GridList.Sort(GridList.Columns[1], ListSortDirection.Descending);
                GridList.Columns[3].HeaderText = "Ответственный"; GridList.Columns[4].HeaderText = "Код дефекта";

                Controls.Remove(grid);
                GridList.ClearSelection();


            }
            else
            {
                FormInfo info = new FormInfo(CheckLazer(GridList[0, GridList.CurrentRow.Index].Value.ToString()));
                info.ShowDialog();
            }
        }
        void RemoveScrap()
        {
            OpenForm(GBRemove, 1032, 281);
            TBScanScrap.Clear();
            TBScanScrap.Select();
        }
        void ReportReject() //Открытие отчёта по карантину
        {
            OpenForm(GroupReport, 1114, 616); GetReport();
        }

        void GetReport()
        {
            LoadGrid.Loadgrid(GridList, @"use qa 
                              select distinct(d.namedoc) Акт,''
                              from Scrap_Description d
                              left join SMDCOMPONETS.dbo.LazerBase l on d.IdLazer = l.IDLaser
                              --group by d.namedoc, ProductName, format(date,'dd.MM.yyyy HH:mm')
                              order by Акт desc ");

            var grid = new DataGridView() { Visible = false };
            Controls.Add(grid);

            LoadGrid.Loadgrid(grid, @"  use qa 
                              select d.namedoc Акт, ProductName Модель, format(date,'dd.MM.yyyy HH:mm') Дата
                              from Scrap_Description d
                              left join SMDCOMPONETS.dbo.LazerBase l on d.IdLazer = l.IDLaser
                              group by d.namedoc, ProductName, format(date,'dd.MM.yyyy HH:mm')
                              order by Акт, Дата desc ");

            for (int i = 0; i < GridList.RowCount; i++)
                for (int k = 0; k < grid.RowCount; k++)
                    if (GridList[0, i].Value.ToString() == grid[0, k].Value.ToString())
                    { GridList[1, i].Value = grid[2, k].Value; break; }

            GridList.Sort(GridList.Columns[1], ListSortDirection.Descending);
            GridList.Columns[1].HeaderText = "Дата";

            Controls.Remove(grid);
            GridList.ClearSelection();
        }

        void CloseApp()
        {
            this.Close();
        }

        void OpenForm(GroupBox GB, int x, int y)
        {
            GB.Visible = true;
            GB.Location = new Point(354, 12);
            GB.Size = new Size(x, y);
        }

        void GBClearIn(GroupBox GB)
        {
            foreach (Control item in GB.Controls)
                item.Text = "";
        }

        void GBVisibleOff()
        {
            foreach (var item in Controls.OfType<GroupBox>())
                item.Visible = false;

        }

        int CheckLazer(string Decode) //Проверка Decode в базе LazerBase
        {
            using (var smd = new SMDCOMPONETSEntities1())
            {
                return smd.LazerBase.Where(c => c.Content == Decode).Select(c => c.IDLaser).FirstOrDefault();

            }
        }

        short CheckStatusScrap(int idlazer)
        {
            using (var scrap = new QAEntities())
            {
                return (short)scrap.Scrap_Status.Where(c => c.Idlazer == idlazer).Select(c => c.Status).FirstOrDefault();
            }
        }

        bool CheckScrapData(int idLazer) //Проверка был ли ранее добавлен Decode Таблицу
        {
            using (var scrap = new QAEntities())
            {
                return scrap.Scrap_Data.Where(c => c.IdLazer == idLazer).Select(c => c.IdLazer == c.IdLazer).FirstOrDefault();
            }
        }

        void GetList(string command)
        {
            GridList.DataSource = null;
            LoadGrid.Loadgrid(GridList, command);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox.Checked)
            {
                GBScan.Size = new Size(1040, 609);
                ListDecodes.Items.Clear();
                BtAccept.Enabled = false;
                TBScan.Clear();
                TBScan.Select();
                ErrorLabel.Visible = false;
            }
            else
            {
                GBScan.Size = new Size(1040, 272);
                ListDecodes.Items.Clear();
                BtAccept.Enabled = false;
                TBScan.Clear();
                TBScan.Select();
                ErrorLabel.Visible = false;
            }
        }

        void addLog(int idlazer,int userid)
        {
            using (var qa = new QAEntities())
            {
                Scrap_Log log = new Scrap_Log()
                {
                    IdLazer = idlazer,
                    Status = true,
                    UserID = userid,
                    Date = DateTime.UtcNow.AddHours(2)
                };

                qa.Scrap_Log.Add(log);
                qa.SaveChanges();

            }

        }

        void UpdateStatus(int idlazer)
        {
            using (var qa = new QAEntities())
            {
                var q = qa.Scrap_Status.Where(c => c.Idlazer == idlazer);
                q.FirstOrDefault().Status = 1;
                qa.SaveChanges();
            }
        }
        
        List<int> getListIDLazer()
        {
            List<string> li = new List<string>();
            li = ListDecodes.Items.OfType<string>().ToList();

            using (var smd = new SMDCOMPONETSEntities1())
            {
                return smd.LazerBase.Where(c =>li.Contains(c.Content)).Select(c => c.IDLaser).ToList();
            }
        }

        private void BtAccept_Click(object sender, EventArgs e) //Подтверждение пул номеров
        {
            if (ListDecodes.Items.Count == 0)
            {
                MessageBox.Show("В писке 0 номеров"); return;
            }

            var listpcbid = getListIDLazer();
            var desc = new Scrap_DescriptionForm(listpcbid);
            var Result = desc.ShowDialog();

            if (Result == DialogResult.Cancel)
            {
                TBScan.Clear(); TBScan.Select();  return;
            }

            if (Result == DialogResult.OK )
            {
                ListDecodes.Items.Clear(); BtAccept.Enabled = false;  TBScan.Clear(); TBScan.Select(); MessageBox.Show("Сохранено!"); return;
            }

        }

        private void ListDecodes_Click(object sender, EventArgs e)
        {
            var Result = ListDecodes.SelectedIndex.ToString();
            if (Result != null)
                if (Result.ToString() != "-1")
                    CMS.Show(Cursor.Position);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDecodes.Items.RemoveAt(ListDecodes.SelectedIndex);
        }

        private void GridList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Report();
        }
    }
}
