using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle1 = "Arel";
            string cumle2 = "arel";

            if (cumle1.Equals(cumle2))
                Console.WriteLine("Cümle1 = Cümle2");
            else
                Console.WriteLine("Cümle1 != Cümle2");

            Console.WriteLine("Büyük-Küçük harf uyumu kapama");

            if (cumle1.Equals(cumle2, StringComparison.CurrentCultureIgnoreCase))
                Console.WriteLine("Cümle1 = Cümle2");
            else
                Console.WriteLine("Cümle1 != Cümle2");

            Console.Read();
        }
    }
}
