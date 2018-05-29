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
            Console.Write("Bir sayı giriniz : ");
            //string okunan = Console.ReadLine();
            //int sayı = Convert.ToInt32(okunan);
            int sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı > 50)
            {
                Console.WriteLine("girilen sayı 50'den Büyüktür...");
            }
            Console.WriteLine("sayı = "+sayı);

            Console.Read();
        }
    }
}
