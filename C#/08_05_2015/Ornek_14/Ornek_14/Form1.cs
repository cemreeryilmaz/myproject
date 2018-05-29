using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(300, 300);
            Graphics g = Graphics.FromImage(bmp);

            g.TranslateTransform(150, 150);

            g.RotateTransform(30);
            g.DrawLine(new Pen(Color.Blue, 5), 0, 0, 0, -100);
            g.RotateTransform(30);
            g.DrawLine(new Pen(Color.Green, 5), 0, 0, 0, -100);
            g.RotateTransform(30);
            g.DrawLine(new Pen(Color.Navy, 5), 0, 0, 0, -100);

            g.RotateTransform(30);
            g.DrawLine(new Pen(Color.Blue, 5), 0, 0, 0, -100);
            g.RotateTransform(30);
            g.DrawLine(new Pen(Color.Green, 5), 0, 0, 0, -100);
            g.RotateTransform(30);
            g.DrawLine(new Pen(Color.Navy, 5), 0, 0, 0, -100);


            g.RotateTransform(30);
            g.DrawLine(new Pen(Color.Blue, 5), 0, 0, 0, -100);
            g.RotateTransform(30);
            g.DrawLine(new Pen(Color.Green, 5), 0, 0, 0, -100);
            g.RotateTransform(30);
            g.DrawLine(new Pen(Color.Navy, 5), 0, 0, 0, -100);

            g.RotateTransform(30);
            g.DrawLine(new Pen(Color.Blue, 5), 0, 0, 0, -100);
            g.RotateTransform(30);
            g.DrawLine(new Pen(Color.Green, 5), 0, 0, 0, -100);
            g.RotateTransform(30);
            g.DrawLine(new Pen(Color.Navy, 5), 0, 0, 0, -100);
            pictureBox1.Image = bmp;
        }
    }
}
