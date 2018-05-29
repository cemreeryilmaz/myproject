using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t = 1, a;

            a = Convert.ToInt32(Interaction.InputBox("Sayı Gir"));
            while (a != 0)
            {
                t = t*a;
                a = Convert.ToInt32(Interaction.InputBox("Sayı Gir"));
            }
            MessageBox.Show("Çarpım = "+t);
        }
    }
}
