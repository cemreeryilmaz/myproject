using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string okul = "Arel";

            Console.WriteLine(okul.PadLeft(10));
            Console.WriteLine(okul.PadLeft(10, '*'));

            Console.Write(okul.PadRight(10));
            Console.WriteLine("boşluktan sonrası");
            Console.WriteLine(okul.PadRight(10, '*'));

            Console.Read();
        }
    }
}
