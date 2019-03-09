using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Controllers;
using Business;
using Business.Contracts;
using Repository;
using Repository.Contracts;
using Unity;

namespace ExerciceDesignePaterne
{
    class Program
    {
        private static EmployeControler employeController;

        static void Main(string[] args)
        {
            IUnityContainer unitycontainer = new UnityContainer();
            unitycontainer.RegisterType<EmployeControler, EmployeControler>();
            unitycontainer.RegisterType<IBuisinessEmploye, BuisnessEmploye>();
            unitycontainer.RegisterType<IEmployeRepository, LocalStorage>();

            employeController = unitycontainer.Resolve<EmployeControler>();

            bool continuer = true;
            do
            {
                Console.WriteLine("Qu'est ce que vous souhaiter faire ?");
                Console.WriteLine("add pour ajouter un employé.");
                Console.WriteLine("disp pour afficher un employé.");
                Console.WriteLine("dispAll pour affiher tout les employé.");
                Console.WriteLine("q pour quiter.");
                Console.Write(">>> ");
                string choix = Console.ReadLine();
                switch (choix)
                {
                    case "add":
                        addCommande();
                        break;
                    case "disp":
                        dispCommande();
                        break;
                    case "dispAll":
                        dispAllCommande();
                        break;
                    case "q":
                        continuer = false;
                        break;
                    default:
                        Console.WriteLine("Vous avez mal rentrer votre commande");
                        break;
                }
            } while (continuer);
        }

        public static void addCommande()
        {
            Console.WriteLine("Nom de l'Employé :");
            string nom = Console.ReadLine();
            Console.WriteLine("Prénom de l'Employé :");
            string prenom = Console.ReadLine();
            Console.WriteLine("Salaire de l'Employé :");
            string salaire = Console.ReadLine();
            
            Console.WriteLine(employeController.addUser(nom, prenom, salaire));
        }

        public static void dispCommande()
        {
            Console.WriteLine("Numéro de l'Employé :");
            string id = Console.ReadLine();

            Console.WriteLine(employeController.dispUser(id));
        }

        public static void dispAllCommande()
        {
            Console.WriteLine(employeController.dispAllUser());
        }
    }
}
