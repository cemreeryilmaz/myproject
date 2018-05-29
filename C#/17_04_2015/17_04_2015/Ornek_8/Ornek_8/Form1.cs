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

        private void NMUD_ValueChanged(object sender, EventArgs e)
        {
            Color renk = Color.FromArgb(Convert.ToInt32(nmud_red.Value), 
                                        Convert.ToInt32(nmud_green.Value), 
                                        Convert.ToInt32(nmud_blue.Value));
            panel1.BackColor = renk;
        }
    }
}
