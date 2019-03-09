using ConsoleApp3.Interface;
using ConsoleApp3.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleApp3
{
    public class View
    {
        IControler Controller { get; }
        public View(IControler controller)
        {
            Controller = controller;
        }

        public void menu()
        {
            bool continuer = true;
            string choix;
            IUnityContainer unitycontainer = new UnityContainer();

            Console.WriteLine("---APPLICATION DE CRUD---");

            do
            {
                Console.WriteLine("Qu'est ce que vous souhaité faire ?");
                Console.Write(">>> ");
                choix = Console.ReadLine();
                switch (choix.ToLower())
                {
                    case "help":
                        commandeHelp(0);
                        break;
                    case "c":
                    case "client":
                        menuCL('c');
                        break;
                    case "l":
                    case "location":
                        menuCL('l');
                        break;
                    case "q":
                    case "quit":
                        continuer = false;
                        break;
                }
            } while (continuer);
        }

        private void menuCL(char selectTable)
        {
            bool continuer = true;
            string choix;
            IUnityContainer unitycontainer = new UnityContainer();

            do
            {
                if (selectTable == 'c')
                {
                    Console.WriteLine("Qu'est ce que vous souhaité faire sur la table client ?");
                }
                else
                {
                    Console.WriteLine("Qu'est ce que vous souhaité faire sur la table location ?");
                }
                Console.Write(">>> ");
                choix = Console.ReadLine();
                switch (choix.ToLower())
                {
                    case "help":
                        if(selectTable == 'c')
                        {
                            commandeHelp(1);
                        }
                        else
                        {
                            commandeHelp(2);
                        }
                        break;
                    case "add":
                        if (selectTable == 'c')
                        {
                            commandeAddClient();
                        }
                        else
                        {
                            commandeAddLocation();
                        }
                        break;
                    case "update":
                        if (selectTable == 'c')
                        {
                            commandeUpdateClient();
                        }
                        else
                        {
                            commandeUpdateLocation();
                        }
                        break;
                    case "display":
                        commandeDisplay(selectTable);
                        break;
                    case "displayall":
                        commandeDisplayAll(selectTable);
                        break;
                    case "delete":
                    case "del":
                        commandeDelete(selectTable);
                        break;
                    case "q":
                    case "quit":
                        continuer = false;
                        break;
                }
            } while (continuer);
        }

        /// <summary>
        /// Fonction qui premet de savoir qu'elle sont les aide à afficher et qui les affiche.
        /// </summary>
        /// <param name="etage">là ou on en est dans le menu</param>
        private void commandeHelp(int etage)
        {
            Dictionary<List<string>, int> listCommande = new Dictionary<List<string>, int>() {
                { new List<string> { "help", "Donnne la liste des commande." }, 10 },
                { new List<string> {"add", "Permet d'ajouter un client dans l'application." }, 1 },
                { new List<string> {"add", "Permet d'ajouter une location dans l'application." }, 2 },
                { new List<string> {"update", "Permet de modifier un client." }, 1 },
                { new List<string> {"update", "Permet de modifier une location." }, 2 },
                { new List<string> {"display", "Permet d'afficher un client." }, 1 },
                { new List<string> {"display", "Permet d'afficher une location." }, 2 },
                { new List<string> {"displayAll", "Permet d'afficher tout les client."}, 1 },
                { new List<string> {"displayAll", "Permet d'afficher toute les location."}, 2 },
                { new List<string> {"delete ou del", "Permet de suprimer un client en fonction de sont numéro." }, 1 },
                { new List<string> {"delete ou del", "Permet de suprimer une location en fonction de sont numéro." }, 2 },
                { new List<string> {"client ou c", "Permet de rentrer dans le menu de client." }, 0 },
                { new List<string> {"location ou l", "Permet de rentrer dans le menu de location." }, 0 },
                { new List<string> {"quit ou q", "Permet de quitter l'application." }, 10 }
            };

            foreach (var com in listCommande)
            {
                if(com.Value == etage || com.Value == 10)
                {
                    Console.WriteLine("{0} : {1}", com.Key[0], com.Key[1]);
                }
            }
        }

        private void commandeAddClient()
        {
            bool continuer = true;
            string nom = "";
            string prenom = "";
            string birth = "";
            string adresse = "";
            string cPostal = "";
            string ville = "";
            do
            {
                Console.WriteLine("Nom du client :");
                Console.Write(">>> ");
                nom = Console.ReadLine();
                Console.WriteLine("Prenom du client :");
                Console.Write(">>> ");
                prenom = Console.ReadLine();
                Console.WriteLine("Date de naissance du client (jj/mm/yyyy):");
                Console.Write(">>> ");
                birth = Console.ReadLine();
                Console.WriteLine("Adresse du client :");
                Console.Write(">>> ");
                adresse = Console.ReadLine();
                Console.WriteLine("Code postal du client :");
                Console.Write(">>> ");
                cPostal = Console.ReadLine();
                Console.WriteLine("Ville du client :");
                Console.Write(">>> ");
                ville = Console.ReadLine();

                continuer = false;
            } while (continuer);
            Console.WriteLine(Controller.addClient(nom, prenom, birth, adresse, cPostal, ville));
        }

        private void commandeAddLocation()
        {
            bool continuer = true;
            string km = "";
            string dateD = "";
            string dateF = "";
            string client = "";
            string vehicule = "";
            do
            {
                Console.WriteLine("Nombre de km :");
                Console.Write(">>> ");
                km = Console.ReadLine();
                Console.WriteLine("Date de debut de la location (jj/mm/yyyy):");
                Console.Write(">>> ");
                dateD = Console.ReadLine();
                Console.WriteLine("Date de fin de la location (jj/mm/yyyy):");
                Console.Write(">>> ");
                dateF = Console.ReadLine();
                Console.WriteLine("id client");
                Console.Write(">>> ");
                client = Console.ReadLine();
                Console.WriteLine("id vehicule :");
                Console.Write(">>> ");
                vehicule = Console.ReadLine();

                continuer = false;
            } while (continuer);
            Console.WriteLine(Controller.addLocation(km, dateD, dateF, client, vehicule));
        }

        private void commandeUpdateClient()
        {
            bool continuer = true;
            string choix = "";
            string result = "";
            string table = "CLIENT";
            string id = "";
            string value = "";
            Console.WriteLine("Quel utilisateur voulez vous modifier :");
            Console.Write(">>> ");
            id = Console.ReadLine();
            do
            {
                Console.WriteLine("Quel champ voulez vous update ? (NOM, PRENOM, DATE, ADRESSE, CODE_POSTAL, VILLE) :");
                Console.Write(">>> ");
                choix = Console.ReadLine();
                switch (choix.ToLower())
                {
                    case "nom":
                        Console.WriteLine("Quel valeurs doit prendre le champs nom :");
                        Console.Write(">>> ");
                        value = Console.ReadLine();
                        result = Controller.update(table, "NOM", value, id);
                        break;
                    case "prenom":
                        Console.WriteLine("Quel valeurs doit prendre le champs prenom :");
                        Console.Write(">>> ");
                        value = Console.ReadLine();
                        result = Controller.update(table, "PRENOM", value, id);
                        break;
                    case "date":
                        Console.WriteLine("Quel valeurs doit prendre la date d'anniversaire :");
                        Console.Write(">>> ");
                        value = Console.ReadLine();
                        result = Controller.update(table, "DATE_NAISSANCE", value, id);
                        break;
                    case "adresse":
                        Console.WriteLine("Quel valeurs doit prendre le champs adresse :");
                        Console.Write(">>> ");
                        value = Console.ReadLine();
                        result = Controller.update(table, "ADRESSE", value, id);
                        break;
                    case "code_postal":
                        Console.WriteLine("Quel valeurs doit prendre le champs code postal :");
                        Console.Write(">>> ");
                        value = Console.ReadLine();
                        result = Controller.update(table, "CODE_POSTAL", value, id);
                        break;
                    case "ville":
                        Console.WriteLine("Quel valeurs doit prendre le champs ville :");
                        Console.Write(">>> ");
                        value = Console.ReadLine();
                        result = Controller.update(table, "VILLE", value, id);
                        break;
                    default:
                        continuer = false;
                        break;
                }
            } while (continuer);
            Console.WriteLine(result);
        }

        private void commandeUpdateLocation()
        {
            bool continuer = true;
            string choix = "";
            string result = "";
            string table = "LOUE";
            string id = "";
            string value = "";
            Console.WriteLine("Quel location voulez vous modifier ?");
            Console.Write(">>> ");
            id = Console.ReadLine();
            do
            {
                Console.WriteLine("Quel champ voulez vous update ? (KM, DATE_DEBUT, DATE_FIN, CLIENT, VEHICULE) :");
                Console.Write(">>> ");
                choix = Console.ReadLine();
                switch (choix.ToLower())
                {
                    case "km":
                        Console.WriteLine("Quel valeurs doit prendre le champs km :");
                        Console.Write(">>> ");
                        value = Console.ReadLine();
                        result = Controller.updateLoue(table, "NB_KM", value, id);
                        break;
                    case "date_debut":
                        Console.WriteLine("Quel valeurs doit prendre le champs date de début :");
                        Console.Write(">>> ");
                        value = Console.ReadLine();
                        result = Controller.updateLoue(table, "DATE_DEBUT", value, id);
                        break;
                    case "date_fin":
                        Console.WriteLine("Quel valeurs doit prendre le champs date de fin :");
                        Console.Write(">>> ");
                        value = Console.ReadLine();
                        result = Controller.updateLoue(table, "DATE_FIN", value, id);
                        break;
                    case "client":
                        Console.WriteLine("Quel valeurs doit prendre le champs client :");
                        Console.Write(">>> ");
                        value = Console.ReadLine();
                        result = Controller.updateLoue(table, "CLIENT", value, id);
                        break;
                    case "vehicule":
                        Console.WriteLine("Quel valeurs doit prendre le champs vehicule :");
                        Console.Write(">>> ");
                        value = Console.ReadLine();
                        result = Controller.updateLoue(table, "VEHICULE", value, id);
                        break;
                    default:
                        continuer = false;
                        break;
                }
            } while (continuer);
            Console.WriteLine(result);
        }

        private void commandeDisplayAll(char t)
        {
            string table = "Client";
            if(t == 'l')
            {
                table = "loue";
            }
            Console.WriteLine(Controller.displayAll(table));
        }

        private void commandeDisplay(char t)
        {
            Console.WriteLine("Quel est l'id à observer ?");
            Console.Write(">>> ");
            string id = Console.ReadLine();
            string table = "Client";
            if (t == 'l')
            {
                table = "loue";
            }
            Console.WriteLine(Controller.display(table, id));
        }

        private void commandeDelete(char t)
        {
            Console.WriteLine("Quel est l'id à suprimer ?");
            Console.Write(">>> ");
            string id = Console.ReadLine();
            string table = "Client";
            if (t == 'l')
            {
                table = "loue";
            }
            Console.WriteLine(Controller.delete(table, id));
        }
    }
}
