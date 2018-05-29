using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //int rastgele = rnd.Next();
            //int rastgele = rnd.Next(100);
            int rastgele = rnd.Next(-50, 0);

            Console.WriteLine("rasgele Sayı = " + rastgele);

            Console.Read();
        }
    }
}
