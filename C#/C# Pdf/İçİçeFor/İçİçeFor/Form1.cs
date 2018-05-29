using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İçİçeFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)     
                for (int k = 0; k < 10; k++)
                    for (int p = 0; p < 10; p++)
                    {
                        listBox1.Items.Add("i=" + i + " , " + "k=" + k + " , " + " l=" + p);
                    }       
        }
    }
}
