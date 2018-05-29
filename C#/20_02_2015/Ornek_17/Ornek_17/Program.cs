using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 100);
            }

            int top = 0;
            foreach (int eleman in dizi)
            {
                Console.Write(eleman + "  ");
                top += eleman;
            }
            Console.WriteLine("\nToplamları = " + top);
            Console.Read();
        }
    }
}
