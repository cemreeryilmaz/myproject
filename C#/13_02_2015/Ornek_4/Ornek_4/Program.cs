using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int saniye = 4, dakika = 23, saat = 5; //05:23:04

            string str_saniye = (saniye < 10) ? "0" + saniye : saniye.ToString();
            string str_dakika = (dakika < 10) ? "0" + dakika : dakika.ToString();
            string str_saat = (saat < 10) ? "0" + saat : saat.ToString();

            Console.WriteLine(str_saat + ":" + str_dakika + ":" + str_saniye);

            Console.Read();
        }
    }
}
