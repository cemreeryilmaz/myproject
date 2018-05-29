using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string okul = "İstanbul Arel Üniversitesi";

            Console.WriteLine(okul.Replace('i', 'x'));
            Console.WriteLine(okul.Replace("si", "DO"));

            Console.WriteLine(okul.Remove(10));
            Console.WriteLine(okul.Remove(10, 2));

            Console.Read();
        }
    }
}
