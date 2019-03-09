using ConsoleApp3.Class;
using ConsoleApp3.Class.Controler;
using ConsoleApp3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleApp3
{
    class Program
    {
        private static View vue;

        static void Main(string[] args)
        {
            bool continuer = true;
            string choix;
            IUnityContainer unitycontainer = new UnityContainer();

            Console.WriteLine("---CONFIGURATION---");
            Console.WriteLine("0:Entity ou 1:ADO.NET ?");
            do
            {
                Console.Write(">>> ");
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "0":
                        unitycontainer.RegisterType<IControler, ControlerEntity>();
                        continuer = false;
                        break;
                    case "1":
                        unitycontainer.RegisterType<IControler, Controler>();
                        continuer = false;
                        break;
                }
            } while (continuer);

            unitycontainer.RegisterType<IBDDExec, BDDExecADO>();
            vue = unitycontainer.Resolve<View>();

            vue.menu();
        }
    }
}
