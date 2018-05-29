using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_16
{
    public partial class Form1 : Form
    {
        int acı = 0;

        private void AracCiz()
        {
            Bitmap bmp = new Bitmap(300, 300);
            Graphics g = Graphics.FromImage(bmp);

            g.FillRectangle(Brushes.Blue, 50, 50, 200, 100);

            g.TranslateTransform(100, 150);
            g.RotateTransform(acı);
            for (int i = 0; i < 8; i++)
            {
                g.DrawPie(new Pen(Color.Black, 5), -40, -40, 80, 80, i * 45, 45);
            }

            g.ResetTransform();

            g.TranslateTransform(190, 150);
            g.RotateTransform(acı);
            for (int i = 0; i < 8; i++)
            {
                g.DrawPie(new Pen(Color.Black, 5), -40, -40, 80, 80, i * 45, 45);
            }

            pictureBox1.Image = bmp;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AracCiz();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            acı += 5;
            AracCiz();
            if (acı == 360)
                acı = 0;


            pictureBox1.Left += 3;
            if(pictureBox1.Left >= this.Width)
            {
                pictureBox1.Left = -pictureBox1.Width;
            }
        }
    }
}
