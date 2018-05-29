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
            for (int satır = 0; satır < 5; satır++)
            {
                for (int sutun = 4; sutun >=0; sutun--)
                {
                    if (sutun <= satır)
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
