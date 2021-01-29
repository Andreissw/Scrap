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

        public Scrap_DescriptionForm(int IdLazer)
        {
            InitializeComponent();
            this.IdLazer = IdLazer;
            label1.Select();
        }

        string PathPhoto = @"\\gusev.int\fs\cts\ДСНТ\Exchange\ScrapФото\";
        string PathDocument = @"\\gusev.int\fs\cts\ДСНТ\Exchange\ScrapDocument\";
        int IdLazer;
        List<string> ListPath = new List<string>();
        bool close;
        private void BTOK_Click(object sender, EventArgs e)
        {
            var Photo = new PhotoForm(ListPath);
            var result = Photo.ShowDialog();      
            ListPath = Photo.ListPath; //Передаем список фотографий 

            if (result == DialogResult.No) //Если была нажата кнопка отмены
                return;

            var PathFiles = LoadPicture(ListPath, 1); //Если бы нажата кнопка Добавить карантин

            if (PathFiles == null) //Если список null то выходим
                return;

            if (PathFiles.Count == 0) //Если список 0 то выходим
                return;

            var PathD = PathDocument + IdLazer + DateTime.Now.ToString("yyyy MMMM dd - HH.mm.ss") + ".pdf"; //Ссылка куда надо скопировать документ

            if (PathDoc.Text != string.Empty)
                File.Copy(PathDoc.Text, PathD, true);


            var idDescription = addScrapDescription(PathD, TBDescription.Text); //Добавляем описание и документ в базу и возвращаем ID номер

            foreach (var item in PathFiles) //Добавляем фотографии в базу 
               addScrapData(IdLazer,item,idDescription);

            ListPath.Clear();//Очистка картинок
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
                PathDoc.Text = OpenDialog.FileName;
            
        }

        private void Scrap_DescriptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!close)
                e.Cancel = true;

        }

        List<string> LoadPicture(List<string> files, int iterID) //Загрузка фото
        {
            int k = 0;
            List<string> PathFilesNew = new List<string>();
            foreach (var item in files)
            {
                var BM = new Bitmap(item);
                PathFilesNew.Add(PathPhoto + IdLazer + " - " + k + " - " + DateTime.Now.ToString("yyyy MMMM dd - HH.mm.ss") + ".jpeg");

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

        int addScrapDescription(string PathDoc, string Desc)
        {
            using (var QA = new QAEntities())
            {
                var decriptionscrap = new Scrap_Description()
                {
                    PathDocument = PathDoc,
                    Description = Desc
                };

                QA.Scrap_Description.Add(decriptionscrap);
                QA.SaveChanges();

                return QA.Scrap_Description.OrderByDescending(c=>c.id).Select(c => c.id).FirstOrDefault();
            }
           
        }

        void addScrapData(int idlazer,string PathPhoto,int IdDesctiption)
        {
            using (var QA = new QAEntities())
            {
                var datascrap = new Scrap_Data()
                {
                    IdLazer = idlazer,
                    Status = false,
                    PathPhoto = PathPhoto,
                    Date = DateTime.UtcNow.AddHours(2),
                    IdDescription = IdDesctiption,
                    UserID = 211,
                };

                QA.Scrap_Data.Add(datascrap);
                QA.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PathDoc.Clear();
        }
    }
}
