using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_9
{
    class Program
    {
        enum İşlemler
        {
            TOPLA = 1,
            ÇIKAR,
            BOL,
            ÇARP
        }

        static void Main(string[] args)
        {
            Console.Write("İşlem Tablosu:\n" +
                          "Toplama için.....[1]\n" +
                          "Çıkarma için.....[2]\n" +
                          "Bölme için.......[3]\n" +
                          "Çarpma için......[4]\n\n" +
                          "İşlem Kodu Giriniz : ");
            İşlemler iskod = (İşlemler)Convert.ToInt32(Console.ReadLine());

            Console.Write("1. sayıyı giriniz : ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz : ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            if (iskod == İşlemler.TOPLA)
                Console.WriteLine("Toplam = " + (s1 + s2));
            else if (iskod == İşlemler.ÇIKAR)
                Console.WriteLine("Fark = " + (s1 - s2));
            else if (iskod == İşlemler.BOL)
                Console.WriteLine("Bölüm = " + (s1 / s2));
            else if (iskod == İşlemler.ÇARP)
                Console.WriteLine("Çarpım = " + (s1 * s2));
            else
                Console.WriteLine("Yanlış İşlem Kodu girdiniz...");

            Console.Read();
        }
    }
}
