using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_11
{
    class Program
    {
        static int[] SayıSoldur(int[] dizi)
        {
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 100);
            }
            return dizi;
        }

        static void DiziYazdır(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + "  ");
            }
            Console.WriteLine();
        }

        static int[] K_B_Sırala(int[] dizi)
        {
            int gec;
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int k = i+1; k < dizi.Length; k++)
                {
                    if(dizi[k] < dizi[i])
                    {
                        gec = dizi[i];
                        dizi[i] = dizi[k];
                        dizi[k] = gec;
                    }
                }
            }
            return dizi;
        }

        static int[] B_K_Sırala(int[] dizi)
        {
            int gec;
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int k = i + 1; k < dizi.Length; k++)
                {
                    if (dizi[k] > dizi[i])
                    {
                        gec = dizi[i];
                        dizi[i] = dizi[k];
                        dizi[k] = gec;
                    }
                }
            }
            return dizi;
        }

        static int EnBuyukBul(int[] dizi)
        {
            int enb = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > enb)
                    enb = dizi[i];
            }
            return enb;
        }

        static int EnKucukBul(int[] dizi)
        {
            int enk = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < enk)
                    enk = dizi[i];
            }
            return enk;
        }

        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            dizi = SayıSoldur(dizi);
            DiziYazdır(dizi);
            dizi = K_B_Sırala(dizi);
            DiziYazdır(dizi);
            dizi = B_K_Sırala(dizi);
            DiziYazdır(dizi);

            int enb = EnBuyukBul(dizi);
            int enk = EnKucukBul(dizi);

            Console.WriteLine("dizinin en büyük elemanı = " + enb);
            Console.WriteLine("dizinin en küçük elemanı = " + enk);

            Console.Read();
        }
    }
}
