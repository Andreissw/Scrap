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
    public partial class FormView : Form
    {
        string Path;
        public FormView(Image pic,string path)
        {
            Opacity = 0;
            Path = path;
            InitializeComponent();

            pictureBox1.Image = pic;            

            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                try
                {
                    if ((Opacity += 0.05d) == 1) timer.Stop();
                }
                catch (Exception)
                {                   
                }
                
            });
            timer.Interval = 20;
            timer.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Path);
            }
            catch (Exception s)
            {

                MessageBox.Show($"Не удалось открыть фотографию \n{s}");
            }
            
        }
    }
}
