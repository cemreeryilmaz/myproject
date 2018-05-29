using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Text = "C# Uygulaması";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox2.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox3.ForeColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkBox4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkBox4.Visible = true;
        }
    }
}
