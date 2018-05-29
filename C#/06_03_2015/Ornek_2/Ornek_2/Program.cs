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
            string cumle = "İstanbul Üniversitesi";
            
            string bizim_okul = cumle.Insert(9, "Arel ");

            Console.WriteLine(bizim_okul);
            Console.WriteLine("cumle karakter sayısı = " + bizim_okul.Length);
            
            Console.Read();
        }
    }
}
