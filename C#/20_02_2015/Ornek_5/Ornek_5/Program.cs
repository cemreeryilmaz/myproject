using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_5
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
                Console.WriteLine("dizi[" + i + "] = " + dizi[i]);
            }
            Console.Read();
        }
    }
}
