using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkarsilastir_Click(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt32(txtsayi.Text);
            if (x<0 || x>100)
            {
                MessageBox.Show("EVET");
            }
            else
            {
                MessageBox.Show("HAYIR");
            }


        }
    }
}
