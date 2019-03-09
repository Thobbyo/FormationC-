using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ProjetFinalDll.Class;
using ProjetFinalDll.Exceptions;

namespace ProjetFinal.Class
{
    public static class Interface
    {
        /// <summary>
        /// Fonction qui vas afficher le menu de base et permettre l'accè au différente fonctionnallilter.
        /// </summary>
        public static void menu()
        {
            bool continuer = true;
            while (continuer)
            {
                Console.Write('\n');
                Console.WriteLine("Que souhaitez vous faire ('help' pour la liste des commandes):");
                string commande = Console.ReadLine();
                switch (commande)
                {
                    case "help":
                        helpCommande();
                        break;
                    case "add":
                        addCommande();
                        break;
                    case "update":
                        updateCommande();
                        break;
                    case "display":
                        displayCommande();
                        break;
                    case "displayAll":
                        Console.WriteLine(Sauvegarde.toString());
                        break;
                    case "save":
                        saveCommande();
                        break;
                    case "import":
                        importCommande();
                        break;
                    case "find":
                        findCommande();
                        break;
                    case "sort":
                        sortCommande();
                        break;
                    case "delete":
                    case "del":
                        deleteCommande();
                        break;
                    case "quit":
                    case "q":
                        continuer = false;
                        break;
                }
            }
        }

        /// <summary>
        /// Liste des commande utilisable
        /// </summary>
        private static void helpCommande()
        {
            Dictionary<string, string> listCommande = new Dictionary<string, string>() {
                { "help", "Donnne la liste des commande." },
                { "add", "Permet d'ajouter un vhéicule dans l'application." },
                { "update", "Permet de modifier un véhicule." },
                { "display", "Permet d'afficher un véhicule." },
                { "displayAll", "Permet d'afficher tout les véhicule."},
                { "delete ou del", "Permet de suprimer un véhicule en fonction de sont numéro." },
                { "find", "Permet de faire une recherche." },
                { "save", "Permet de sauvegarder les véhicule crée dans un fichier binaire." },
                { "import", "Permet d'importer des céhicule depuis un fichier binaire." },
                { "sort", "Permet de ..." },
                { "quit ou q", "Permet de quitter l'application." }
            };

            foreach (var com in listCommande)
            {
                Console.WriteLine("{0} : {1}", com.Key, com.Value);
            }
        }

        /// <summary>
        /// Menu pour l'ajoue d'un véicule
        /// </summary>
        private static void addCommande()
        {
            bool continuer = true;
            string commande;
            string info = "0";
            do
            {
                Console.WriteLine("Est ce que c'est une camion ou une voiture [c/v] : ");
                commande = Console.ReadLine();
                switch (commande)
                {
                    case "camion":
                    case "c":
                        commande = "c";
                        Console.WriteLine("Quel est le poid de votre camion en Kg : ");
                        info = Console.ReadLine();
                        break;
                    case "voiture":
                    case "v":
                        commande = "v";
                        Console.WriteLine("Quel est la puissance de votre voiture en cheveaux : ");
                        info = Console.ReadLine();
                        break;
                }

                if (info != "0")
                {
                    int valeurs;
                    if (int.TryParse(info, out valeurs))
                    {
                        Console.WriteLine("Quel est la marque de votre véhicule : ");
                        string marque = Console.ReadLine();
                        Console.WriteLine("Quel est le modèle de votre véhicule : ");
                        string modele = Console.ReadLine();

                        Vehicule vec = null;

                        try
                        {
                            if (commande == "c")
                            {
                                vec = new Camion(marque, modele, valeurs);
                            }
                            else if (commande == "v")
                            {
                                vec = new Voiture(marque, modele, valeurs);
                            }
                            continuer = false;
                            string num = Sauvegarde.AddVehicule(vec);
                            Console.WriteLine("Le véhicule n°{0} à été enregistré.", num);
                        }
                        catch (ErreurMarqueVehicule err)
                        {
                            Console.WriteLine(err.Message);
                        }
                        catch (ErreurNumeroVehicule err)
                        {
                            Console.WriteLine(err.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vous avez mal rentrer des données.");
                    }
                }

            } while (continuer);
        }

        /// <summary>
        /// Fonction qui affiche 1 véhicule en fonction de sont numéro.
        /// </summary>
        private static void displayCommande()
        {
            bool continuer = true;
            string num = "a";
            // Regex pour savoir si l'entrer utilisateur est correct.
            Regex rx = new Regex(@"^\d+$");
            do
            {
                Console.WriteLine("Quel est le numéro du véhicule que vous souhaitez voir (entrer le numéro complet) :");
                num = Console.ReadLine();
                if (rx.IsMatch(num))
                {
                    Console.WriteLine(Sauvegarde.toString(num));
                    continuer = false;
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas rentrer un numéro correctement.");
                }
            } while (continuer);

        }

        /// <summary>
        /// Fonction qui suprime un véhicule
        /// </summary>
        private static void deleteCommande()
        {
            bool continuer = true;
            string num = "a";
            // Regex pour savoir si l'entrer utilisateur est correct.
            Regex rx = new Regex(@"^\d+$");
            do
            {
                Console.WriteLine("Quel est le numéro du véhicule que vous souhaitez suprimer (entrer le numéro complet) :");
                num = Console.ReadLine();
                if (rx.IsMatch(num))
                {
                    Console.WriteLine(Sauvegarde.toString(num));
                    Console.WriteLine("Est ce que vous êtes sûr de vouloire le suprimer [y/n] :");
                    string validate = Console.ReadLine();
                    if (validate[0] == 'y')
                    {
                        Console.WriteLine(Sauvegarde.DelVehicule(num));
                    }
                    else
                    {
                        Console.WriteLine("La supression à été annulé.");
                    }
                    continuer = false;
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas rentrer un numéro correctement.");
                }
            } while (continuer);
        }

        /// <summary>
        /// Fonction qui modifie une commande
        /// </summary>
        private static void updateCommande()
        {
            bool continuer = true;
            string num = "a";
            // Regex pour savoir si l'entrer utilisateur est correct.
            Regex rx = new Regex(@"^\d+$");
            do
            {
                Console.WriteLine("Quel est le numéro du véhicule que vous souhaitez modifier (entrer le numéro complet) :");
                num = Console.ReadLine();
                if (rx.IsMatch(num))
                {
                    Console.WriteLine(Sauvegarde.toString(num));
                    char vehiculeType = Sauvegarde.getType(num);
                    if(vehiculeType == 'v')
                    {
                        Console.WriteLine("Quel paramètres souhaitez vous modifier [marque/modele/puissance] :");
                    }
                    else if (vehiculeType == 'c')
                    {
                        Console.WriteLine("Quel paramètres souhaitez vous modifier [marque/modele/poid] :");
                    }
                    string validate = Console.ReadLine();
                    string val = "";
                    switch (validate)
                    {
                        case "marque" :
                            Console.WriteLine("Quel est la nouvelle marque :");
                            val = Console.ReadLine();
                            continuer = false;
                            break;
                        case "modele":
                            Console.WriteLine("Quel est la nouvelle modele :");
                            val = Console.ReadLine();
                            continuer = false;
                            break;
                        case "puissance":
                            Console.WriteLine("Quel est la nouvelle puissance :");
                            val = Console.ReadLine();
                            continuer = false;
                            break;
                        case "poid":
                            Console.WriteLine("Quel est le nouveau poid :");
                            val = Console.ReadLine();
                            continuer = false;
                            break;
                    }
                    Console.WriteLine(Sauvegarde.updateVehicule(num, val, validate));
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas rentrer un numéro correctement.");
                }
            } while (continuer);
        }

        /// <summary>
        /// Fonction qui permet d'afficher des véhicule suivant une liste
        /// </summary>
        private static void findCommande()
        {
            Console.WriteLine("Qu'est ce que vous voulez chercher ?");
            Console.WriteLine("1 : recherche par modele.");
            Console.WriteLine("2 : recherche par marque.");
            Console.WriteLine("3 : recherche par numero.");
            Console.WriteLine("4 : recherche par poid.");
            Console.WriteLine("5 : recherche par puissance.");
            Console.WriteLine("Entrer le numéro correspondant à ce que vous chercher :");
            string recherche = Console.ReadLine();
            Console.WriteLine("Entrer le mot clé pour votre recherche :");
            string motCle = Console.ReadLine();
            string affichage = "";
            switch (recherche)
            {
                case "1":
                    affichage = Sauvegarde.findVehicule(motCle, (mots, listv) => { return (from a in listv where a.Modele == mots select a).ToList(); });
                    break;
                case "2":
                    affichage = Sauvegarde.findVehicule(motCle, (mots, listv) => { return (from a in listv where a.Marque == mots select a).ToList(); });
                    break;
                case "3":
                    affichage = Sauvegarde.findVehicule(motCle, (mots, listv) => { return (from a in listv where a.Numero == mots select a).ToList(); });
                    break;
                case "4":
                    affichage = Sauvegarde.findVehicule(motCle, (mots, listv) => { return (from a in listv where a is Camion && ((Camion)a).Poids.ToString() == mots select a).ToList(); });
                    break;
                case "5":
                    affichage = Sauvegarde.findVehicule(motCle, (mots, listv) => { return (from a in listv where a is Voiture && ((Voiture)a).Puissance.ToString() == mots select a).ToList(); });
                    break;
            }
            if(affichage == "")
            {
                Console.WriteLine("Il n'y a pas délément correspondant à votre recherche.");
            }
            else
            {
                Console.WriteLine(affichage);
            }
        }

        /// <summary>
        /// Fonction de sauvegarde dans un fichier
        /// </summary>
        private static void saveCommande()
        {
            string path = "SaveVehicule.bin";
            Console.WriteLine("Souhaitez vous donner un emplacement ou enregistrer le fichier ? [y/n] :");
            string result = Console.ReadLine();
            if(result == "y")
            {
                Console.WriteLine("Donner l'emplacement et le nom de ficher (l'extension sera rajouter automatiquement) :");
                path = Console.ReadLine() + ".bin";
            }
            Console.WriteLine(Sauvegarde.saveVehicule(path));
        }

        /// <summary>
        /// Fonction de récupère dans un fichier
        /// </summary>
        private static void importCommande()
        {
            string path = "SaveVehicule.bin";
            Console.WriteLine("Souhaitez vous donner un emplacement ou est enregistrer le fichier à importer ? [y/n] :");
            string result = Console.ReadLine();
            if (result == "y")
            {
                Console.WriteLine("Donner l'emplacement et le nom di ficher (l'extension sera rajouter automatiquement) :");
                path = Console.ReadLine() + ".bin";
            }
            Console.WriteLine(Sauvegarde.importVehicule(path));
        }

        /// <summary>
        /// Fonction qui permet de trier les véhicule
        /// </summary>
        private static void sortCommande()
        {
            Console.WriteLine("Qu'est ce que vous voulez chercher ?");
            Console.WriteLine("1 : trier par modele.");
            Console.WriteLine("2 : trier par marque.");
            Console.WriteLine("3 : trier par numero.");
            //Console.WriteLine("4 : trier par poid.");
            //Console.WriteLine("5 : trier par puissance.");
            Console.WriteLine("Entrer le numéro correspondant à comment vous voulez trier :");
            string recherche = Console.ReadLine();
            string affichage = "";
            switch (recherche)
            {
                case "1":
                    affichage = Sauvegarde.sortVehicule((listv) => { return (from a in listv orderby a.Modele select a).ToList(); });
                    break;
                case "2":
                    affichage = Sauvegarde.sortVehicule((listv) => { return (from a in listv orderby a.Marque select a).ToList(); });
                    break;
                case "3":
                    affichage = Sauvegarde.sortVehicule((listv) => { return (from a in listv orderby a.Numero select a).ToList(); });
                    break;
                //case "4":
                //    affichage = Sauvegarde.sortVehicule((listv) => { return (from a in listv where a is Camion orderby ((Camion)a).Poids select a).ToList(); });
                //    break;
                //case "5":
                //    affichage = Sauvegarde.sortVehicule((listv) => { return (from a in listv where a is Voiture orderby ((Voiture)a).Puissance select a).ToList(); });
                //    break;
            }
            if (affichage == "")
            {
                Console.WriteLine("Il y a eu un problème dans le tri.");
            }
            else
            {
                Console.WriteLine(affichage);
            }
        }
    }
}
