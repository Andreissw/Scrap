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
        bool addupdate;
        int k = 1;//Количество pictureBox
        int x = 12; //X Координаты
        int y = 444; //Y Координаты
        public List<string> ListPath;
        public List<string> ListNewPath;

        public PhotoForm(List<string> ListPathNew, bool addupdate)
        {
            InitializeComponent();
            this.ListNewPath = ListPathNew;
            this.addupdate = addupdate;

            if (ListNewPath.Count != 0)                           
                AddPicture(ListNewPath,PanelNew);
                  
        }

        public PhotoForm(List<string> ListPath, List<string> ListPathNew, bool addupdate)
        {
            InitializeComponent();
            this.ListPath = ListPath;
            this.ListNewPath = ListPathNew;
            this.addupdate = addupdate;            
            if (this.ListPath.Count != 0) 
                AddPicture(ListPath, Panel);

            if (this.ListNewPath.Count != 0)                        
                AddPicture(ListNewPath,PanelNew);

        }

        private void BTBack_Click(object sender, EventArgs e)
        {
           
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            //if (ListNewPath.Count == 0 )
            //    if (ListPath != null)
            //        if (ListPath.Count == 0)
            //        { MessageBox.Show("Обнаружено 0 фотографий","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);return;  }
            
            DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void PanelPhoto_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[]) e.Data.GetData(DataFormats.FileDrop);                       
            ListNewPath.AddRange(files.ToList());            
            AddPicture(ListNewPath,PanelNew);           
           
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
            
            ListNewPath.AddRange(dialog.FileNames);           
            AddPicture(ListNewPath,PanelNew);  

        }

        void AddPicture(List<string> List, Panel panel,int x = 0, int y = 0)
        {
            k = 1;//Количество pictureBox

            var listControls = panel.Controls.OfType<PictureBox>().ToList(); //Удаляем все фотографии  
            foreach (Control item in listControls)
                panel.Controls.Remove(item);

            foreach (var item in List) //Добавляем фотографии
            {
                var point = new Point(x, y);
                CreatePicture(item, k += 1, point, panel,List);
                x += 80;
            }
        }

        PictureBox PicRemove;
        FormView ViewForm;
        void CreatePicture(string Path, int count,Point point, Panel panel, List<string> List)
        {
            if (string.IsNullOrEmpty(Path))
                return;

            var pic = new PictureBox();
            pic.Location = point;
            pic.Size = new Size(77, 73);
            pic.Name = $"Pic{count}";
            pic.Visible = true;
            pic.Image = new Bitmap(Path);

            //pic.BackColor = Color.White;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            panel.Controls.Add(pic);            

            pic.MouseClick += (a, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {                   
                   PicRemove = pic; //запоминаем картинку на которую нажали
                   contextMenuStrip1.Show(Cursor.Position);   //Открывается контекстное меню  
                    return;
                }

                if (e.Button == MouseButtons.Left)
                {
                    if (ViewForm!= null)                    
                        ViewForm.Close();

                    ViewForm = new FormView(pic.Image,Path);
                    ViewForm.Show();
                }
                
            };

            contextMenuStrip1.MouseClick += (b, c) =>
            {
                if (!(c.Button == MouseButtons.Left))
                    return;

                if (PicRemove != pic) //Если текущая картинка равна картинки которую мы запомнили по щелчку, то удаляем объект
                    return;

                List.Remove(Path); //Удаление в списке путь текущего фото   
                RemovePicture(pic,panel);
                //AddPicture(List,panel);
            };


        }

        void RemovePicture(PictureBox pic, Panel panel)
        {
            panel.Controls.Remove(pic);
            var point = new Point(0, 0);
            foreach (Control item in panel.Controls)
            {
                item.Location = point;
                point.X += 80;
            }
        }
      

        private void PhotoForm_Load(object sender, EventArgs e)
        {

        }

        private void PhotoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }
    }
}
