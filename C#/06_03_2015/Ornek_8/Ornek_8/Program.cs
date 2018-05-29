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
            double sayı = 18.125698;
            Console.WriteLine("Sayı = " + sayı);

            Console.WriteLine(String.Format("{0:c}", sayı));

            Console.Read();
        }
    }
}
