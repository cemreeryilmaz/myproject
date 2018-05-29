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
            Random rnd = new Random();
            int[] dizi = new int[10];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 100);
                Console.Write(dizi[i] + "  ");
            }

            Console.Write("\naranacak sayıyı giriniz : ");
            int aranan = Convert.ToInt32(Console.ReadLine());

            bool durum = false;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == aranan)
                {
                    durum = true;
                    Console.WriteLine("aranan dizinin "+i+". elemanı");
                    break;
                }
            }

            if (!durum)
                Console.WriteLine("Aranan Bulunamadı!");

            Console.Read();
        }
    }
}
