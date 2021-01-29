using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            ListMethods = new List<DelegateMethodths>() { OpenScanReject,RemoveReject,ReportReject,CloseApp};
        }

        readonly string[] Objects = { "Сканирование карантина", "Удаление карантина" ,"Отчёт по карантинку", "Выход" }; //Список меню

        delegate void DelegateMethodths();

        List<DelegateMethodths> ListMethods;  
        private void BT_OK_Click(object sender, EventArgs e)
        {
            GBVisibleOff(); //Отключаем все меню     
            ListMethods[List.SelectedIndex](); //Открываем меню которое пользоатель выделил
            
        }

        private void TBScan_KeyDown(object sender, KeyEventArgs e) //Сканирование БарКода
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TBScan.Text == string.Empty)
                { Error($"{TBScan.Text} Пустое поле"); TBScan.Clear(); TBScan.Select(); return; }

                var IdLazer = CheckLazer(TBScan.Text);
                if (IdLazer == 0) //Проверка LazerBase

                {Error($"{TBScan.Text} этот Decode не найден в таблице LazerBase (Лазерный гравировщик)"); TBScan.Clear(); TBScan.Select(); return;}

                if (!CheckScrapData(IdLazer)) //Проверка таблицы ScrapData, был ли номер отсканирован ранее
                {
                    //Если номер был ддобавлен ранее
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
            MessageBox.Show(Error,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            TBScan.Clear(); TBScan.Select();
        }

        void OpenScanReject()
        {
            OpenForm(GBScan);
            TBScan.Clear();
            TBScan.Select();
        }

        void RemoveReject()
        { 
        
        }

        void ReportReject()
        { 
        
        }

        void CloseApp()
        { 
        
        }

        void OpenForm(GroupBox GB)
        {            
            GB.Visible = true;
            GB.Location = new Point(354, 12);
            GB.Size = new Size(1031, 594);
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

        bool CheckScrapData(int idLazer) //Проверка был ли ранее добавлен Decode Таблицу
        {
            using (var scrap = new QAEntities())
            {
                return scrap.Scrap_Data.Where(c => c.IdLazer == idLazer).Select(c => c.IdLazer == c.IdLazer).FirstOrDefault();
            }
        }

   
    }
}
