using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type[] diziAdı = new type[boyut];
            int[] dizi = new int[10];

            dizi[0] = 10;
            dizi[1] = 12;
            //...
            dizi[9] = 15;

            dizi[2] = dizi[1] + dizi[9];

            /**********************************************************/
            int[] dizi1 = { 12, 18, 25, 35, 23 };
            int[] dizi2 = new int[5] { 12, 18, 25, 35, 23 };

        }
    }
}
