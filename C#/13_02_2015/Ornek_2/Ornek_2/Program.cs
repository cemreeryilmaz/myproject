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
            string str = "65";
            char kar = 'A';
            byte sayı = 65;

            int str_integer = Convert.ToInt32(str);

            Console.WriteLine(sayı + str_integer);

            Console.Read();
        }
    }
}
