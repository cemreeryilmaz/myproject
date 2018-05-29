using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir rakam giriniz : ");
            int rakam = Convert.ToInt32(Console.ReadLine());

            if (rakam == 0)
                Console.WriteLine("sıfır");
            else if (rakam == 1)
                Console.WriteLine("bir");
            else if (rakam == 2)
                Console.WriteLine("iki");
            else if (rakam == 3)
                Console.WriteLine("üç");
            else if (rakam == 4)
                Console.WriteLine("dört");
            else if (rakam == 5)
                Console.WriteLine("beş");
            else if (rakam == 6)
                Console.WriteLine("altı");
            else if (rakam == 7)
                Console.WriteLine("yedi");
            else if (rakam == 8)
                Console.WriteLine("sekiz");
            else if (rakam == 9)
                Console.WriteLine("dokuz");
            else
                Console.WriteLine("Rakam girmediniz...");

            Console.Read();
        }
    }
}
