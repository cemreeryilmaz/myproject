using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle1 = "cumle1";
            string cumle2 = "cumle2";

            Console.WriteLine(cumle1 + cumle2);
            Console.WriteLine(String.Concat(cumle1, cumle2));
            
            Console.Read();

        }
    }
}
