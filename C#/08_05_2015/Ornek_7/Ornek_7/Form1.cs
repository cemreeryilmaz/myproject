using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_7
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

            g.FillRectangle(Brushes.White, 0, 0, 300, 300);
            g.FillEllipse(Brushes.Blue, 50, 50, 200, 200);
            g.FillPie(Brushes.Navy, 50, 50, 200,200, 0, 45);

            pictureBox1.Image = bmp;
        }
    }
}
