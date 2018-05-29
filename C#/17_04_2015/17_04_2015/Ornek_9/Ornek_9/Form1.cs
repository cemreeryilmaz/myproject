using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            this.Text += "popup";
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            this.Text += "popup";
        }
    }
}
