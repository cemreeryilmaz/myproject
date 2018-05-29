using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string okul = "İstanbul Arel Üniversitesi";
            // IndexOf Aramaya Cümlenin Başından Başlar
            int index = okul.IndexOf('s');
            Console.WriteLine("s'nin indexi = " + index);

            index = okul.IndexOf("Arel");
            Console.WriteLine("Arel'in indexi = " + index);

            index = okul.IndexOf('x');
            Console.WriteLine("x'in indexi = " + index);


            // LastIndexOf Aramaya Cümlenin Sonundan Başlar
            index = okul.LastIndexOf('s');
            Console.WriteLine("\ns'nin indexi = " + index);

            index = okul.LastIndexOf("Arel");
            Console.WriteLine("Arel'in indexi = " + index);

            index = okul.LastIndexOf('x');
            Console.WriteLine("x'in indexi = " + index);

            Console.Read();
        }
    }
}
