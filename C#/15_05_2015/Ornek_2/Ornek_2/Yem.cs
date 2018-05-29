using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_2
{
    class Yem
    {
        public Point Yer { get; set; }
        public int Puan { get; set; }

        public Yem(int puan, int w, int h)
        {
            this.Puan = puan;
            Yerleştir(w, h);
        }

        public Yem(int puan, Point p)
        {
            this.Puan = puan;
            this.Yer = p;
        }

        public void Yerleştir(int w, int h)
        {
            Random rnd = new Random();
            int x = rnd.Next(w);
            x -= x%16;
            int y = rnd.Next(h);
            y -=y%16;

            this.Yer = new Point(x, y);
        }
    }
}
