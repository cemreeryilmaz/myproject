using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hobi;
            hobi = "Hobileriniz: ";

            if (checkBox1.Checked == true)
            {
                hobi = hobi + "Bisiklet Sürmek, ";
            }
            if (checkBox2.Checked == true)
            {
                hobi = hobi + " Yüzmek, ";
            }
            if (checkBox3.Checked == true)
            {
                hobi = hobi + " Kitap Okumak,";
            }
            MessageBox.Show(hobi.ToString());
        }
    }
}
