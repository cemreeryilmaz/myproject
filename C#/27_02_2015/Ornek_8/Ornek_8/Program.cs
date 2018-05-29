using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //İkinci YOL
            int sayı;
            string onaltılık = "";

            Console.Write("bir sayı giriniz : ");
            sayı = Convert.ToInt32(Console.ReadLine());

            while (sayı > 15)
            {
                int kalan = sayı % 16;
                sayı = (int)Math.Floor((double)sayı / 16);//(sayı - kalan) / 16;

                if (kalan < 10)
                    onaltılık = kalan + onaltılık;
                else
                    onaltılık = Convert.ToChar(kalan + 55) + onaltılık;
            }
            if (sayı < 10)
                onaltılık = sayı + onaltılık;
            else
                onaltılık = Convert.ToChar(sayı + 55) + onaltılık;

            Console.WriteLine("onaltılık = " + onaltılık);

            Console.Read();

            /* Birinci YOL
            int sayı;
            string onaltılık = "";

            Console.Write("bir sayı giriniz : ");
            sayı = Convert.ToInt32(Console.ReadLine());

            while(sayı > 15)
            {
                int kalan = sayı % 16;
                sayı = (int)Math.Floor((double)sayı / 16);//(sayı - kalan) / 16;

                if(kalan < 10)
                    onaltılık = kalan + onaltılık;
                else if(kalan == 10)
                    onaltılık = "A" + onaltılık;
                else if (kalan == 11)
                    onaltılık = "B" + onaltılık;
                else if (kalan == 12)
                    onaltılık = "C" + onaltılık;
                else if (kalan == 13)
                    onaltılık = "D" + onaltılık;
                else if (kalan == 14)
                    onaltılık = "E" + onaltılık;
                else if (kalan == 15)
                    onaltılık = "F" + onaltılık;
            }
            if (sayı < 10)
                onaltılık = sayı + onaltılık;
            else if (sayı == 10)
                onaltılık = "A" + onaltılık;
            else if (sayı == 11)
                onaltılık = "B" + onaltılık;
            else if (sayı == 12)
                onaltılık = "C" + onaltılık;
            else if (sayı == 13)
                onaltılık = "D" + onaltılık;
            else if (sayı == 14)
                onaltılık = "E" + onaltılık;
            else if (sayı == 15)
                onaltılık = "F" + onaltılık;

            Console.WriteLine("onaltılık = " + onaltılık);

            Console.Read();
             * */
        }
    }
}
