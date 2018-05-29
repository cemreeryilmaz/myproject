using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int onluk = 0;
            string onaltılık = "";

            Console.Write("onaltılık sayı : ");
            onaltılık = Console.ReadLine();//.ToUpper();
            onaltılık = onaltılık.ToUpper();

            for (int i = 0; i < onaltılık.Length; i++)
            {
                int asciCode = Convert.ToInt32(onaltılık[onaltılık.Length - i - 1]);
                if (asciCode >= 65 && asciCode <= 70)
                    onluk += (asciCode - 55) * (int)Math.Pow(16, i);
                else
                    onluk += Convert.ToInt32(onaltılık[onaltılık.Length - i - 1].ToString()) * (int)Math.Pow(16, i);
            }
            Console.WriteLine("onluk = " + onluk);

            Console.Read();
        }
    }
}
