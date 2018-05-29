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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillEllipse(Brushes.Pink, 50, 50, 250, 250);
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Pink, 50, 50, 250, 250);
        }
    }
}
