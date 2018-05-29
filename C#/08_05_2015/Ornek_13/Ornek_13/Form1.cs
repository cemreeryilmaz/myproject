using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(400, 400);
            Graphics g = Graphics.FromImage(bmp);

            g.DrawRectangle(Pens.Black, 50, 50, 100, 100);
            
            g.TranslateTransform(150, 150);
            
            g.DrawRectangle(Pens.Black, 50, 50, 100, 100);
            g.DrawEllipse(Pens.Red, -100, -100, 100, 100);
            
            
            pictureBox1.Image = bmp;
        }
    }
}
