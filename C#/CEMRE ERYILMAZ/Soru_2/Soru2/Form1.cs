using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(txtx.Text);
            y = Convert.ToInt32(txty.Text);

            if (x>y)
            {
                MessageBox.Show("X Y'den Büyüktür..");
            }
            else if (x<y)
            {
                MessageBox.Show("X Y'den Küçüktür..");
            }
            else
            {
                MessageBox.Show("X = Y ");
            }
        }
    }
}
