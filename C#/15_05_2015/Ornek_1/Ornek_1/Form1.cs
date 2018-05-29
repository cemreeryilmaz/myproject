using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_1
{
    public partial class Form1 : Form
    {
        Bitmap zemin = new Bitmap(Properties.Resources.zemin, 130, 130);
        Bitmap akrep = new Bitmap(Properties.Resources.akrep, 13, 130);
        Bitmap yelkovan = new Bitmap(Properties.Resources.yelkovan, 13, 130);
        Bitmap gobek = new Bitmap(Properties.Resources.gobek, 13, 130);
        Bitmap saniye = new Bitmap(Properties.Resources.saniye, 13, 130);

        Bitmap bmpSaat = new Bitmap(130, 130);

        private void SaatCiz()
        {
            bmpSaat = new Bitmap(130, 130);
            Graphics g = Graphics.FromImage(bmpSaat);

            g.TranslateTransform(65, 65);

            //zemin çiz
            g.DrawImage(zemin, -65, -65);
            //akrep çiz
            g.RotateTransform(DateTime.Now.Hour * 30);
            g.DrawImage(akrep, -6.5f, -65);
            g.RotateTransform(DateTime.Now.Hour * -30);
            //yelkovan çiz
            g.RotateTransform(DateTime.Now.Minute * 6);
            g.DrawImage(yelkovan, -6.5f, -65);
            g.RotateTransform(DateTime.Now.Minute * -6);
            //gobek
            g.DrawImage(gobek, -6.5f, -65);
            //saniye çiz
            g.RotateTransform(DateTime.Now.Second * 6);
            g.DrawImage(saniye, -6.5f, -65);
            g.RotateTransform(DateTime.Now.Second * -6);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SaatCiz();
            pictureBox1.Image = bmpSaat;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SaatCiz();
            pictureBox1.Image = bmpSaat;
        }
    }
}
