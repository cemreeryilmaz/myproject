using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = (Math.PI / 180) * 60;
            Console.WriteLine("Cos(60) = " + Math.Cos(rad));

            double acı = Math.Acos(0.5);
            acı = (180 / Math.PI) * acı;
            Console.WriteLine("ACos(0,5) = " + acı);

            Console.Read();
        }
    }
}
