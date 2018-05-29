using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail = "  email@email.com   ";
            Console.Write(mail.TrimStart());
            Console.WriteLine("boşluktan sonra");
            Console.WriteLine(mail.TrimEnd());
            Console.Write(mail.Trim());
            Console.WriteLine("_boşluk silindi");

            Console.Read();
        }
    }
}
