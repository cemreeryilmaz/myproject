using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_12
{
    class Program
    {
        static void YerDeğiştir(ref int x, ref int y)
        {
            int gec = x;
            x = y;
            y = gec;
        }

        static void Main(string[] args)
        {
            int a = 12, b = 15;
            Console.WriteLine("a = " + a + ", b = " + b);
            YerDeğiştir(ref a, ref b);
            Console.WriteLine("a = " + a + ", b = " + b);

            Console.Read();
        }
    }
}
