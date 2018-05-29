using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpDTarih_ValueChanged(object sender, EventArgs e)
        {
            txtYas.Text = (DateTime.Now.Year - dtpDTarih.Value.Year).ToString();
        }
    }
}
