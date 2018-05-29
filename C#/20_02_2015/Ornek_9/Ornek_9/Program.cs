using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int satır = 0; satır < 5; satır++)
            {
                for (int sutun = 0; sutun < 5; sutun++)
                {
                    if (satır >= sutun)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
