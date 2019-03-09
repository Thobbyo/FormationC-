using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectAvancer
{
    class Program
    {
        static void Main(string[] args)
        {
            // exo57();
            // exo58();
            // exo59();
            FileRR.WritInBin();
            Console.WriteLine(FileRR.ReadInBin());
            Console.ReadLine();
        }

        static void DoSomething(Action<string> callback)
        {
            callback("HAAAAAAAAAA !!!");
        }

        static void exo59()
        {
            Action<string> callback = delegate (string str) { Console.WriteLine(str); };

            DoSomething(callback);

            DoSomething(vare => Console.WriteLine(vare));
        }

        static void exo58()
        {
            Action delegate1;
            Action<double, double> delegate2;

            delegate1 = Exercice.Welcome;
            delegate2 = Exercice.Add;

            delegate1();
            delegate2(45, 20);
        }

        static void exo57()
        {
            MyPair<int, string> paire = new MyPair<int, string>(11, "JOLIE");
            Console.WriteLine(paire);
        }
    }
}
