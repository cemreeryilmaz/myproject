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
            string cumle = "İstanbul Arel Üniversitesi";
            //LastIndexOf : string içerisinde herhangi bir karakterin veya cumle parcasının
            //başlangıç indexini bulur. aramaya sondan başlar... aradığını bulamazsa geriye
            //-1 döner
            int index = cumle.LastIndexOf("Arel");
            int index1 = cumle.LastIndexOf('r');
            int index2 = cumle.LastIndexOf("BlaBla");
            Console.WriteLine("cumle.LastIndexOf(\"Arel\") = " + index);
            Console.WriteLine("cumle.LastIndexOf('r') = " + index1);
            Console.WriteLine("cumle.LastIndexOf(\"BlaBla\") = " + index2);

            /* Substring : string içerisinden herhangi bir cumle parçasını kopyalayıp
             * almamızı sağlar...
             * */
            string parca = cumle.Substring(9); //9dan başlar sona kadar kopyalar
            string parca1 = cumle.Substring(9, 4); //9dan başlar  karakter kopyalar
            Console.WriteLine("cumle.Substring(9) = " + parca);
            Console.WriteLine("cumle.Substring(9,4) = " + parca1);

            /*Replace : String içerisinde herhangi bir karakteri ya da cumle parçasını
             * yenisi ile değiştirmemizi sağlar...
             * */
            string rep1 = cumle.Replace('i', 'X');
            string rep2 = cumle.Replace("Arel", "ZZZ");
            Console.WriteLine("cumle.Replace('i', 'X') = " + rep1);
            Console.WriteLine("cumle.Replace(\"Arel\", \"ZZZ\") = " + rep2);

            Console.Read();
        }
    }
}
