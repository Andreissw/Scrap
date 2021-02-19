using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrap
{
    public partial class FormInfo : Form
    {
        Color color;
        public FormInfo(int idLazer)
        {
            InitializeComponent();
            DecodeLB.Text = "Barcode - " + GetDecode(idLazer);

            UserLB.Text = $"Последнее действие произведено пользователем - {GetUserName(idLazer, getUserid(idLazer))}";
            PathDoc.Text = GetPathDoc(idLazer);
            DescTB.Text = GetDesc(idLazer);
            StatulLB.Text = GetStatus(idLazer);
            StatulLB.BackColor = color;
            Vinovnik.Text = "Виновник - " + GetCode(idLazer);
            CodeDefectLB.Text = "Код Дефекта - " + GetCodeDef(idLazer);

            var k = 1;
            var x = 0;            
            foreach (var item in GetListPhoto(idLazer))
            {
                var point = new Point(x, 0);
                CreatePicture(item,k,point,PanelNew);
                k += 1;
                x += 80;
            }
            
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {

        }

        string GetStatus(int idlazer)
        {
            using (var qa = new QAEntities())
            {
                var Result = qa.Scrap_Status.Where(c => c.Idlazer == idlazer).Select(c => c.Status).FirstOrDefault();

                if (Result == 1)
                {
                    color = Color.YellowGreen;
                    return "Плата имеет статус ОК";
                }
                else if(Result == 2)
                {
                    color = Color.Yellow;
                    return "Плата имеет статус Карантин";
                }
                else
                {
                    color = Color.Coral;
                    return "Плата имеет статус Брак";
                }
            }
        }

        string GetCode(int idlazer)
        {
            using (var qa = new QAEntities())
            {
                return qa.Scrap_Log.Where(c => c.IdLazer == idlazer).OrderByDescending(c=>c.Date).Select(c => qa.Scrap_Culprit.Where(b=>b.Code == c.Code).Select(v=>v.Code + " - " + v.Description).FirstOrDefault()).FirstOrDefault();
                
            }
        }

        string GetCodeDef(int idlazer)
        {
            using (var qa = new QAEntities())
            {
                return qa.Scrap_Log.Where(c => c.IdLazer == idlazer).OrderByDescending(c => c.Date).Select(c => qa.Scrap_DefectCode.Where(b => b.Code == c.DefectCode).Select(v => v.Code + " - " + v.Description).FirstOrDefault()).FirstOrDefault();

            }
        }

        int getUserid(int idlazer)
        {
            using (var qa = new QAEntities())
            {
                return qa.Scrap_Log.Where(c => c.IdLazer == idlazer).OrderByDescending(c => c.Date).Select(c => c.UserID).FirstOrDefault();
            }
        }

        string GetDesc(int idlazer)
        {
            using (var qa = new QAEntities())
            {
                return qa.Scrap_Description.Where(c => c.IdLazer == idlazer).Select(c => c.Description).FirstOrDefault();
            }
        }

        string GetPathDoc(int idlazer)
        {
            using (var qa = new QAEntities())
            {
                return qa.Scrap_Description.Where(c => c.IdLazer == idlazer).Select(c => c.PathDocument).FirstOrDefault();
            }
        }

        string GetUserName(int idlazer,int userid)
        {
            using (var fa = new FASEntities())
            {
                return fa.FAS_Users.Where(c => c.UserID == userid).Select(c => c.UserName).FirstOrDefault();
            }
        }

        string GetDecode(int idlazer)
        {
            using (var smd = new SMDCOMPONETSEntities1())
            {
                return smd.LazerBase.Where(c => c.IDLaser == idlazer).Select(c => c.Content).FirstOrDefault();
            }
        }

        List<string> GetListPhoto(int idLazer)
        {
            using (var qa = new QAEntities())
            {
                return qa.Scrap_Data.Where(c => c.IdLazer == idLazer).Select(c=>c.PathPhoto).ToList();
            }
        }

        FormView ViewForm;
        void CreatePicture(string Path, int count, Point point, Panel panel)
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
                if (e.Button == MouseButtons.Left)
                {
                    if (ViewForm != null)
                        ViewForm.Close();

                    ViewForm = new FormView(pic.Image,Path);
                    ViewForm.Show();
                }

            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenPDF_Click(object sender, EventArgs e)
        {
            var path = PathDoc.Text;
            if (path == string.Empty)            
                return;
            if (!File.Exists(path))
            {
                MessageBox.Show("Произошла ошибка, файл не найден!");
                return;
            }

            Process.Start(path);
            //File.OpenRead(path);
        }
    }
}
