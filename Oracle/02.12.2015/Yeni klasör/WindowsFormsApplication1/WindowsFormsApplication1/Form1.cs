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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int AktifUserID;
        string baglanticumlesi = "Data Source=.;Initial Catalog = okul;Integrated Security=true";


        private void Form1_Load(object sender, EventArgs e)
        {
            
            Form2 FLogin = new Form2();
            FLogin.ShowDialog();
            try
            {
                if(FLogin.DialogResult == DialogResult.OK)
                {
                    AktifUserID = int.Parse(FLogin.Tag.ToString());
                    #region status bar
                    SqlConnection baglanti = new SqlConnection(baglanticumlesi);
                    SqlCommand komut1 = new SqlCommand("select personelAd,personelSoyad from personel where personelID=" + AktifUserID, baglanti);

                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    SqlDataReader oku = komut1.ExecuteReader();

                    DataTable tablo = new DataTable();
                    tablo.Load(oku);
                    tssusername.Text = tablo.Rows[0]["PersonelAd"].ToString() + " " + tablo.Rows[0]["PersonelSoyad"].ToString();
                    #endregion

                }
                else this.Close();
            }
            
            catch (Exception ex)
            {
               MessageBox.Show("Program Başlatılamadı. Hata: " + ex.Message,"Hata Oluştu");
                   this.Close();
               
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }
    }
}
