using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_4
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

            Point[] pt = new Point[] { new Point(50, 50), new Point(250, 50), new Point(250, 250), new Point(50, 250) };

            g.DrawRectangle(Pens.Black, 50, 50, 200, 200);
            g.DrawCurve(Pens.Red, pt, 0.8f);

            g.DrawClosedCurve(Pens.Blue, pt);

            pictureBox1.Image = bmp;
        }
    }
}
