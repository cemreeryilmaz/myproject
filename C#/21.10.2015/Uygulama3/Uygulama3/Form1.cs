using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s;
            s = listBox1.SelectedIndex;
            listBox2.Items.Add(listBox1.SelectedItem.ToString());
            listBox1.Items.RemoveAt(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s;
            s = listBox2.SelectedIndex;
            listBox1.Items.Add(listBox2.SelectedItem.ToString());
            listBox2.Items.RemoveAt(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else if (radioButton2.Checked==true)
            {
                listBox2.Items.Add(textBox1.Text);
            }
        }
    }
}
