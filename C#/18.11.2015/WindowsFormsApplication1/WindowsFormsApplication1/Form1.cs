using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGunler_Click(object sender, EventArgs e)
        {
            string[] gunler = new string[7];
            gunler[0] = "Pazartesi";
            gunler[1] = "Salı";
            gunler[2] = "Çarşamba";
            gunler[3] = "Perşembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";

            int deger = Convert.ToInt32(numericUpDown1.Value.ToString());
            MessageBox.Show("Gün : " + gunler[deger]);
        }

        private void btnAylar_Click(object sender, EventArgs e)
        {
            string[] aylar = new string[12];
            aylar[0] = "Ocak";
            aylar[1] = "Şubat";
            aylar[2] = "Mart";
            aylar[3] = "Nisan";
            aylar[4] = "Mayıs";
            aylar[5] = "Haziran";
            aylar[6] = "Temmuz";
            aylar[7] = "Ağustos";
            aylar[8] = "Eylül";
            aylar[9] = "Ekim";
            aylar[10] = "Kasım";
            aylar[11] = "Aralık";
            comboBox1.Items.Clear();

            for (int i = 0; i < aylar.Length; i++)
            {
                comboBox1.Items.Add(aylar[i]);
            }

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedIndex + 1 + ". ay = " + comboBox1.SelectedItem.ToString());
        }

        private void btnMevsim_Click(object sender, EventArgs e)
        {
            string[] mevsimler = new string[4];
            mevsimler[0] = "İlkbahar";
            mevsimler[1] = "Yaz";
            mevsimler[2] = "Sonbahar";
            mevsimler[3] = "Kış";

            foreach (string mevsim in mevsimler)
            {
                lstmevsim.Items.Add(mevsim);
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            string[] diller = new string[5];
            diller[0] = "c++";
            diller[1] = "c#";
            diller[2] = "java";
            diller[3] = "sql";
            diller[4] = "delphi";

            string aranacak = Interaction.InputBox("aranacak dil : ");

            int a = Array.BinarySearch(diller, aranacak);
            MessageBox.Show(a + 1 + ".satırda " + aranacak + " bulunmaktadır.");
            

        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            string[] diller = new string[5];
            diller[0] = "c++";
            diller[1] = "c#";
            diller[2] = "java";
            diller[3] = "sql";
            diller[4] = "delphi";

            Array.Sort(diller);
            //Array.Reverse(diller);
            lstSırala.Items.Clear();

            foreach (string dil in diller)
            {
                lstSırala.Items.Add(dil);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] diller = new string[5];
            diller[0] = "c++";
            diller[1] = "c#";
            diller[2] = "java";
            diller[3] = "sql";
            diller[4] = "delphi";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] diller = new string[5];
            diller[0] = "c++";
            diller[1] = "c#";
            diller[2] = "java";
            diller[3] = "sql";
            diller[4] = "delphi";
            lstSırala.Items.Clear();
            int a = Convert.ToInt32( Interaction.InputBox("başlangıç değeri = "));
            int b = Convert.ToInt32(Interaction.InputBox("bitiş değeri = "));
            Array.Clear(diller, a, b);
            for (int i = 0; i < diller.Length; i++)
            {
                if (diller[i] !=null)
                {
                    lstSırala.Items.Add(diller[i]);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] il = new string[3];
            il[0] = "İstanbul";
            il[1] = "Ankara";
            il[2] = "İzmir";
        }

        private void comboiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboİlçeler.Items.Clear();
            if (comboiller.SelectedIndex == 0)
            {
                comboİlçeler.Items.Add("Bakırköy");
                comboİlçeler.Items.Add("Kadıköy");
                comboİlçeler.Items.Add("Sefaköy");
            }
            if (comboiller.SelectedIndex == 1)
            {
                comboİlçeler.Items.Add("Mamak");
                comboİlçeler.Items.Add("Yenimahalle");
            }
            if (comboiller.SelectedIndex == 2)
            {
                comboİlçeler.Items.Add("Yeni Foça");
                comboİlçeler.Items.Add("Eski Foça");
                comboİlçeler.Items.Add("Göztepe");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random sayi = new Random();
            int[] rnd = new int[6];
            rnd[0] = sayi.Next(1, 49);
            rnd[1] = sayi.Next(1, 49);
            rnd[2] = sayi.Next(1, 49);
            rnd[3] = sayi.Next(1, 49);
            rnd[4] = sayi.Next(1, 49);
            rnd[5] = sayi.Next(1, 49);

            foreach (int rastgele in rnd)
            {
                listBox1.Items.Add(rastgele);
            }

        }


        
    }
}
