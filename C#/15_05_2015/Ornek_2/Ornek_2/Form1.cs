using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_2
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(7);
            game.GameTick += game_GameTick;
            game.GameOverEvent += game_GameOverEvent;
            game.Start();
        }

        void game_GameOverEvent(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Yeniden Oynamak İster misiniz?", "Arel Snake V1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(cevap == DialogResult.Yes)
            {
                game.Start();
            }
            else
            {
                Application.Exit();
            }
        }

        void game_GameTick(object sender, Bitmap game_screen)
        {
            pictureBox1.Image = game_screen;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            game.KeyDown(sender, e);
        }
    }
}
