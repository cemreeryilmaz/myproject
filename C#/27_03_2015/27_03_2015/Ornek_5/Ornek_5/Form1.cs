using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtEleman.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if(index != -1)
                listBox1.Items.RemoveAt(index);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if(index != -1)
            {
                listBox1.Items.Insert(index, txtEleman.Text);
                listBox1.Items.RemoveAt(index + 1);
                listBox1.SelectedIndex = index;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)//if(listBox1.SelectedIndex != -1)
                txtEleman.Text = listBox1.SelectedItem.ToString();
        }
    }
}
