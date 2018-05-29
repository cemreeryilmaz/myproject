using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_9
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

            for (int i = 15; i>=0; i--)
            {
                if(i%2 == 0)
                {
                    g.FillEllipse(Brushes.Red, 200 - (i * 25), 200 - (i * 25), i * 50, i * 50);
                }
                else
                {
                    g.FillEllipse(Brushes.Black, 200 - (i * 25), 200 - (i * 25), i * 50, i * 50);
                }
            }

            pictureBox1.Image = bmp;
        }
    }
}
