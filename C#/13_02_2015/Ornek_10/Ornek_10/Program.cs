using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_10
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

            //string sonuc = (iskod == 1) ? "Toplam = " + (s1 + s2) : (iskod == 2) ? "Fark = " + (s1 - s2) : (iskod == 3) ? "Bolum = " + (s1 / s2) : (iskod == 4) ? "Çarpım = " + (s1 * s2) : "Yanlış İşlem Kodu Girdiniz";
            //Console.WriteLine(sonuc);
            
            Console.WriteLine((iskod == 1) ? "Toplam = " + (s1 + s2) : (iskod == 2) ? "Fark = " + (s1 - s2) : (iskod == 3) ? "Bolum = " + (s1 / s2) : (iskod == 4) ? "Çarpım = " + (s1 * s2) : "Yanlış İşlem Kodu Girdiniz");
            
            Console.Read();
        }
    }
}
