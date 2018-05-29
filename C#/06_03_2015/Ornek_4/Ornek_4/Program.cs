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
            string okul = "İstanbul Arel Üniversitesi";

            char[] karakterler = okul.ToCharArray();
            char[] karakterler2 = okul.ToCharArray(9, 4);

            foreach (char karakter in karakterler)
            {
                Console.Write(karakter + "  ");
            }
            Console.WriteLine();
            foreach (char karakter in karakterler2)
            {
                Console.Write(karakter + "  ");
            }

            Console.Read();
        }
    }
}
