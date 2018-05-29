using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayı giriniz : ");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            /*for (int i = 1; i <= sayı; i++)
            {
                toplam += i;
            }*/

            for (int i = sayı; i > 0; i--)
            {
                toplam += i;
            }
            Console.WriteLine("Toplam = " + toplam);

            Console.Read();
        }
    }
}
