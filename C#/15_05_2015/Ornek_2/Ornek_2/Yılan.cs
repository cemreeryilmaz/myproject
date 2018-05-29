using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_2
{
    public enum Yonler
    {
        SOL, SAG, YUKARI, ASAGI
    }

    class Yılan
    {
        private int screenW, screenH;
        private int enarkaIndex;

        private Point[] govde;
        public Point Kafa { get; set; }
        public Point[] Govde { get { return govde; } set { govde = value; } }
        public Yonler Yon { get; set; }
        public int Puan { get; set; }

        public Yılan(int uzunluk, int w, int h)
        {
            this.Puan = 0;
            this.Yon = Yonler.SOL;
            screenH = h;
            screenW = w;
            this.Govde = new Point[uzunluk];

            this.Kafa = new Point(screenW / 2, screenH / 2);
            this.govde[0] = new Point(Kafa.X + 16, Kafa.Y);

            for (int i = 1; i < govde.Length; i++)
            {
                govde[i] = new Point(govde[i-1].X + 16, govde[i-1].Y);
            }
            enarkaIndex = govde.Length - 1;
        }

        public void BoyUzat(int adet)
        {
            Array.Resize<Point>(ref this.govde, this.govde.Length + adet);
        }

        public void YılanHareket()
        {
            this.govde[enarkaIndex] = this.Kafa;
            enarkaIndex--;
            if (enarkaIndex < 0)
                enarkaIndex = this.govde.Length - 1;

            switch (this.Yon)
            {
                case Yonler.SOL:
                    this.Kafa = new Point(Kafa.X - 16, Kafa.Y);
                    break;
                case Yonler.SAG:
                    this.Kafa = new Point(Kafa.X + 16, Kafa.Y);
                    break;
                case Yonler.YUKARI:
                    this.Kafa = new Point(Kafa.X, Kafa.Y - 16);
                    break;
                case Yonler.ASAGI:
                    this.Kafa = new Point(Kafa.X, Kafa.Y + 16);
                    break;
            }

            if (Kafa.X < 0)
                Kafa = new Point(screenW - 16, Kafa.Y);
            else if(Kafa.X >= screenW)
                Kafa = new Point(0, Kafa.Y);
            else if(Kafa.Y < 0)
                Kafa = new Point(Kafa.X, screenH - 16);
            else if(Kafa.Y >= screenH)
                Kafa = new Point(Kafa.X, 0);
        }

    }
}
