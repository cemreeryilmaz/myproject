using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seçili Satır: " + listBox1.SelectedItem);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Satır Sayısı= " + Convert.ToString(listBox1.Items.Count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show(listBox1.SelectedItem + " Bu Kayıt Silinsin Mi? ", " Silme Onayı ", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
