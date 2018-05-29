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
            int a = 15, b = 40;

            Console.WriteLine("Büyük Olan = " + Math.Max(a, b));
            Console.WriteLine("Küçük Olan = " + Math.Min(a, b));

            Console.Read();
        }
    }
}
