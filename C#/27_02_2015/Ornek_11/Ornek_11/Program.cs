using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string okul = "İstanbul Arel Üniversitesi";

            string buyuk_okul = okul.ToUpper();
            Console.WriteLine(buyuk_okul);

            string kucuk_okul = okul.ToLower();
            Console.WriteLine(kucuk_okul);

            Console.Read();
        }
    }
}
