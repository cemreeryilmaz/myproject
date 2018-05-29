using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArtır_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                progressBar1.Value = progressBar1.Minimum;
            }

            label1.Text ="value = " + progressBar1.Value;
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > progressBar1.Minimum)
                progressBar1.Value--;
            else
                progressBar1.Value = progressBar1.Maximum;

            label1.Text = "value = " + progressBar1.Value;
        }
    }
}
