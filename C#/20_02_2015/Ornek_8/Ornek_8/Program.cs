using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i = " + i);
                for (int k = 0; k < 10; k++)
                {
                    Console.WriteLine("\tk = " + k);
                }
            }

            Console.Read();
        }
    }
}
