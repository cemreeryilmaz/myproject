using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_11
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
           

            for (int satır = 0; satır < 8; satır++)
            {
                for (int sutun = 0; sutun < 8; sutun++)
                {
                    if ((satır % 2 == 0 && sutun % 2 == 0) || (satır % 2 == 1 && sutun % 2 == 1))
                        g.FillRectangle(Brushes.White, sutun * 50, satır * 50, 50, 50);
                    else
                        g.FillRectangle(Brushes.Black, sutun * 50, satır * 50, 50, 50);

                }
            }

            pictureBox1.Image = bmp;
        }
    }
}
