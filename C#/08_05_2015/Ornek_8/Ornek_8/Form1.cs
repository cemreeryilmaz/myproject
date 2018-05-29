using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(400, 500);
            Graphics g = Graphics.FromImage(bmp);

            g.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);
            g.FillEllipse(Brushes.Black, 150, 50, 100, 100);
            g.FillEllipse(Brushes.Black, 150, 350, 100, 100);

            g.FillRectangle(Brushes.Red, 50, 100, 300, 300);
            g.FillRectangle(Brushes.Black, 50, 200, 300, 100);

            pictureBox1.Image = bmp;
        }
    }
}
