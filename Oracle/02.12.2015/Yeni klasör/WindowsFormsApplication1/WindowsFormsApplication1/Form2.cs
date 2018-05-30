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

        string baglanticumlesi ="Data Source=.;Initial Catalog=okul;Integrated Security=true";
        private int kullaniciID = 0, a = 0;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtkullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Ve Şifre Girmelisiniz...!");
                return;
            }

            SqlConnection baglanti = new SqlConnection(baglanticumlesi);
            SqlCommand komut1 = new SqlCommand("select personelID,personelKullaniciAd from personel where personelKullaniciAd='" + txtkullaniciAdi.Text + "' and personelKullaniciSifre='" + txtSifre.Text + "'", baglanti);

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            SqlDataReader oku = komut1.ExecuteReader();
            DataTable tablo = new DataTable();
            tablo.Load(oku);
            try
            {
                kullaniciID = int.Parse(tablo.Rows[0]["personelID"].ToString());
            }
            catch
            {
                MessageBox.Show("Hata");
            }

            if (kullaniciID == 0)
            {
                a++;
                if (a == 3)
                {
                    MessageBox.Show("Üç kez Yanlış girdiniz program kapatılıyor...!");
                    this.DialogResult = DialogResult.Cancel;
                }
                else return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                Form2 flogin = new Form2();
                this.Tag = kullaniciID.ToString();
                this.Close();
            }
       }
    }
}
