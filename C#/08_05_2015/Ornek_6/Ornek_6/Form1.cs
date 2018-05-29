using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap aslan = new Bitmap(Properties.Resources.aslan, 64, 64);
            Bitmap kedi = new Bitmap(Properties.Resources.kedi, 64, 64);
            Bitmap kopek = new Bitmap(Properties.Resources.kopek, 64, 64);

            Bitmap bmp = new Bitmap(300, 300);
            Graphics g = Graphics.FromImage(bmp);

            g.FillRectangle(Brushes.Pink, 0, 0, 300, 300);

            g.DrawImage(aslan, 50, 50);
            g.DrawImage(kedi, 120, 50);
            g.DrawImage(kopek, 190, 50);


            g.DrawImage(aslan, 50, 120);
            g.DrawImage(kedi, 120, 120);
            g.DrawImage(kopek, 190, 120);

            pictureBox1.Image = bmp;
        }
    }
}
