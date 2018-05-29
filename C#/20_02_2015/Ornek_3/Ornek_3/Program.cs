using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            byte[] dizi = new byte[10];
            rnd.NextBytes(dizi);

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " - ");
            }
            Console.Read();
        }
    }
}
