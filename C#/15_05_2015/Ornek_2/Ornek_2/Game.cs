using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_2
{
    class Game
    {

        public delegate void GameTickHandler(object sender, Bitmap game_screen);
        public delegate void GameOverEventHandler(object sender, EventArgs e);
        public event GameTickHandler GameTick;
        public event GameOverEventHandler GameOverEvent;

        private const int Width = 256, Height = 512;
        private Timer tmr = new Timer();

        Yılan yılan;
        Yem yem;
        Bitmap GameScreen;

        public Game(int uzunluk)
        {
            GameScreen = new Bitmap(Width, Height);

            yılan = new Yılan(uzunluk, Width, Height);
            yem = new Yem(1, Width, Height);
            tmr.Interval = 100;
            tmr.Tick += tmr_Tick;
            GameTick = new GameTickHandler(GameTick_fnk);
            GameOverEvent = new GameOverEventHandler(GameOverEvent_Fnk);
        }

        private void GameOverEvent_Fnk(object sender, EventArgs e) { }
        private void GameTick_fnk(object sender, Bitmap bmp) { }

        void tmr_Tick(object sender, EventArgs e)
        {
            yılan.YılanHareket();

            if (yılan.Kafa == yem.Yer)
            {
                yılan.Puan += yem.Puan;
                yem.Yerleştir(Width, Height);
                yılan.BoyUzat(1);
            }

            foreach (Point item in yılan.Govde)
            {
                if(item == yılan.Kafa)
                {
                    GameOver();
                    break;
                }
            }

            GameDraw();
            GameTick.Invoke(this, GameScreen);
        }

        private void GameDraw()
        {
            Graphics g = Graphics.FromImage(GameScreen);
            g.FillRectangle(Brushes.Black, 0, 0, GameScreen.Width, GameScreen.Height);

            g.FillRectangle(Brushes.Blue, yem.Yer.X, yem.Yer.Y, 16, 16);

            g.FillRectangle(Brushes.Red, yılan.Kafa.X, yılan.Kafa.Y, 16, 16);

            foreach (Point item in yılan.Govde)
            {
                g.FillRectangle(Brushes.Green, item.X, item.Y, 16, 16);
            }

            g.DrawString("Puan : " + yılan.Puan, new Font("Times New Roman", 14), Brushes.Cyan, 0, 0);
        }

        public void Start()
        {
            yılan = new Yılan(7, Width, Height);
            yem = new Yem(1, Width, Height);
            tmr.Enabled = true;
        }

        public void Resume()
        {
            tmr.Enabled = true;
        }

        public void GameOver()
        {
            tmr.Enabled = false;
            GameOverEvent.Invoke(this, new EventArgs());
        }

        public void Pause()
        {
            tmr.Enabled = false;
        }

        public void KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Up:
                    if(yılan.Yon != Yonler.ASAGI)
                        yılan.Yon = Yonler.YUKARI;
                    break;
                case Keys.Down:
                    if(yılan.Yon != Yonler.YUKARI)
                        yılan.Yon = Yonler.ASAGI;
                    break;
                case Keys.Right:
                    if(yılan.Yon != Yonler.SOL)
                        yılan.Yon = Yonler.SAG;
                    break;
                case Keys.Left:
                    if(yılan.Yon != Yonler.SAG)
                        yılan.Yon = Yonler.SOL;
                    break;
            }
        }
    }
}
