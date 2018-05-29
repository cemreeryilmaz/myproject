using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int onluk = 0;
            string ikilik = "";

            Console.Write("ikilik tabanda sayı giriniz : ");
            ikilik = Console.ReadLine();

            for (int i = 0; i < ikilik.Length; i++)
            {
                onluk += Convert.ToInt32(ikilik[ikilik.Length - i - 1].ToString()) * (int)Math.Pow(2,i);
            }

            Console.WriteLine("onluk karşılık = " + onluk);

            Console.Read();
        }
    }
}
