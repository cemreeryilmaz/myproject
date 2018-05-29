using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final3
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

            for (int satir = 0; satir < 8; satir++)
            {
                for (int sutun = 0; sutun < 8; sutun++)
                {
                    if((satir % 2 == 0 && sutun % 2 == 0) || (satir % 2 == 1 && sutun % 2 == 1))
                    {
                        g.FillRectangle(Brushes.White, satir * 50, sutun * 50,50,50);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.Black, satir * 50, sutun * 50, 50, 50);
                    }
                }
                pictureBox1.Image = bmp;
            }

        }
    }
}
