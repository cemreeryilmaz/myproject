using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baglantiCumlesi = "Data Source=.; Initial Catalog=ogrenci; Integrated Security=true;";

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);

            SqlCommand komut1 = new SqlCommand("insert into ogrenci(ogrenci_adi,ogrenci_soyadi) VALUES(@ogrenci_adi,@ogrenci_soyadi)",baglanti);

            komut1.Parameters.AddWithValue("@ogrenci_adi", textBox1.Text);
            komut1.Parameters.AddWithValue("@ogrenci_soyadi", textBox2.Text);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut1.ExecuteNonQuery();
            MessageBox.Show("Başarılı");
        }
    }
}
