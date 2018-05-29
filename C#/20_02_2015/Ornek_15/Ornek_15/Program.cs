using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı 0(sıfır) girene kadar girilen sayıları
            //toplayan ve ekranda gösteren program...

            Console.Write("bir sayı giriniz : ");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int top = 0;
            while(sayı != 0)
            {
                top += sayı;
                Console.WriteLine("Toplam = " + top);

                Console.Write("bir sayı giriniz : ");
                sayı = Convert.ToInt32(Console.ReadLine());
            }

            Console.Read();
        }
    }
}
