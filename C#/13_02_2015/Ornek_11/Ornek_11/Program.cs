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
            Console.Write("İşlem Tablosu:\n" +
                         "Toplama için.....[1]\n" +
                         "Çıkarma için.....[2]\n" +
                         "Bölme için.......[3]\n" +
                         "Çarpma için......[4]\n\n" +
                         "İşlem Kodu Giriniz : ");
            int iskod = Convert.ToInt32(Console.ReadLine());

            Console.Write("1. sayıyı giriniz : ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz : ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            /*if (iskod == 1)
                Console.WriteLine("Toplam = " + (s1 + s2));
            else if (iskod == 2)
                Console.WriteLine("Fark = " + (s1 - s2));
            else if (iskod == 3)
                Console.WriteLine("Bölüm = " + (s1 / s2));
            else if (iskod == 4)
                Console.WriteLine("Çarpım = " + (s1 * s2));
            else
                Console.WriteLine("Yanlış İşlem Kodu girdiniz...");
            */

            switch(iskod)
            {
                case 1:
                    Console.WriteLine("Toplam = " + (s1 + s2));
                    break;
                case 2:
                    Console.WriteLine("Fark = " + (s1 - s2));
                    break;
                case 3:
                    Console.WriteLine("Bölüm = " + (s1 / s2));
                    break;
                case 4:
                    Console.WriteLine("Çarpım = " + (s1 * s2));
                    break;
                default:
                    Console.WriteLine("Yanlış İşlem Kodu girdiniz...");
                    break;
            }
            Console.Read();
        }
    }
}
