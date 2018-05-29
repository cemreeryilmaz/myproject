using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sarkı = "Karadır kaşların işletim sistemi yazdırır.\n" +
                           "Bu dert beni domain domain gezdirir.\n" +
                           "Bill Gates gelse bad sectorum azdırır,\n" +
                           "Diskimi formatlamaya yar kendi gelsin...";

            char[] ayraclar = { ' ','.', ',', '\n' };
            string[] kelimeler = sarkı.Split(ayraclar);

            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

            Console.WriteLine("******************");

            string[] kelimeler2 = sarkı.Split(ayraclar, StringSplitOptions.RemoveEmptyEntries);
            foreach (string kelime in kelimeler2)
            {
                Console.WriteLine(kelime);
            }

            Console.Read();

        }
    }
}
