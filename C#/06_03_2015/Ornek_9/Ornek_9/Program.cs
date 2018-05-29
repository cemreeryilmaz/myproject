using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_9
{
    class Program
    {
        //erişimbelirleyici static geridönüşdeğertipi fonksiyonAdı(alacağı parametre tanımları)
        //{
        //  ......
        //  return değer;
        //}

        static void MesajYaz(string mesaj)
        {
            Console.Write(mesaj);
        }

        static int Topla(int s1, int s2)
        {
            int toplam = s1 + s2;
            return toplam;
        }

        static void Main(string[] args)
        {
            int s1, s2, sonuc;
            MesajYaz("1. sayıyı giriniz : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            MesajYaz("2. sayıyı giriniz : ");
            s2 = Convert.ToInt32(Console.ReadLine());

            sonuc = Topla(s1, s2);

            Console.WriteLine("Toplam = " + sonuc);

            Console.Read();
        }
    }
}
