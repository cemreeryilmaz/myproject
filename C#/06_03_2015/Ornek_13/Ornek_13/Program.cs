using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_13
{
    class Program
    {
        static void DiziDoldur(ref int[] dizi)
        {
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 100);
            }
        }

        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            DiziDoldur(ref dizi);

            foreach (int eleman in dizi)
            {
                Console.Write(eleman + "  ");
            }

            Console.Read();
        }
    }
}
