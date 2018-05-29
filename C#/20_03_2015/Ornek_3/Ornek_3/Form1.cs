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
            label1.Text = "Formların Load Olayı, form kullanıcıya gösterilmeden hemen önce çalışır...";
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "MOUSE ENTER";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "MOUSE LEAVE";
        }

        private void btnTahir_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            btnTahir.Location = new Point(rnd.Next(this.Size.Width - btnTahir.Width),
                                            rnd.Next(this.Size.Height - btnTahir.Height));
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = "MOVE = " + e.Location.ToString();
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            label4.Text = "Resize Begin";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            label4.Text = "Resize = " + this.Size.ToString();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            label4.Text = "Resize End";
        }

    }
}
