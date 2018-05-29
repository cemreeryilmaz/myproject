using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı=0, top=0;
            do
            {
                Console.Write("bir sayı giriniz : ");
                sayı = Convert.ToInt32(Console.ReadLine());
                top += sayı;
                Console.WriteLine("toplam = " + top);
            } while (sayı != 0);

            Console.Read();
        }
    }
}
