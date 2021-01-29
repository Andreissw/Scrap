using System;
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
    public partial class PhotoForm : Form
    {
        public PhotoForm(List<string> ListPath)
        {
            InitializeComponent();
            this.ListPath = ListPath;
            if (ListPath.Count != 0)
                AddPicture();

        }
        
        int k = 1;//Количество pictureBox
        int x = 12; //X Координаты
        int y = 444; //Y Координаты
        public List<string> ListPath;
      
        private void BTBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            if (ListPath.Count == 0)
            {MessageBox.Show("Обнаружено 0 фотографий","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);return;  }

            DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void PanelPhoto_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            ListPath.AddRange(files.ToList());
            AddPicture();
            PanelPhoto.BackColor = Color.WhiteSmoke;
            ddPhoto.Text = "Добавить фото";

        }

        private void PanelPhoto_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                ddPhoto.Text = "Отпустите мышь";
                PanelPhoto.BackColor = Color.Gainsboro;
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PanelPhoto_DragLeave(object sender, EventArgs e)
        {
            PanelPhoto.BackColor = Color.WhiteSmoke;
            ddPhoto.Text = "Добавить фото";
        }

        private void PanelPhoto_DragOver(object sender, DragEventArgs e)
        {
        
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
                if (item.Name.Contains("Pic"))
                    Controls.Remove(item);


             k = 1;//Количество pictureBox
             x = 12; //X Координаты
             y = 444;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Multiselect = true,
                Title = "Выберите одно или несколько фотографий",
                InitialDirectory = @"C:\"
            };

            dialog.ShowDialog();
            if (dialog.FileName == string.Empty) //Если пользователь ничего не выбрал
                return;

            ListPath.AddRange(dialog.FileNames);
            AddPicture();  
        }

        void AddPicture()
        {
            k = 1;//Количество pictureBox
            x = 12; //X Координаты
            y = 444; // Y Координаты

            var listControls = Controls.OfType<PictureBox>().ToList(); //Удаляем все фотографии
            foreach (Control item in listControls)
                Controls.Remove(item);

            foreach (var item in ListPath) //Добавляем фотографии
            {
                var point = new Point(x, y);
                CreatePicture(item, k += 1, point);
                x += 80;
            }
        }

        PictureBox PicRemove;
        void CreatePicture(string Path, int count,Point point)
        {            
            var pic = new PictureBox();            
            pic.Location = point;
            pic.Size = new Size(77, 73);
            pic.Name = $"Pic{count}";
            pic.Visible = true;
            pic.Image = new Bitmap(Path);
            //pic.BackColor = Color.White;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(pic);

            Point loc;

            pic.MouseClick += (a, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {                   
                   PicRemove = pic; //запоминаем картинку на которую нажали
                   contextMenuStrip1.Show(Cursor.Position);   //Открывается контекстное меню  
                    return;
                }
                contextMenuStrip1.Hide();
            };

            contextMenuStrip1.MouseClick += (b, c) =>
            {
                if (!(c.Button == MouseButtons.Left))
                    return;

                if (PicRemove != pic) //Если текущая картинка равна картинки которую мы запомнили по щелчку, то удаляем объект
                    return;   

                ListPath.Remove(Path); //Удаление в списке путь текущего фото                

                AddPicture();
            };

        }

       
    }
}
