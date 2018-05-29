using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_4
{
    class DiziIslem
    {
        public void Listele(int[] Dizi)
        {
            foreach (int eleman in Dizi)
            {
                Console.Write(eleman+"  ");
            }
            Console.WriteLine();
        }

        public int[] SayıUret(int elemanSayı)
        {
            Random rnd = new Random();
            int[] dizi = new int[elemanSayı];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(100);
            }
            return dizi;
        }

        public int Ara(int[] dizi, int aranan)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == aranan)
                    return i;
            }
            return -1;
        }

        public void yerDegistir(ref int[] dizi, int yer1, int yer2)
        {
            int gec = dizi[yer1];
            dizi[yer1] = dizi[yer2];
            dizi[yer2] = gec;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DiziIslem diziIslem = new DiziIslem();
            int[] Dizi = diziIslem.SayıUret(10);
            int iskod;
            do
            {
                Console.Write("İşlem Tablosu:\n" +
                              "Listele...........[1]\n" +
                              "Sayıları Yenile...[2]\n" +
                              "Ara...............[3]\n" +
                              "Yer Değiştir......[4]\n" +
                              "Çıkış.............[5]\n\n" +
                              "İşlem Kodu Giriniz : ");
                iskod = Convert.ToInt32(Console.ReadLine());

                switch(iskod)
                {
                    case 1:
                        diziIslem.Listele(Dizi);
                        break;
                    case 2:
                        Dizi = diziIslem.SayıUret(Dizi.Length);
                        Console.WriteLine("Sayılar Yenilendi...");
                        break;
                    case 3:
                        Console.Write("Aranacak Sayıyı Giriniz : ");
                        int aranan = Convert.ToInt32(Console.ReadLine());
                        int yer = diziIslem.Ara(Dizi, aranan);

                        if (yer == -1)
                            Console.WriteLine("aranan sayı bulunamadı...");
                        else
                            Console.WriteLine("aranan sayı indexi = " + yer);
                        break;
                    case 4:
                        Console.Write("1. eleman indexi : ");
                        int yer1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("2. eleman indexi : ");
                        int yer2 = Convert.ToInt32(Console.ReadLine());

                        diziIslem.yerDegistir(ref Dizi, yer1, yer2);
                        Console.WriteLine("Yerler Değiştirildi...");

                        break;
                    case 5:
                        Console.WriteLine("Çıkılıyor...");
                        break;
                    default:
                        Console.WriteLine("Yanlış İşlem Kodu Girdiniz!!!");
                        break;
                }

            } while (iskod != 5);
            Console.Read();
        }
    }
}
