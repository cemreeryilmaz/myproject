using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayı giriniz : ");
            int sayı = Convert.ToInt32(Console.ReadLine());
            if (sayı > 50)
            {
                Console.WriteLine("girilen sayı 50'den büyük");
            }
            else
            {
                Console.WriteLine("girilen sayı 50'den büyük değil");
            }

            Console.WriteLine("sayı = " + sayı);

            Console.Read();
        }
    }
}
