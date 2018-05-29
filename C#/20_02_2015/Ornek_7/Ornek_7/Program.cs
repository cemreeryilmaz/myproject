using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int enk_yer = 0, enb_yer = 0;
            Random rnd = new Random();
            int[] dizi = new int[10];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 100);
                Console.Write(dizi[i] + "  ");
            }
            Console.WriteLine();

            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < dizi[enk_yer])
                    enk_yer = i;

                if (dizi[i] > dizi[enb_yer])
                    enb_yer = i;
            }

            Console.WriteLine("en büyük eleman yeri   = " + enb_yer);
            Console.WriteLine("en büyük eleman değeri = " + dizi[enb_yer]);
            Console.WriteLine();
            Console.WriteLine("en küçük eleman yeri   = " + enk_yer);
            Console.WriteLine("en küçük eleman değeri = " + dizi[enk_yer]);

            Console.Read();
        }
    }
}
