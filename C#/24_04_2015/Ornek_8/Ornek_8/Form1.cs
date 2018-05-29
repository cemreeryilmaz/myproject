using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen kalem = new Pen(Color.Red, 4);
            kalem.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

            g.DrawLine(kalem, 100, 150, 200, 50); //d1
            g.DrawLine(kalem, 200, 50, 300, 150); //d2
            g.DrawLine(kalem, 100, 150, 300, 150); //d3
            g.DrawLine(kalem, 100, 150, 100, 350); //d4
            g.DrawLine(Pens.Red, 100, 350, 300, 350); //d5
            g.DrawLine(Pens.Red, 300, 350, 300, 150); //d6

            g.DrawString("Tahir'in Mekanı", new Font("Times New Roman", 16), Brushes.Blue, 120, 200);
        }
    }
}
