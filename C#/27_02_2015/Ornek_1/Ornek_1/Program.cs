using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = -12;
            int sayı2 = 15;

            int sonuc = Math.Abs(sayı1);
            Console.WriteLine("Abs(" + sayı1 + ") = " + sonuc);

            sonuc = Math.Abs(sayı2);
            Console.WriteLine("Abs(" + sayı2 + ") = " + sonuc);


            Console.Read();
        }
    }
}
