using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToLongDateString();
            //label1.Text = dateTimePicker1.Value.ToShortDateString();

            label3.Text = "Yıl = " + dateTimePicker1.Value.Year + ", Ay = " +
                          dateTimePicker1.Value.Month + ", Gün = " +
                          dateTimePicker1.Value.Day;

            this.Text = "DTP1 = " + dateTimePicker1.Text;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker2.Value.ToLongTimeString();
            //label2.Text = dateTimePicker2.Value.ToShortTimeString();

            label4.Text = "Saat = " + dateTimePicker2.Value.Hour + ", Dakika = " +
                          dateTimePicker2.Value.Minute + ", Saniye = " +
                          dateTimePicker2.Value.Second;

            this.Text = "DTP2 = " + dateTimePicker2.Text;
        }
    }
}
