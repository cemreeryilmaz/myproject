using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormKayıtUygulamaları
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
            if (textBox3.Text == textBox5.Text)
            {
                listBox1.Items.Add(label1.Text + " : " + textBox1.Text);
                listBox1.Items.Add(label2.Text + " : " + textBox2.Text);
                listBox1.Items.Add(label5.Text + " : " + textBox3.Text);
                if (radioButton1.Checked==true)
                {
                    listBox1.Items.Add(label3.Text + " : " + radioButton1.Text);
                }
                if (radioButton2.Checked == true)
                {
                    listBox1.Items.Add(label3.Text + " : " + radioButton2.Text);
                }
                listBox1.Items.Add(label4.Text + " : " + textBox4.Text);
                if (checkBox1.Checked == true)
                {
                    hobi = hobi + checkBox1.Text + " , ";   
                }
                if (checkBox2.Checked == true)
                {
                    hobi = hobi + checkBox2.Text + " , ";
                }
                if (checkBox3.Checked == true)
                {
                    hobi = hobi + checkBox3.Text + " , ";
                }
                if (checkBox4.Checked == true)
                {
                    hobi = hobi + checkBox4.Text + " , ";
                }
                if (checkBox5.Checked == true)
                {
                    hobi = hobi + checkBox5.Text + " , ";
                }
                listBox1.Items.Add(label6.Text + " : " + Convert.ToString(hobi));
            }
            else
            {
                MessageBox.Show("E-Mail Doğrulanamadı...! ");
                listBox1.Items.Add("Doğru Değil");
            }
        }
    }
}
