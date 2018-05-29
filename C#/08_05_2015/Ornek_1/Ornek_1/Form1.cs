using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_1
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
            
            //Çizim
            Graphics g = Graphics.FromImage(bmp);

            g.FillRectangle(Brushes.Pink, 0, 0, 300, 300);
            g.DrawLine(Pens.Black, 0, 0, 300, 300);
            g.DrawLine(Pens.Black, 0, 300, 300, 0);


            pictureBox1.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = pictureBox1.Image;
                img.Save(saveFileDialog1.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
