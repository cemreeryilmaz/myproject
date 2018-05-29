/**********************************************
 *  
 *      Örnek = 10 elemanlı bir tamsayı dizisi rasgele
 *      sayılarla doldurularak ekranda gösterilecektir.
 *      daha sonra kullanıcıya aşağıdaki işlem tablosu
 *      gösterilecektir.
 *      
 *              İşlem Tablosu:
 *              En Küçük Bul....[1]
 *              En Büyük Bul....[2]
 *              Ara.............[3]
 *              
 *              İşlem Kodu Giriniz : 
 *              
 *      Kullanıcının girmiş olduğu işlem koduna göre
 *      dizi elemanları üzerinde ilgili işlem yapılarak
 *      sonuc ekranda gösterilecektir. 
 *       C# Console'da yazınız...
 * 
 * **********************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_14
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
            Console.WriteLine();

            Console.Write("İşlem Tablosu:\n" +
                          "En Küçük Bul....[1]\n" +
                          "En Büyük Bul....[2]\n" +
                          "Ara.............[3]\n\n" +
                          "İşlem Kodu Giriniz : ");

            int iskod = Convert.ToInt32(Console.ReadLine());

            switch (iskod)
            {
                case 1:
                    //enküçük bul
                    int enk = dizi[0];
                    for (int i = 1; i < dizi.Length; i++)
                    {
                        if (dizi[i] < enk)
                            enk = dizi[i];
                    }
                    Console.WriteLine("En Küçük Eleman = " + enk);

                    break;
                case 2:
                    //enbuyuk bul
                    int enb = dizi[0];
                    for (int i = 1; i < dizi.Length; i++)
                    {
                        if (dizi[i] > enb)
                            enb = dizi[i];
                    }
                    Console.WriteLine("En Büyük Eleman = " + enb);
                    break;
                case 3:
                    Console.Write("Aranacak Sayıyı Giriniz : ");
                    int aranan = Convert.ToInt32(Console.ReadLine());

                    bool durum = false;
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        if(dizi[i] == aranan)
                        {
                            durum = true;
                            Console.WriteLine("aranan sayı dizinin " + i + ". elemanı...");
                            break;
                        }
                    }
                    if (!durum)
                        Console.WriteLine("Aranan sayı dizide mevcut değil...");
                    break;
                default:
                    Console.WriteLine("Yanlış İşlem Kodu Girdiniz...");
                    break;
            }
            Console.Read();
        }
    }
}
