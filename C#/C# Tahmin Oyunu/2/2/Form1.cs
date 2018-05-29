using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        int tahminsayisi;

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            tahminsayisi++;

            if (Convert.ToInt32(txtTahmin.Text) != sayi)
            {
                if (Convert.ToInt32(txtTahmin.Text) < sayi)

                {
                    MessageBox.Show("Yukarı");
                }
                else
                {
                    MessageBox.Show("Aşağı");

                 }

                  }
                else
                {
                    MessageBox.Show("Tebrikler Bildin Bu Kadar Tahminde Bulunarak Yaptın=" +tahminsayisi + " ");
                }

            }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(0, 100);
            lblUretilen.Text = sayi.ToString();
        }
        }
    }

