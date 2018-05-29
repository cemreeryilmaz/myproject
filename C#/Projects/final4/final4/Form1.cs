using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(450, 450);
            Graphics g = Graphics.FromImage(bmp);

            Rectangle elips = new Rectangle(50, 50, 350, 350);

            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    g.FillEllipse(Brushes.Red, elips);
                }
                else
                {
                    g.FillEllipse(Brushes.Black, elips);
                }

                elips.X += 25;
                elips.Y += 25;
                elips.Width -= 50;
                elips.Height -= 50;

            }
            pictureBox1.Image = bmp;
        }
    }
}
