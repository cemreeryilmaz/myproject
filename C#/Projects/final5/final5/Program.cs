using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final5
{
    class diziIslem
    {
        public void listele(int[] Dizi)
        {
            foreach (var eleman in Dizi)
            {
                Console.Write(eleman + " ");
            }
            Console.WriteLine();
        }
        public int[] sayiUret(int elemanSayisi)
        {
            Random rnd = new Random();
            int[] Dizi = new int[elemanSayisi];
            for (int i = 0; i < Dizi.Length; i++)
            {
                Dizi[i] = rnd.Next(100);   
            }
            return Dizi;
        }
        public int ara(int[] Dizi, int aranan)
        {
            for (int i = 0; i < Dizi.Length; i++)
            {
                if (Dizi[i] == aranan)
                {
                    return i;
                }               
            }
            return -1;
        }
        public void yerDegistir(ref int[] Dizi, int yer1, int yer2)
        {
            int gec = Dizi[yer1];
            Dizi[yer1] = Dizi[yer2];
            Dizi[yer2] = gec;
        }
        public int enBuyukYer(int[] Dizi)
        {
            int enb = 0;
            for (int i = 0; i < Dizi.Length; i++)
            {
                if (Dizi[i] > enb)
                {
                    enb = Dizi[i];
                }
            }
            return enb;
        }
        public int enBuyukIndex(int[] Dizi)
        {
            int enbYer = 0;
            for (int i = 1; i < Dizi.Length; i++)
            {
                if (Dizi[i] > Dizi[enbYer])
                    enbYer = i;
            }
            return enbYer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            diziIslem diziIslem = new diziIslem();
            int[] Dizi = diziIslem.sayiUret(10);
            int islem;
            do{
                Console.Write("\n"+
                              "İslem Tablosu..........:\n"+
                              "Listele................[1]\n"+
                              "Dizi Yenile............[2]\n"+
                              "Ara....................[3]\n"+
                              "Yer Değiştir...........[4]\n"+
                              "En Büyük Dizi..........[5]\n"+
                              "En Büyük Dizi İndex'i..[6]\n"+
                              "Çıkış..................[7]\n"+
                              "İşlem Kodu Giriniz.....:");
                islem = Convert.ToInt32(Console.Read());

                switch (islem)
                {
                    case 1:
                        diziIslem.listele(Dizi);
                        break;
                    case 2:
                        Dizi = diziIslem.sayiUret(Dizi.Length);
                        Console.WriteLine("Sayilar Yenilendi.");
                        break;
                    case 3:
                        Console.Write("Aranacak Sayıyı Giriniz :");
                        int aranan = Convert.ToInt32(Console.ReadLine());
                        int yer = diziIslem.ara(Dizi, aranan);
                        if (yer == -1)
                            Console.WriteLine("Aranan Sayı Bulanamadı.");
                        else                            
                            Console.WriteLine("Aranan Sayının İndex'i :"+yer);
                        break;
                    case 4:
                        Console.WriteLine("Yer Değişicek 1.Sayının İndex'i :");
                        int yer1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Yer Değiştirilicek 2.Sayının İndex'i :");
                        int yer2 = Convert.ToInt32(Console.ReadLine());
                        diziIslem.yerDegistir(ref Dizi, yer1, yer2);
                        Console.WriteLine("Yerler Değiştirildi.");
                        break;
                    case 5:
                        int enbyer = diziIslem.enBuyukYer(Dizi);
                        Console.WriteLine("En Büyük Eleman :" + enbyer);
                        break;
                    case 6:
                        int enbIndex = diziIslem.enBuyukIndex(Dizi);
                        Console.WriteLine("En Büyük Elemanın İndex'i :" + enbIndex);
                        break;
                    case 7:
                        Console.WriteLine("Çıkılıyor...");
                        break;
                    default:
                        Console.WriteLine("Yanlış İşlem Kodu Girdiniz!!!");
                        break;
                }
            } while (islem != 7);
            Console.ReadLine();
        }
    }
}
