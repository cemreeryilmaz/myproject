using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = radioButton1.Checked.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Text = radioButton2.Checked.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Text = radioButton3.Checked.ToString();
        }
    }
}
