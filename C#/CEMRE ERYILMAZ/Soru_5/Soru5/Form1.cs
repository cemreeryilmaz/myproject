using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt32(txtsicaklik.Text);
            if (x<0)
            {
                MessageBox.Show("SOĞUK");
            }
            else if (x>0 && x<15)
            {
                MessageBox.Show("ILIK");
            }
            else
            {
                MessageBox.Show("SICAK");
            }
        }
    }
}
