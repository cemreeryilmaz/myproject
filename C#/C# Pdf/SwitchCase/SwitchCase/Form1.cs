using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(numericUpDown1.Value.ToString());

            switch (i)
            {
                case 0:
                    MessageBox.Show("Sıfır");
                    break;
                case 1:
                    MessageBox.Show("Bir");
                    break;
                case 2:
                    MessageBox.Show("İki");
                    break;
            }
        }
    }
}
