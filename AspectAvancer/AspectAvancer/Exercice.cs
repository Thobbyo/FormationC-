using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectAvancer
{
    public class Exercice
    {
        [System.Obsolete("use NewMethod", true)]
        public static void Test()
        {
            Console.WriteLine("test");
        }

        public static void Welcome()
        {
            Console.WriteLine("Bienvenue");
        }

        public static void Add(double d1, double d2)
        {
            double d3 = d1 + d2;
            Console.WriteLine(d3);
        }

    }
}
