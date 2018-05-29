using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnarasinda_Click(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt32(txtx.Text);
            if (x>0 && x<100)
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
