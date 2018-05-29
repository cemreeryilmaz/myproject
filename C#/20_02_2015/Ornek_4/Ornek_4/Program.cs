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
            Random rnd = new Random();
            double rasgele = rnd.NextDouble();

            Console.WriteLine("rasgele Sayı = " + rasgele);

            Console.Read();
        }
    }
}
