/**********************************************
 *  
 *      Örnek = 10 elemanlı bir tamsayı dizisi rasgele
 *      sayılarla doldurularak ekranda gösterilecektir.
 *      daha sonra kullanıcıya aşağıdaki işlem tablosu
 *      gösterilecektir.
 *      
 *              İşlem Tablosu:
 *              Büyükten Küçüğe Sırala....[1]
 *              Küçükten Büyüğe Sırala....[2]
 *              
 *              İşlem Kodu Giriniz : 
 *              
 *      Kullanıcının girmiş olduğu işlem koduna göre
 *      dizi elemanları sıralanarak sonuc ekranda
 *      gösterilecektir. C# Console'da yazınız...
 * 
 * **********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_13
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

            Console.Write("\nİşlem Tablosu:\n" +
                          "Küçükten Büyüğe Sırala...[1]\n" +
                          "Büyükten Küçüğe Sırala...[2]\n\n" +
                          "İşlem Kodu Giriniz : ");
            int iskod = Convert.ToInt32(Console.ReadLine());
            int gec;

            if(iskod == 1)
            {
                for (int i = 0; i < dizi.Length -1; i++)
                {
                    for (int k = i+1; k < dizi.Length; k++)
                    {
                        if(dizi[k] < dizi[i])
                        {
                            gec = dizi[i];
                            dizi[i] = dizi[k];
                            dizi[k] = gec;
                        }
                    }
                }

                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.Write(dizi[i] + "  ");
                }
            }
            else if(iskod == 2)
            {
                for (int i = 0; i < dizi.Length - 1; i++)
                {
                    for (int k = i + 1; k < dizi.Length; k++)
                    {
                        if (dizi[k] > dizi[i])
                        {
                            gec = dizi[i];
                            dizi[i] = dizi[k];
                            dizi[k] = gec;
                        }
                    }
                }

                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.Write(dizi[i] + "  ");
                }
            }
            else
            {
                Console.WriteLine("Yanlış İşlem Kodu Girdiniz...");
            }

            Console.Read();

        }
    }
}
