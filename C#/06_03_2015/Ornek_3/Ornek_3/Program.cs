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
            string okul = "İstanbul Arel Üniversitesi";

            Console.WriteLine(okul.Substring(9));
            Console.WriteLine(okul.Substring(9, 4));
            Console.WriteLine(okul.Substring(14, 10));

            Console.Read();
        }
    }
}
