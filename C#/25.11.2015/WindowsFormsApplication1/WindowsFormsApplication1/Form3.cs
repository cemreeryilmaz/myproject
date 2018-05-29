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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baglantiCumlesi = "Data Source=.; Initial Catalog=ogrenci; Integrated Security=true;";
            
            try
            {
                if(textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Arama kriterlerinden en az birini girmek zorundasınız..!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }
                string sorgubaslik = "Select ogrenci_id,ogrenci_adi,ogrenci_soyadi From ogrenci Where";
                string sorgu = "";

                if(textBox1.Text != "") sorgu = " ogrenci_adi like '%" + textBox1.Text + "%'";
                if(textBox2.Text != "")
                {
                    if(sorgu != "") sorgu +=" and";
                    sorgu += " ogrenci_soyadi like '%" + textBox2.Text + "%'";
                }

                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);

                string sorgu_butun = sorgubaslik+sorgu;
                SqlCommand komut1 = new SqlCommand(sorgu_butun,baglanti);

                if(baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlDataReader oku = komut1.ExecuteReader();

                DataTable tablo = new DataTable();
                tablo.Load(oku);
                dataGridView1.DataSource = tablo;

                dataGridView1.ClearSelection();

            }
            catch
            {
                MessageBox.Show("Arama parametrelerinde hata var.Kontrol edip tekrar deneyin.","Uyarı" , MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }
    }
}
