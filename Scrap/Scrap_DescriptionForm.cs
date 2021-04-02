using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encoder = System.Drawing.Imaging.Encoder;

namespace Scrap
{
    public partial class Scrap_DescriptionForm : Form
    {
        bool AddUpdate;
        string PathPhoto = @"\\gusev.int\fs\cts\ДСНТ\Exchange\ScrapФото\";
        string PathDocument = @"\\gusev.int\fs\cts\ДСНТ\Exchange\ScrapDocument\";
        int IdLazer;
        List<string> ListPath = new List<string>();
        List<string> ListPathNew = new List<string>();

        List<string> PathFiles = new List<string>();
        List<string> ListRemove = new List<string>();

        List<int> ListDescode = new List<int>();

        bool close;
        int k = 0;

        public Scrap_DescriptionForm(List<int> listDecodes)
        {
            InitializeComponent();
            ListDescode.AddRange(listDecodes);
        }

        public Scrap_DescriptionForm(int IdLazer, bool addupdate = false)
        {
            InitializeComponent();
            this.IdLazer = IdLazer;
            this.AddUpdate = addupdate;

            if (this.AddUpdate)//Если такая плата уже была, добавляем данные 
                GetData();

            label1.Select();
        }

        void GetData()
        {
            GetDoc();
            GetDesc();
        }

        void GetDoc() //Получение пути документа
        {
            using (var QA = new QAEntities())
            {
                PathDoc.Text = (from data in QA.Scrap_Data
                                join desc in QA.Scrap_Description on data.IdDescription equals desc.id
                                where data.IdLazer == IdLazer
                                select desc.PathDocument).FirstOrDefault();

                ActName.Text = (from data in QA.Scrap_Data
                                join desc in QA.Scrap_Description on data.IdDescription equals desc.id
                                where data.IdLazer == IdLazer
                                select desc.NameDoc).FirstOrDefault();
            }
        }

        void GetDesc() //Получение пути документа
        {
            using (var QA = new QAEntities())
            {
                TBDescription.Text = (from data in QA.Scrap_Data
                                join desc in QA.Scrap_Description on data.IdDescription equals desc.id
                                where data.IdLazer == IdLazer
                                select desc.Description).FirstOrDefault();
            }
        }

        private void BTOK_Click(object sender, EventArgs e) //Добавить фото
        {
            k += 1;
            if (!AddUpdate)
                Add(); //Такого номера платы никогда не было в Scrap
            else
                Updatee(); //Плата уже была в Scrap

        }

        public void Updatee()
        {
            if (k == 1)
                ListPath = GetListPath();

            var Photo = new PhotoForm(ListPath,ListPathNew, true); 
            var result = Photo.ShowDialog();
            //ListPath = Photo.ListPath; //Передаем список фотографий 

            ListRemove = GetListPath().Where(c => !Photo.ListPath.Contains(c)).ToList();
            ListPathNew = Photo.ListNewPath;

            //if (result == DialogResult.No) //Если была нажата кнопка отмены                            
            //    return;

            //PathFiles = LoadPicture(ListPathNew); //Если бы нажата кнопка Добавить карантин


        }

        List<string> GetListPath()
        {
            using (var QA = new QAEntities())
            {
                return QA.Scrap_Data.Where(c => c.IdLazer == IdLazer).Select(c => c.PathPhoto).ToList();
            }
        }

        private void Add()
        {
            var Photo = new PhotoForm(ListPathNew,false);
            var result = Photo.ShowDialog();
            ListPathNew = Photo.ListNewPath; //Передаем список фотографий 

            //if (result == DialogResult.No) //Если была нажата кнопка отмены
            //    return;

            //PathFiles = LoadPicture(ListPathNew); //Если бы нажата кнопка Добавить карантин         
        }

      
        void SaveData(string PathD,int userid, int idlazer)
        {
            //var PathD = PathDocument + IdLazer + DateTime.Now.ToString("yyyy MMMM dd - HH.mm.ss") + ".pdf"; //Ссылка куда надо скопировать документ
            int id;
            //var Result = CheckDesc();
            //if (!Result)            
            if (PathDoc.Text != string.Empty)
                File.Copy(PathDoc.Text, PathD, true);
            else
                PathD = "";


            if (CheckDesc(idlazer)) // Обновляем или добавляем
                id = UpdateScrapDescription(PathD, TBDescription.Text,idlazer);
            else
                id = addScrapDescription(PathD, TBDescription.Text, idlazer); //Добавляем описание и документ в базу и возвращаем ID номер

                   
            if (PathFiles.Count != 0) //Если список 0 то выходим
                    foreach (var item in PathFiles) //Добавляем фотографии в базу 
                        addScrapData( item, id, userid, idlazer);
            else
                addScrapData("", id, userid, idlazer);

            if (ListRemove.Count != 0) //Если список 0 то выходим
                    foreach (var item in ListRemove) //Добавляем фотографии в базу 
                        RemoveScrapData(item, idlazer);

            
            
        }

        int getidlog()
        {
            using (var qa = new QAEntities())
            {
                 var result = qa.Scrap_LogPhoto.OrderByDescending(c => c.IdLog).Select(c => c.IdLog).FirstOrDefault();
                if (result == null)
                    return 1;
                else
                    return (int)result + 1;

            }
        }



        void logPhoto(string pathPhoto, int UserID, int idlog, int idlazer ,bool Status = false)
        {
            using (var qa = new QAEntities())
            {
                Scrap_LogPhoto scrap_LogPhoto = new Scrap_LogPhoto()
                {
                    IdLazer = idlazer,
                    PathPhoto = pathPhoto,
                    UserID = UserID,
                    IdLog = idlog
                    //PathPhoto
                };

                qa.Scrap_LogPhoto.Add(scrap_LogPhoto);
                qa.SaveChanges();
               
            }
        }

        void log(int idlog, string pathdoc, string desc, int userID , int idlazer , bool Status = false)
        {

            using (var qa = new QAEntities())
            {
                Scrap_Log scrap_Log = new Scrap_Log()
                {
                    IdLazer = idlazer,
                    Status = Status,
                    IdPathPhoto = idlog,
                    PathDocument = pathdoc,
                    Description = desc,
                    UserID = userID,
                    Date = DateTime.UtcNow.AddHours(2), Code = Code.Text.Substring(0, 2),DefectCode = GetCode()
                };

                qa.Scrap_Log.Add(scrap_Log);
                qa.SaveChanges();
            }

            
        }

        string GetCode()
        {
            using (var qa = new QAEntities())
            {
                return qa.Scrap_DefectCode.Where(c => c.Code + " - " + c.Description == CodeDefect.Text).Select(c => c.Code).FirstOrDefault();
            }
        }


        //void Update(string PathD)
        //{
        //    if (PathDoc.Text != string.Empty)
        //        File.Copy(PathDoc.Text, PathD, true);
        //    else
        //        PathD = "";

        //    var id = UpdateScrapDescription(PathD, TBDescription.Text);

        //    if (PathFiles != null) //Если список null то выходим
        //        if (PathFiles.Count != 0) //Если список 0 то выходим
        //            foreach (var item in PathFiles) //Добавляем фотографии в базу 
        //                addScrapData(item, idDescription);

        //    //if (ListRemove != null) //Если список null то выходим
        //    //    if (ListRemove.Count != 0) //Если список 0 то выходим
        //    //        foreach (var item in ListRemove) //Добавляем фотографии в базу 
        //    //            RemoveScrapData(item);

        //    ListRemove.Clear();
        //    ListPathNew.Clear();//Очистка картинок
        //    PathDoc.Clear();
        //    TBDescription.Clear();


        //}

        bool CheckDesc(int idlazer)
        {
            using (var qa = new QAEntities())
            {
                return qa.Scrap_Data.Where(c => c.IdLazer == idlazer).Select(c => c.IdLazer == c.IdLazer).FirstOrDefault();
            }
        }

        private void BTBack_Click(object sender, EventArgs e)
        {           
            DialogResult = DialogResult.Cancel;
            close = true;
            this.Close();
        }

        private void AddDoc_Click(object sender, EventArgs e)
        {
            var OpenDialog = new OpenFileDialog();
            OpenDialog.Filter = "PDF файлы (*.pdf)|*.pdf";
            OpenDialog.FilterIndex = 0;
            var Result =  OpenDialog.ShowDialog();
            if (Result == DialogResult.OK) 
            {           
                PathDoc.Text = OpenDialog.FileName;
                var start = OpenDialog.FileName.LastIndexOf('\\') + 1;                               
                var file = OpenDialog.FileName.Substring(start);
                ActName.Text = file.Substring(0, file.Length - 4);
            }
        }

        private void Scrap_DescriptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!close)
                e.Cancel = true;

        }

        List<string> LoadPicture(List<string> files, int idlazer) //Загрузка фото
        {
            int k = 0;
            List<string> PathFilesNew = new List<string>();
            foreach (var item in files)
            {

                var BM = new Bitmap(item);
                PathFilesNew.Add(PathPhoto + idlazer + " - " + k + " - " + DateTime.Now.ToString("yyyy MMMM dd - HH.mm.ss") + ".jpeg");

                //Настройка качества картинки (сжимаем размер)
                var EncoderParametrs = new EncoderParameters(1);
                EncoderParametrs.Param[0] = new EncoderParameter(Encoder.Quality, 25L);
                var Endoder = ImageCodecInfo.GetImageEncoders().Where(c => c.MimeType == "image/jpeg").FirstOrDefault();

                try //Обработчик ошибок
                {
                    BM.Save(PathFilesNew[k], Endoder, EncoderParametrs); //Сохранение фотографии
                }
                catch (Exception ex) //В случае какой либо ошибки
                {
                    MessageBox.Show($"Ошибка добавления фотографии - {item} \n Итерация № {k} \n {ex} "); //Вывод сообщение для пользователя
                    RemovePicture(PathFilesNew); //Удаление всех фотографии, которые участвуют в этой итерации                    
                    return null;
                }      

                if (!File.Exists(PathFilesNew[k])) //Проверяет наличие фотографии в папке
                {
                    MessageBox.Show($"Ошибка добавления фотографии - {item}. Фотография не найдена \n Итерация № {k} ");
                    RemovePicture(PathFilesNew);                    
                    return null;
                }
                k++;
            }
            return PathFilesNew; //Если все хорошо, возвращаем список добавленных 
        }

        void RemovePicture(List<string> List)
        {            
            foreach (var item in List)
                if (File.Exists(item))
                    File.Delete(item);
        }

        int UpdateScrapDescription(string PathDoc, string Desc, int idlazer)
        {
            using (var QA = new QAEntities())
            {
                var scrap = QA.Scrap_Description.Where(c => c.IdLazer == idlazer);
                scrap.FirstOrDefault().Description = Desc;
                scrap.FirstOrDefault().PathDocument = PathDoc;
                scrap.FirstOrDefault().Date = DateTime.UtcNow.AddHours(2);
                QA.SaveChanges();

                return QA.Scrap_Description.Where(c=>c.IdLazer == idlazer).Select(c => c.id).FirstOrDefault();                
            }

        }

        int addScrapDescription(string PathDoc, string Desc,int idlazer)
        {
            using (var QA = new QAEntities())
            {
                var decriptionscrap = new Scrap_Description()
                {
                    PathDocument = PathDoc,
                    Description = Desc
                    ,IdLazer = idlazer
                    ,Date = DateTime.UtcNow.AddHours(2)
                };

                QA.Scrap_Description.Add(decriptionscrap);
                QA.SaveChanges();

                return QA.Scrap_Description.OrderByDescending(c=>c.id).Select(c => c.id).FirstOrDefault();
            }
           
        }
        void RemoveScrapData( string path , int idlazer)
        {
            using (var qa = new QAEntities())
            {
                var scrap = qa.Scrap_Data.Where(c => c.IdLazer == idlazer & c.PathPhoto == path).FirstOrDefault();
                qa.Scrap_Data.Remove(scrap);
                qa.SaveChanges();
            }
        }
        void addScrapData(string PathPhoto,int IdDesctiption,int userid, int idlazer)
        {
            using (var QA = new QAEntities())
            {
                var datascrap = new Scrap_Data()
                {
                    IdLazer = idlazer,                    
                    PathPhoto = PathPhoto,
                    Date = DateTime.UtcNow.AddHours(2),
                    IdDescription = IdDesctiption,
                    UserID = userid,
                    
                };

                QA.Scrap_Data.Add(datascrap);
                QA.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PathDoc.Clear();
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            if (Code.Text == string.Empty)
            {
                MessageBox.Show("Заполните Код Виновника!");
                return;
            }

            if (ComboStatus.Text == string.Empty)
            {
                MessageBox.Show("Заполните Статус!");
                return;
            }

            if (CodeDefect.Text == string.Empty)
            {
                MessageBox.Show("Выберите код дефекта");
                return;
            }

            var confim = new ConfimUser(); //Подтверждение пользователя
            var Result = confim.ShowDialog();
            if (Result == DialogResult.Cancel) //Отмена
                return;

            if (ListDescode.Count != 0) //Если мы сохраняем пул номеров
            {
                foreach (var item in ListDescode)
                    Save(item,confim.UserID);               

                DialogResult = DialogResult.OK;
                close = true;
                this.Close();
                return;
            }

            Save(IdLazer,confim.UserID);

            FormInfo info = new FormInfo(IdLazer);
            info.ShowDialog();

            DialogResult = DialogResult.Cancel;
            close = true;
            this.Close();

        }


        void Save(int idlazer, int userid)
        {
            PathFiles = LoadPicture(ListPathNew, idlazer); //Если была нажата кнопка Добавить карантин    
            var idlog = getidlog();

            var ListALl = ListPath.Concat(PathFiles).ToList();

            if (ListALl.Count != 0)
                foreach (var item in ListALl)
                    logPhoto(item, userid, idlog, idlazer);
            else
                idlog = 0;

            var PathD = PathDocument + ActName.Text + ".pdf"; //Ссылка куда надо скопировать документ
            log(idlog, PathD, TBDescription.Text, userid, idlazer);


            SaveData(PathD, userid, idlazer); //Сохранение
            addOppLog(idlazer, userid);
            short status;
            if (ComboStatus.Text == "Карантин")
                status = 2;
            else 
                status = 3;

            SetStatus(idlazer, status);



        }
        void SetStatus(int idlazer, short status)
        {
            using (var qa = new QAEntities())
            {
                var R = qa.Scrap_Status.Where(c => c.Idlazer == idlazer).Select(c => c.Idlazer == c.Idlazer).FirstOrDefault();

                if (R)
                {
                  var q = qa.Scrap_Status.Where(c => c.Idlazer == idlazer);
                  q.FirstOrDefault().Status = status;
                    qa.SaveChanges();
                }
                else
                {
                    var sc = new Scrap_Status()
                    {                        
                        Idlazer = idlazer,
                        Status = status,
                    };

                    qa.Scrap_Status.Add(sc);
                    qa.SaveChanges();
                }

               
              
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
                                  ('{pcbid}','{31}','{3}',CURRENT_TIMESTAMP,'{userid}') update [FAS].[dbo].[Ct_StepResult]  set StepID = 31, TestResult = 3  where PCBID = '{pcbid}'");
        }

        private void Scrap_DescriptionForm_Load(object sender, EventArgs e)
        {
            using (var qa = new QAEntities())
            {
                ComboStatus.DataSource = qa.Scrap_StatusList.Where(c=> c.@int != 1).Select(c => c.Status).ToList();
                ComboStatus.Text = string.Empty;

                Code.DataSource = qa.Scrap_Culprit.Select(c => c.Code + " - " + c.Description).ToList();

                CodeDefect.DataSource = qa.Scrap_DefectCode.Select(c => c.Code + " - " + c.Description).ToList();
                CodeDefect.Text = string.Empty;
            }
        }
       
        private void CodeDefect_Leave(object sender, EventArgs e)
        {
            if (!CheckDefect())
                CodeDefect.Text = "";
        }

        private void CodeDefect_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!CheckDefect())
                CodeDefect.Text = "";
        }

        bool CheckDefect()
        {
            if (CodeDefect.Items.Contains(CodeDefect.Text))
                return true;
            return false;
        }

    
    }
}
