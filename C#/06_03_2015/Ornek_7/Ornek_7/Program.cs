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
            string cumle1 = "";
            string cumle2 = null;
            string cumle3 = String.Empty;
            string cumle4 = "    ";

            if (String.IsNullOrEmpty(cumle1))
                Console.WriteLine("cümle1 boş veya null");

            if (String.IsNullOrEmpty(cumle2))
                Console.WriteLine("cümle2 boş veya null");

            if (String.IsNullOrEmpty(cumle3))
                Console.WriteLine("cümle3 boş veya null");

            if (String.IsNullOrEmpty(cumle4))
                Console.WriteLine("cümle4 boş veya null");
            else
                Console.WriteLine("cümle4 boş veya null değil...");

            /****************************************/
            Console.WriteLine("******************");

            if (String.IsNullOrWhiteSpace(cumle1))
                Console.WriteLine("cümle1 boş veya null");

            if (String.IsNullOrWhiteSpace(cumle2))
                Console.WriteLine("cümle2 boş veya null");

            if (String.IsNullOrWhiteSpace(cumle3))
                Console.WriteLine("cümle3 boş veya null");

            if (String.IsNullOrWhiteSpace(cumle4))
                Console.WriteLine("cümle4 boş veya null");
            else
                Console.WriteLine("cümle4 boş veya null değil...");

            Console.Read();
        }
    }
}
