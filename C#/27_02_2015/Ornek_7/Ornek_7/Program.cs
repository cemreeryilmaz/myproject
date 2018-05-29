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
            int sayı;
            string ikilik = "";

            Console.Write("bir sayı giriniz : ");
            sayı = Convert.ToInt32(Console.ReadLine());

            while(sayı > 1)
            {
                int kalan = sayı % 2;
                sayı = (int)Math.Floor((double)sayı / 2);//sayı = (sayı - (sayı%2))/2;
                ikilik = kalan + ikilik;
            }
            ikilik = sayı + ikilik;

            Console.WriteLine("ikilik = " + ikilik);

            Console.Read();
        }
    }
}
