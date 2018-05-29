using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_5
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

            Point[] noktalar = new Point[]{ new Point(50,50), 
                                            new Point(250, 250), 
                                            new Point(50, 250), 
                                            new Point(250, 50) };

            g.DrawPolygon(Pens.Red, noktalar);

            g.DrawString("İstanbul Arel Üniversitesi",
                         new Font("Times New Roman", 25),
                         Brushes.Blue,
                         50, 50);
            
            pictureBox1.Image = bmp;
        }
    }
}
