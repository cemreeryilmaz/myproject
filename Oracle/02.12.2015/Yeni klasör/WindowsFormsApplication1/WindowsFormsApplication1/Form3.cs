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
        string baglanticumlesi = "Data Source=.;Initial Catalog=okul;Integrated Security=true";

        private void temizle()
        {
            txtAd.Text = "";
            txtAdres.Text = "";
            txtEmail.Text = "";
            txtNo.Text = "";
            txtSoyad.Text = "";
            txtTel.Text = "";
            cmbBolum.SelectedIndex = -1;
        }

        private void bolumdoldur()
        {
            string sorgu = "Select bolumID,bolumAd from bolum";

            SqlConnection baglanti = new SqlConnection(baglanticumlesi);
            SqlCommand komut1 = new SqlCommand(sorgu, baglanti);

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            SqlDataReader oku = komut1.ExecuteReader();

            DataTable tablo = new DataTable();
            tablo.Load(oku);
            cmbBolum.DataSource = tablo;
            cmbBolum.ValueMember = "bolumID";
            cmbBolum.DisplayMember = "bolumAd";

            cmbBolum.SelectedIndex = -1;
        }

        private void griddoldur()
        {
            SqlConnection baglanti = new SqlConnection(baglanticumlesi);
            SqlCommand komut1 = new SqlCommand("SELECT * from ogrenci", baglanti);
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            SqlDataReader oku = komut1.ExecuteReader();

            DataTable tablo = new DataTable();
            tablo.Load(oku);
            dataGridView1.DataSource = tablo;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            temizle();
            bolumdoldur();
            griddoldur();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (txtAd.Text == "" || txtAdres.Text == "" || txtEmail.Text == "" || txtNo.Text == "" || txtSoyad.Text == "" || txtTel.Text == "" || cmbBolum.SelectedIndex == -1)
            {
                MessageBox.Show("Kırmızı alanları doldurmanız gerekmektedir.");
                return;
            }
            SqlConnection baglanti = new SqlConnection(baglanticumlesi);

            SqlCommand komut1 = new SqlCommand("insert into ogrenci(ogrenciAd,ogrenciSoyad,ogrenciNo,ogrenciTel,ogrenciAdres,ogrenciEmail,ogrenciBolumId) values(@ogrenciAd,@ogrenciSoyad,@ogrenciNo,@ogrenciTel,@ogrenciAdres,@ogrenciEmail,@ogrenciBolumID)", baglanti);

            komut1.Parameters.AddWithValue("@ogrenciAd", txtAd.Text);
            komut1.Parameters.AddWithValue("@ogrenciSoyad", txtSoyad.Text);
            komut1.Parameters.AddWithValue("@ogrenciNo", txtNo.Text);
            komut1.Parameters.AddWithValue("@ogrenciTel", txtTel.Text);
            komut1.Parameters.AddWithValue("@ogrenciAdres", txtAdres.Text);
            komut1.Parameters.AddWithValue("@ogrenciEmail", txtEmail.Text);
            komut1.Parameters.AddWithValue("@ogrenciBolumID", cmbBolum.SelectedValue);

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            komut1.ExecuteNonQuery();
            MessageBox.Show("Başarılı");
            temizle();

            griddoldur();
        }
    }
}
