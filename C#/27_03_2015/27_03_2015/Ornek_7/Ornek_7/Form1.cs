using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukarı_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if(index > 0)//(index != -1 && index != 0)
            {
                listBox1.Items.Insert(index - 1, listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.SelectedIndex = index - 1;
            }
        }

        private void btnAsagı_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1 && index < listBox1.Items.Count - 1)
            {
                listBox1.Items.Insert(index + 2, listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.SelectedIndex = index + 1;
            }
        }
    }
}
