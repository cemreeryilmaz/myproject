using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_3
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

            g.DrawEllipse(Pens.Black, 50, 50, 200, 200);
            g.DrawArc(new Pen(Color.Red, 5), 50, 50, 200, 200, 90, 180);
            g.DrawPie(new Pen(Color.Blue, 5), 50, 50, 200, 200, 0, 45);

            pictureBox1.Image = bmp;
        }
    }
}
