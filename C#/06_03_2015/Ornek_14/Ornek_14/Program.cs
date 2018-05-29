using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_14
{
    class Program
    {
        static int Topla(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + Topla(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("n sayısını giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = Topla(n);

            Console.WriteLine("1'den " + n + "'e kadar sayıların toplamı = " + toplam);

            Console.Read();
        }
    }
}
