using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayı1 = 5.23, sayı2 = 5.50, sayı3 = 5.73;

            Console.WriteLine("Math.Round(" + sayı1 + ") = " + Math.Round(sayı1));
            Console.WriteLine("Math.Round(" + sayı2 + ") = " + Math.Round(sayı2));
            Console.WriteLine("Math.Round(" + sayı3 + ") = " + Math.Round(sayı3));

            Console.WriteLine();

            Console.WriteLine("Math.Floor(" + sayı1 + ") = " + Math.Floor(sayı1));
            Console.WriteLine("Math.Floor(" + sayı2 + ") = " + Math.Floor(sayı2));
            Console.WriteLine("Math.Floor(" + sayı3 + ") = " + Math.Floor(sayı3));

            Console.WriteLine();

            Console.WriteLine("Math.Ceiling(" + sayı1 + ") = " + Math.Ceiling(sayı1));
            Console.WriteLine("Math.Ceiling(" + sayı2 + ") = " + Math.Ceiling(sayı2));
            Console.WriteLine("Math.Ceiling(" + sayı3 + ") = " + Math.Ceiling(sayı3));

            Console.Read();
        }
    }
}
