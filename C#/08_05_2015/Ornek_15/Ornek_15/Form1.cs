using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_15
{
    public partial class Form1 : Form
    {
        int acı = 0;

        private void TekerCiz()
        {
            Bitmap bmp = new Bitmap(300, 300);
            Graphics g = Graphics.FromImage(bmp);
            
            g.TranslateTransform(150,150);
            g.RotateTransform(acı);

            for (int i = 0; i < 8; i++)
            {
                g.DrawPie(new Pen(Color.Black, 10), -100, -100, 200, 200, i * 45, 45);
            }
            g.DrawEllipse(new Pen(Color.Black, 25), -100, -100, 200, 200);

            pictureBox1.Image = bmp;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TekerCiz();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            acı += 5;
            TekerCiz();

            if (acı == 360)
                acı = 0;
        }
    }
}
