using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı, adet = 0, top = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ". sayıyı giriniz : ");
                sayı = Convert.ToInt32(Console.ReadLine());
                if(sayı % 2 == 0)
                {
                    adet++;
                    top += sayı;
                }
            }

            int ort = top / adet;
            Console.WriteLine("Ortalama = " + ort);

            Console.Read();
        }
    }
}
