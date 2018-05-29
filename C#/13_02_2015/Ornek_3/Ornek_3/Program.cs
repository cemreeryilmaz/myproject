using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 35;
            string str = "25a";//formatException
            //string str = "256";//overFlowException
            //string str = "255" //olması gereken...

            byte sayı = Convert.ToByte(str);

            byte sayı2 = (byte)a;
            byte sayı3 = byte.Parse(str);

            string str1 = sayı.ToString();

            Console.WriteLine("istanbul");

            Console.Read();
        }
    }
}
