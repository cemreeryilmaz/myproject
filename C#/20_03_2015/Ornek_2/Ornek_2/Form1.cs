using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.Text = "Deactivate";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Text = "Activated";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "Click";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                label2.Text = "LEFT Click";
            else if(e.Button == System.Windows.Forms.MouseButtons.Right)
                label2.Text = "RIGHT Click";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Kapatmak İstediğine Emin misin?", "Closing Örnek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.No)
                e.Cancel = true;
            else
                MessageBox.Show("Güle Güle... :)");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label3.Text = "KEYDOWN = " + e.KeyData.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label3.Text = "KEYPRESS= " + e.KeyChar.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label3.Text = "KEYUP= " + e.KeyData.ToString();
        }
    }
}
