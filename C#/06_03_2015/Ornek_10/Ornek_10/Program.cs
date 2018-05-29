using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_10
{
    class Program
    {
        static int[] SayıDoldur(int[] dizi)
        {
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 100);
            }
            return dizi;
        }

        static void DiziYazdır(int[] dizi)
        {
            foreach (int eleman in dizi)
            {
                Console.Write(eleman + "  ");
            }
            Console.WriteLine();
        }

        static int DizideAra(int[] dizi, int aranan)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == aranan)
                    return i;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            //int[] dizi = SayıDoldur(new int[10]);
            int[] dizi = new int[10];
            dizi = SayıDoldur(dizi);
            DiziYazdır(dizi);

            Console.Write("aranacak sayı : ");
            int aranacak = Convert.ToInt32(Console.ReadLine());
            int yer = DizideAra(dizi, aranacak);

            if (yer == -1)
                Console.WriteLine("Aranan dizide yok!!!");
            else
                Console.WriteLine("aranan eleman indexi = " + yer);

            Console.Read();
        }
    }
}
