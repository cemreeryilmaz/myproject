using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_3
{
    class Program
    {
        static int EnBuyukYerBul(int[] Dizi)
        {
            int enbYer = 0;
            for (int i = 1; i < Dizi.Length; i++)
            {
                if (Dizi[i] > Dizi[enbYer])
                    enbYer = i;
            }
            return enbYer;
        }

        static int EnBuyukBul(int[] Dizi)
        {
            int enb = Dizi[0];
            for (int i = 1; i < Dizi.Length; i++)
            {
                if (Dizi[i] > enb)
                    enb = Dizi[i];
            }
            return enb;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] Dizi = new int[10];

            for (int i = 0; i < Dizi.Length; i++)
            {
                Dizi[i] = rnd.Next(100);
                Console.Write(Dizi[i] + "  ");
            }
            Console.WriteLine();

            int enbyer = EnBuyukYerBul(Dizi);

            Console.WriteLine("enbuyuk eleman indexi = " + enbyer);
            Console.WriteLine("enbuyuk eleman        = " + Dizi[enbyer]);

            Console.Read();
        }
    }
}
