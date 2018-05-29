using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] dizi = new int[10];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 100);
                Console.Write(dizi[i] + "  ");
            }
            Console.WriteLine();

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

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + "  ");
            }
            Console.Read();
        }
    }
}
