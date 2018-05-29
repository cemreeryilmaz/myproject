using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string okul = "Süleyman Nazif Anadolu Lisesi";

            if (okul.EndsWith("Lisesi"))
                Console.WriteLine("Lisesi ile Bitiyor");

            if (!okul.EndsWith("Üniversitesi"))
                Console.WriteLine("Üniversitesi ile Bitmiyor");
            
            /*******************************/
            //büyük küçük harf duyarlılığı kapatılacak
            if (okul.EndsWith("liSESi", StringComparison.CurrentCultureIgnoreCase))
                Console.WriteLine("liSESi ile Bitiyor");





            if (okul.StartsWith("Süleyman"))
                Console.WriteLine("Lisesi ile Başlıyor");

            if (!okul.StartsWith("Arel"))
                Console.WriteLine("Arel ile Başlamıyor");

            /*******************************/
            //büyük küçük harf duyarlılığı kapatılacak
            if (okul.StartsWith("sÜLEYman", StringComparison.CurrentCultureIgnoreCase))
                Console.WriteLine("sÜLEYman ile Başlıyor");


            Console.Read();


        }
    }
}
