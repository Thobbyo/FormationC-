using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
     * CTRL E + D
     * CTRL E + C
     * CTRL E + U
     * CTRL M + O
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer le numéro de l'exercice :");
            int exo = entrerNombre(1)[0];
            switch (exo)
            {
                case 1:
                    Console.WriteLine("Hello\nWorld");
                    break;
                case 3:
                    mots();
                    break;
                case 4:
                    nombreEqual();
                    break;
                case 5:
                    invertionVar();
                    break;
                case 6:
                    operation();
                    break;
                case 7:
                    moyenne();
                    break;
                case 8:
                    max();
                    break;
                case 9:
                    positifOuNegatif();
                    break;
                case 10:
                    paireOuImpaire();
                    break;
                case 11:
                    convertionCToKAndF();
                    break;
                case 12:
                    jourSemaine();
                    break;
                case 13:
                    blockUser();
                    break;
                case 14:
                    formul();
                    break;
                case 15:
                    dixChiffre();
                    break;
                case 16:
                    tablesMultiplication();
                    break;
                case 17:
                    triangle();
                    break;
                case 18:
                    piramide();
                    break;
                case 19:
                    diamand();
                    break;
                case 20:
                    dateToDay();
                    break;
                case 21:
                    userToDate();
                    break;
                case 22:
                    diffTempsDate();
                    break;
                case 23:
                    strToDate();
                    break;
                case 24:
                    devin();
                    break;
                case 25:
                    strToUpper();
                    break;
                case 26:
                    strLength();
                    break;
                case 27:
                    addSpace();
                    break;
                case 28:
                    compareStr();
                    break;
                case 29:
                    strPalin();
                    break;
                case 30:
                    FizzBuzz();
                    break;
                case 31:
                    exo31();
                    break;
                case 36:
                    exo36();
                    break;
                case 41:
                    exoT1();
                    break;
                case 42:
                    exoT2();
                    break;
                case 43:
                    exoT3();
                    break;
                case 44:
                    exoT4();
                    break;
                case 45:
                    exoT5();
                    break;
                case 46:
                    exoT6();
                    break;
                case 51:
                case 52:
                case 53:
                case 54:
                    exoQ1234();
                    break;
                case 55:
                    exoQ5();
                    break;
                case 56:
                    exoQ6();
                    break;
                case 57:
                    exoQ7();
                    break;
                case 58:
                    exoQ8();
                    break;
                case 59:
                    exoQ9();
                    break;
                case 60:
                    exoQ10();
                    break;
                case 61:
                    exoQ11();
                    break;
                case 62:
                    exoQ12();
                    break;
                case 63:
                    exoQ13();
                    break;
                case 71:
                    exoE1();
                    break;
                case 72:
                    exoE2();
                    break;
                case 300:
                    morpion();
                    break;
            }

            Console.ReadLine();
        }

        #region exception

        static void exoE2()
        {
            try
            {
                Eleve eleve = new Eleve("toto", 30, -1);
                Eleve eleve1 = new Eleve("toto", 20, -1);
                Eleve eleve2 = new Eleve("toto", 30, 13);
                Eleve eleve3 = new Eleve("toto", 20, 13);
            }
            catch (InvalidAgeException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (InvalidNoteException err)
            {
                Console.WriteLine(err.Message);
            }

        }

        static void exoE1()
        {
            int d = 5;
            int D = 0;
            try
            {
                Console.WriteLine(d / D);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division par 0 impossible.");
            }
        }

        #endregion

        #region linq

        static void exoQ13()
        {
            List<Personne> tabPers = new List<Personne> {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Personne("SPIELBERG", "Steven", "18/12/1946"),
                new Personne("DUPOND", "Lucas", "14/05/1944"),
                new Personne("TATA", "Morrel", "12/08/2003"),
                new Personne("JEAN", "Toto", "08/01/1800"),
                new Personne("HERISSANDRE", "Thobbyo", "03/06/1997"),
                new Personne("MANIDE", "Toto", "05/06/1954"),
                new Personne("PETTER", "Anne", "29/10/1996"),
                new Personne("PREVER", "Toto", "26/02/1923"),
                new Personne("LEGROS", "Gégé", "07/07/1967"),
                new Personne("GAUCHE", "Louise", "10/10/2010")
            };

            var req = from pers in tabPers group pers by pers.prenom;

            foreach (var persG in req)
            {
                Console.WriteLine(persG.Key);
                foreach (var pers in persG)
                {
                    Console.WriteLine("   " + pers);
                }
            }

        }

        static void exoQ12()
        {
            List<Personne> tabPers = new List<Personne> {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Personne("SPIELBERG", "Steven", "18/12/1946"),
                new Personne("DUPOND", "Lucas", "14/05/1944"),
                new Personne("TATA", "Morrel", "12/08/2003"),
                new Personne("JEAN", "Toto", "08/01/1800"),
                new Personne("HERISSANDRE", "Thobbyo", "03/06/1997"),
                new Personne("MANIDE", "Momo", "05/06/1954"),
                new Personne("PETTER", "Anne", "29/10/1996"),
                new Personne("PREVER", "Morice", "26/02/1923"),
                new Personne("LEGROS", "Gégé", "07/07/1967"),
                new Personne("GAUCHE", "Louise", "10/10/2010")
            };

            var reqQ = from pers in tabPers
                       let match = Regex.Match(pers.nom, @"^d", RegexOptions.IgnoreCase)
                       where match.Success
                       select pers;

            // var req = tabPers.FirstOrDefault(pers => pers.nom.StartsWith("d") || pers.nom.StartsWith("D")); // Si on utilise cette ligne, enlever le first or default dans la condition
            if (reqQ.FirstOrDefault() == null)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }

        static void exoQ11()
        {
            List<Personne> tabPers = new List<Personne> {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Personne("SPIELBERG", "Steven", "18/12/1946"),
                new Personne("DUPOND", "Lucas", "14/05/1944"),
                new Personne("TATA", "Morrel", "12/08/2003"),
                new Personne("JEAN", "Toto", "08/01/1800"),
                new Personne("HERISSANDRE", "Thobbyo", "03/06/1997"),
                new Personne("MANIDE", "Momo", "05/06/1954"),
                new Personne("PETTER", "Anne", "29/10/1996"),
                new Personne("PREVER", "Morice", "26/02/1923"),
                new Personne("LEGROS", "Gégé", "07/07/1967"),
                new Personne("GAUCHE", "Louise", "10/10/2010")
            };

            var req = from pers in tabPers where string.Compare(pers.nom, "dupond", true) == 0 select pers;

            foreach (var item in req)
            {
                Console.WriteLine(item);
            }

        }

        static void exoQ10()
        {
            List<Personne> tabPers = new List<Personne> {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Personne("SPIELBERG", "Steven", "18/12/1946"),
                new Personne("GEO0RGE", "Lucas", "14/05/1944"),
                new Personne("TATA", "Morrel", "12/08/2003"),
                new Personne("JEAN", "Toto", "08/01/1800"),
                new Personne("HERISSANDRE", "Thobbyo", "03/06/1997"),
                new Personne("MANIDE", "Momo", "05/06/1954"),
                new Personne("PETTER", "Anne", "29/10/1996"),
                new Personne("PREVER", "Morice", "26/02/1923"),
                new Personne("LEGROS", "Gégé", "07/07/1967"),
                new Personne("GAUCHE", "Louise", "10/10/2010")
            };

            foreach (var item in tabPers.GetRange(6, 3))
            {
                Console.WriteLine(item);
            }
        }

        static void exoQ9()
        {
            List<Personne> tabPers = new List<Personne> {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Personne("SPIELBERG", "Steven", "18/12/1946"),
                new Personne("GEO0RGE", "Lucas", "14/05/1944")
            };

            foreach (var item in tabPers.GetRange(0, 2))
            {
                Console.WriteLine(item);
            }
        }

        static void exoQ8()
        {
            List<Personne> tabPers = new List<Personne> {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Personne("SPIELBERG", "Steven", "18/12/1946"),
                new Personne("GEO0RGE", "Lucas", "14/05/1944")
            };

            var reqStartByD = from pers in tabPers
                              let match = Regex.Match(pers.nom, @"^s", RegexOptions.IgnoreCase)
                              where match.Success
                              orderby pers.prenom descending
                              select new { nom = pers.nom.ToUpper(), pers.prenom };

            foreach (var item in reqStartByD)
            {
                Console.WriteLine($"{item.nom}, {item.prenom}");
            }
        }

        static void exoQ7()
        {
            List<Personne> tabPers = new List<Personne> {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Personne("SPIELBERG", "Steven", "18/12/1946"),
                new Personne("GEO0RGE", "Lucas", "14/05/1944")
            };

            var reqStartByD = from pers in tabPers select pers.nom;

            foreach (string item in reqStartByD)
            {
                Console.WriteLine(item);
            }
        }

        static void exoQ6()
        {
            List<Personne> tabPers = new List<Personne> {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Personne("SPIELBERG", "Steven", "18/12/1946"),
                new Personne("GEO0RGE", "Lucas", "14/05/1944")
            };

            var reqStartByD = from pers in tabPers where pers.nom[0] == 'S' || pers.nom[0] == 's' select pers;

            foreach (Personne item in reqStartByD)
            {
                Console.WriteLine(item);
            }
        }

        static void exoQ5()
        {
            List<Personne> tabPers = new List<Personne> {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Personne("SPIELBERG", "Steven", "18/12/1946"),
                new Personne("GEO0RGE", "Lucas", "14/05/1944")
            };

            var orderByNom = from pers in tabPers orderby pers.nom descending select pers;
            var orderByPrenom = from pers in tabPers orderby pers.prenom descending select pers;

            foreach(Personne p in orderByNom)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("---------------------------------------------------------------------------");
            foreach (Personne p in orderByPrenom)
            {
                Console.WriteLine(p);
            }
        }

        static void exoQ1234()
        {
            List<int> listInt = new List<int>() { 5, 6, 7, 8, 2, 4 };

            listInt.Sum();

            var req = from a in listInt select a;

            Console.WriteLine("La somme : " + req.Sum());
            Console.WriteLine("La moyenne : " + req.Average());
            Console.WriteLine("Le nombre d'éléments : " + req.Count());

            var reqSup6 = from a in listInt where a > 6 select a;
            foreach(int num in reqSup6)
            {
                Console.Write($"{num} ");
            }

        }

        #endregion

        #region tableau

        //static void testStacksQueue()
        //{
        //    Stack<int> stack = new Stack<int>();
        //    stack.Push(1);
        //    stack.Push(2);
        //    Console.WriteLine();
        //}

        static void exoT6()
        {
            List<Personne> tabInt = new List<Personne> {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Employe("SPIELBERG", "Steven", "18/12/1946", 1400),
                new Employe("GEO0RGE", "Lucas", "14/05/1944", 2300)
            };

            tabInt.Sort();

            foreach (Personne item in tabInt)
            {
                Console.WriteLine(item);
            }
            
        }

        static void exoT5()
        {
            List<ITravailleur> tabInt = new List<ITravailleur> {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Employe("SPIELBERG", "Steven", "18/12/1946", 1400),
                new Employe("GEO0RGE", "Lucas", "14/05/1944", 2300)
            };

            if (tabInt.Contains(new Personne("SKYWALKER", "Luc", "20/07/1977")))
            {
                Console.WriteLine("le tableau contient la personne.");
            }
            else
            {
                Console.WriteLine("le tableau ne contient pas la personne.");
            }
        }

        static void exoT4()
        {
            Dictionary<int, ITravailleur> dicoIntStr = new Dictionary<int, ITravailleur>();
            dicoIntStr.Add(0, new Personne("KENOBI", "Hobi Wan", "20/07/1937"));
            dicoIntStr.Add(1, new Personne("SKYWALKER", "Luc", "20/07/1977"));
            dicoIntStr.Add(2, new Employe("SPIELBERG", "Steven", "18/12/1946", 1400));
            dicoIntStr.Add(3, new Employe("GEO0RGE", "Lucas", "14/05/1944", 2300));

            foreach(var key in dicoIntStr)
            {
                Console.WriteLine($"Clé : {key.Key} : \n{key.Value}");
            }
        }

        static void exoT3()
        {
            ITravailleur[] tabTravailleurs = new ITravailleur[4] {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Employe("SPIELBERG", "Steven", "18/12/1946", 1400),
                new Employe("GEO0RGE", "Lucas", "14/05/1944", 2300)
            };

            foreach (ITravailleur elem in tabTravailleurs)
            {
                Console.Write(elem + "\n");
            }
        }

        static void exoT2()
        {
            List<string> tabStr = new List<string>() { "aa", "ba", "bb", "df", "dc", "ce", "eh", "cu", "dr", "dd", "cc", "ee", "zt" };
            tabStr.Sort();
            foreach (string elem in tabStr)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        static void exoT1()
        {
            int[] tabInt = { 5, 45, 85, 63, 84, 12, 36, 48, 2, 5 };
            Array.Sort(tabInt);
            foreach(int elem in tabInt)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        #endregion

        #region classe et polymorphisme

        static void exo36()
        {
            Personne[] tabPers = new Personne[4] {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Employe("SPIELBERG", "Steven", "18/12/1946", 1400),
                new Employe("GEO0RGE", "Lucas", "14/05/1944", 2300)
            };

            foreach(Personne pers in tabPers)
            {
                pers.Afficher();
            }

            ITravailleur[] tabTravailleurs = new ITravailleur[4] {
                new Personne("KENOBI", "Hobi Wan", "20/07/1937"),
                new Personne("SKYWALKER", "Luc", "20/07/1977"),
                new Employe("SPIELBERG", "Steven", "18/12/1946", 1400),
                new Employe("GEO0RGE", "Lucas", "14/05/1944", 2300)
            };

            foreach (ITravailleur pers in tabTravailleurs)
            {
                pers.Afficher();
            }
        }
        
        static void exo31()
        {
            Console.WriteLine("Tout les test pour montrer que les exo sur les classe sont bien réaliser.");
            Personne pers = new Personne("LECOUFFE", "Thomas", "03/06/1997");
            pers.Afficher();
            pers.invPrenom();
            pers.Afficher();
            Personne pers2 = new Personne();
            pers2.Afficher();

            Console.WriteLine("\nOn crée une personne, on l'affecte a une autre variable personne \npuis on change une des personne et on raffiche les 2.");
            Personne toto = new Personne("MORIAL", "Jean-Pierre", "21/08/1541");
            Personne tata = new Personne("CHOUX", "Marreur", "12/12/1212");
            toto.Afficher();
            tata.Afficher();
            toto = tata;
            toto.invPrenom();
            toto.Afficher();
            tata.Afficher();
        }

        #endregion

        #region PARTIE1

        static void morpion()
        {
            void switchPlayer(ref int joueur)
            {
                if (joueur == 1)
                {
                    joueur = 2;
                }
                else
                {
                    joueur = 1;
                }
            }

            bool addTab(ref char[,] tab, string pos, int joueur)
            {
                bool retour = false;
                int x = 0, y = 0;

                switch (pos[0])
                {
                    case 'a':
                    case 'A':
                        x = 0;
                        break;
                    case 'b':
                    case 'B':
                        x = 1;
                        break;
                    case 'c':
                    case 'C':
                        x = 2;
                        break;
                    default:
                        break;
                }
                switch (pos[1])
                {
                    case '1':
                        y = 0;
                        break;
                    case '2':
                        y = 1;
                        break;
                    case '3':
                        y = 2;
                        break;
                    default:
                        break;
                }

                if (tab[x, y] == ' ')
                {
                    retour = true;
                    if (joueur == 1)
                    {
                        tab[x, y] = 'X';
                    }
                    if (joueur == 2)
                    {
                        tab[x, y] = 'O';
                    }
                }

                return retour;
            }

            bool victoire(char[,] tab)
            {
                bool res = false;

                if (tab[0, 0] == tab[0, 1] && tab[0, 1] == tab[0, 2] && tab[0, 0] != ' ')
                {
                    res = true;
                }
                if (tab[0, 0] == tab[1, 1] && tab[1, 1] == tab[2, 2] && tab[0, 0] != ' ')
                {
                    res = true;
                }
                if (tab[0, 0] == tab[1, 0] && tab[1, 0] == tab[2, 0] && tab[0, 0] != ' ')
                {
                    res = true;
                }
                if (tab[0, 1] == tab[1, 1] && tab[1, 1] == tab[2, 1] && tab[0, 1] != ' ')
                {
                    res = true;
                }
                if (tab[0, 2] == tab[1, 2] && tab[1, 2] == tab[2, 2] && tab[0, 2] != ' ')
                {
                    res = true;
                }
                if (tab[0, 2] == tab[1, 1] && tab[1, 1] == tab[2, 0] && tab[0, 2] != ' ')
                {
                    res = true;
                }
                if (tab[1, 0] == tab[1, 1] && tab[1, 1] == tab[1, 2] && tab[1, 0] != ' ')
                {
                    res = true;
                }
                if (tab[2, 0] == tab[2, 1] && tab[2, 1] == tab[2, 2] && tab[2, 0] != ' ')
                {
                    res = true;
                }

                return !res;
            }

            Console.WriteLine("Petit jeu de morpion.");
            char[,] mT = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

            bool notEnd = true;
            int playCont = 0;
            int player = 2;     // Player vaux 1 ou 2 en fonction du joueurs à qui c'est le tour
            string play = "";   // Play contient la position à la quel le joueurs à jouer

            while (notEnd && playCont < 9)
            {
                playCont++;
                switchPlayer(ref player);
                Console.WriteLine(string.Format("    1   2   3\n" +
                                                "  +---+---+---+\n" +
                                                "A | {0} | {1} | {2} |\n" +
                                                "  +---+---+---+\n" +
                                                "B | {3} | {4} | {5} |\n" +
                                                "  +---+---+---+\n" +
                                                "C | {6} | {7} | {8} |\n" +
                                                "  +---+---+---+",
                                                mT[0, 0], mT[0, 1], mT[0, 2], mT[1, 0], mT[1, 1], mT[1, 2], mT[2, 0], mT[2, 1], mT[2, 2]));
                Console.WriteLine(string.Format("Joueur {0} : \nRentrer une coordonnée de la ou vous aller jouer :", player));

                Match match;
                bool cont = true;
                do
                {
                    play = Console.ReadLine();
                    match = Regex.Match(play, @"[abcABC][123]", RegexOptions.IgnoreCase);
                    if (!match.Success)
                    {
                        Console.WriteLine("Vous n'avez pas renter un emplacement valable");
                    }
                    else
                    {
                        cont = !addTab(ref mT, play, player);
                        if (cont)
                        {
                            Console.WriteLine("Vous n'êtes pas le 1er a jouer à cette emplacement.");
                        }
                    }
                } while (!match.Success || cont);

                notEnd = victoire(mT);
                if (!notEnd)
                {
                    Console.WriteLine(string.Format("Félicitation au joueurs {0} qui a remporté cette partie !", player));
                }
                if (playCont == 9)
                {
                    Console.WriteLine("La partie se termine sur une égalité.");
                }
            }
        }

        static void FizzBuzz()
        {
            Console.WriteLine("Jeu du FizzBuzz... Chercher sur google ou lisé le code !");
            for (int i = 1; i < 100; i++)
            {
                string write = "";
                if (i % 3 == 0)
                {
                    write += "Fizz";
                }
                if (i % 5 == 0)
                {
                    write += "Buzz";
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    write = i + "";
                }
                Console.Write(write + " ");
                if (i % 9 == 0)
                {
                    Console.Write("\n");
                }
            }
        }

        static void strPalin()
        {
            Console.WriteLine("Test si le mots donnée est un palindrome");
            Console.WriteLine("Dit ce qui te passe par la tête !");
            string laChaine1 = Console.ReadLine();
            string laChaine2 = "";
            for (int i = laChaine1.Length - 1; 0 <= i; i--)
            {
                laChaine2 += laChaine1[i];
            }
            if (string.Compare(laChaine1, laChaine2, true) == 0)
            {
                Console.WriteLine("C'est un palindrome.");
            }
            else
            {
                Console.WriteLine("Ce n'est pas un palindrome.");
            }
        }

        static void compareStr()
        {
            Console.WriteLine("Test de l'égaliter de 2 chaine de charactères (cast ignoré).");
            Console.WriteLine("Dit ce qui te passe par la tête !");
            string laChaine1 = Console.ReadLine();
            Console.WriteLine("Dit ce qui te passe par la tête !");
            string laChaine2 = Console.ReadLine();
            if (string.Compare(laChaine1, laChaine2, true) == 0)
            {
                Console.WriteLine("Les 2 chaines sont égale.");
            }
            else
            {
                Console.WriteLine("Les 2 chaines ne sont pas égale.");
            }
        }

        static void addSpace()
        {
            Console.WriteLine("Ajoue d'espace entre les lettre et retourne le mots.");
            Console.WriteLine("Dit ce qui te passe par la tête !");
            string laChaine = Console.ReadLine();
            string futurStr = "";
            for (int i = laChaine.Length - 1; 0 <= i; i--)
            {
                futurStr += string.Format("{0} ", laChaine[i]);
            }
            Console.WriteLine(futurStr);
        }

        static void strLength()
        {
            Console.WriteLine("Calcul de la longueur d'une chaine.");
            Console.WriteLine("Dit ce qui te passe par la tête !");
            string laChaine = Console.ReadLine();
            int inc = 0;
            foreach (char chara in laChaine)
            {
                inc++;
            }
            Console.WriteLine(string.Format("il y a {0} éléments.", inc));
        }

        static void strToUpper()
        {
            Console.WriteLine("Mise ne majuscule d'une chaine de charactères.");
            Console.WriteLine("Dit ce qui te passe par la tête !");
            string laChaine = Console.ReadLine();
            Console.WriteLine(laChaine.ToUpper());
        }

        static void devin()
        {
            Random random = new Random();
            int num = random.Next(1000);
            Console.WriteLine("Un nombre entre 0 et 1000 à été choisie, à toi de le deviner.");
            int userChoice = -1;
            do
            {
                userChoice = entrerNombre(1)[0];
                if (userChoice > num)
                {
                    Console.WriteLine("C'est moins !");
                }
                else if (userChoice < num)
                {
                    Console.WriteLine("C'est plus !");
                }
            } while (userChoice != num);
            Console.WriteLine("Bravos ! Tu a trouver ! Tien, voilà un croissant :\n" +
                        "    ____                                    ?~~bL \n" +
                        "  z@~ b                                    |  `U, \n" +
                        " ]@[  |                                   ]'  z@' \n" +
                        " d@~' `|, .__     _----L___----, __, .  _t'   `@j \n" +
                        "`@L_,   \"-~ `--\"~-a,           `C.  ~\"\"O_    ._`@ \n" +
                        " q@~'   ]P       ]@[            `Y=,   `H+z_  `a@ \n" +
                        " `@L  _z@        d@               Ya     `-@b,_a' \n" +
                        "  `-@d@a'       )@[               `VL      `a@@' \n" +
                        "    aa~'   ],  .a@'                qqL  ), ./~ \n" +
                        "    @@_  _z~  _d@[                 .V@  .L_d' \n" +
                        "     \"~@@@'  ]@@@'        __      )@n@bza@-\" \n" +
                        "       `-@zzz@@@L        )@@z     ]@@=%-\" \n" +
                        "         \"~~@@@@@bz_    _a@@@@z___a@K\" \n" +
                        "             \"~-@@@@@@@@@@@@@@@@@@~\" \n" +
                        "                `~~~-@~~-@@~~~~~'  ");
        }

        static void strToDate()
        {
            Console.WriteLine("Affichage d'une date rentrer par l'utilisateur.");
            try
            {
                Console.WriteLine("Entrer une date sous le format jj/mm/aaaa :");
                string dateUser = Console.ReadLine();
                DateTime oDate = Convert.ToDateTime(dateUser);
                Console.WriteLine(oDate.GetDateTimeFormats('F')[0]);
            }
            catch
            {
                Console.WriteLine("Vous n'avez pas rentre une date correcte.");
            }
        }

        static void diffTempsDate()
        {
            Console.WriteLine("Différence entre 2 date.");
            DateTime date1 = DateTime.Now;
            DateTime date2 = new DateTime(0);
            TimeSpan res = date1.Subtract(date2);
            Console.WriteLine(string.Format("Entre le {0} et le {1}, {2} jour se sont écoulés.",
                                date1.GetDateTimeFormats('D')[0],
                                date2.GetDateTimeFormats('D')[0],
                                res.Days));
        }

        static void userToDate()
        {
            Console.WriteLine("Affichage de la date choisie par l'utilisateur.");
            Console.WriteLine("Quelles est l'année que vous avez choisie ?");
            int annee = entrerNombre(1)[0];
            Console.WriteLine("Quelles est le mois que vous avez choisie ?");
            int mois = entrerNombre(1)[0];
            Console.WriteLine("Quelles est le jour que vous avez choisie ?");
            int jour = entrerNombre(1)[0];
            Console.WriteLine("Quelles est l'heure que vous avez choisie ?");
            int heure = entrerNombre(1)[0];
            Console.WriteLine("Quelles est la minute que vous avez choisie ?");
            int min = entrerNombre(1)[0];
            Console.WriteLine("Quelles est la seconde que vous avez choisie ?");
            int sec = entrerNombre(1)[0];
            try
            {
                DateTime userDate = new DateTime(annee, mois, jour, heure, min, sec);
                IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
                string[] dateFstr = userDate.GetDateTimeFormats('F', culture);
                Console.WriteLine(dateFstr[0]);
            }
            catch
            {
                Console.WriteLine("Vous n'avez pas rentre une date correcte.");
            }
        }

        static void dateToDay()
        {
            Console.WriteLine("Voilà la date du jour :");
            DateTime dateNow = DateTime.Now;
            IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
            string[] dateFstr = dateNow.GetDateTimeFormats('F', culture);
            string[] dateGstr = dateNow.GetDateTimeFormats('g', culture);
            Console.WriteLine(dateFstr[0]);
            Console.WriteLine(dateGstr[5]);
        }

        static void diamand()
        {
            Console.WriteLine("Je vais afficher un diamand...");
            int nombre = entrerNombre(1)[0];
            for (int i = 0; i <= nombre; i++)
            {
                for (int k = nombre - i; 0 < k; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < nombre; i++)
            {
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < nombre - i - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }

        static void piramide()
        {
            Console.WriteLine("Je vais afficher une piramide.");
            char lettre;
            int nombre;

            Console.WriteLine("donner une lettre :");
            lettre = Console.ReadKey().KeyChar;
            Console.Write("\n");
            nombre = entrerNombre(1)[0];
            for (int i = 0; i <= nombre; i++)
            {
                for (int k = nombre - i; 0 < k; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(lettre + " ");
                }
                Console.Write("\n");
            }
        }

        static void triangle()
        {
            Console.WriteLine("Je vais afficher un triangle.");
            char lettre;
            int nombre;

            Console.WriteLine("donner une lettre :");
            lettre = Console.ReadKey().KeyChar;
            Console.Write("\n");
            nombre = entrerNombre(1)[0];

            for (int i = 0; i <= nombre; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(lettre);
                }
                Console.Write("\n");
            }
        }

        static void tablesMultiplication()
        {
            Console.WriteLine("Voilà les table de multiplication : ");
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine("table de " + i);
                for (int j = 0; j <= 10; ++j)
                {
                    Console.WriteLine(j + " * " + i + " = " + i * j);
                }
                Console.WriteLine();
            }
        }

        static void dixChiffre()
        {
            Console.WriteLine("Voilà 10 chiffre...");
            for (int i = 0; i < 10; ++i)
            {
                Console.Write(i + " ");
            }
        }

        static void formul()
        {
            Console.WriteLine("Une opération vas être réaliser.");
            int n1, n2;
            char operation;
            n1 = entrerNombre(1)[0];
            Console.WriteLine("Rentrer un charactères opératoire :");
            operation = Console.ReadKey().KeyChar;
            Console.Write("\n");
            n2 = entrerNombre(1)[0];
            int result = 0;
            switch (operation)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                default:
                    Console.WriteLine("Vous n'avez pas rentrer un signe opératoire.");
                    break;
            }
            Console.WriteLine(n1 + operation.ToString() + n2 + "=" + result);
        }

        static void blockUser()
        {
            Console.WriteLine("Essaye de rentrer le bon password : ");
            string password = "42";
            bool pass = false;
            int essaie = 0;
            string motPassword;
            do
            {
                essaie++;
                motPassword = Console.ReadLine();
                if (motPassword.Equals(password))
                {
                    Console.WriteLine("Bravos ! C'est le bon password !\n Tien un croissant pour te féliciter : \n" +
                        "    ____                                    ?~~bL \n" +
                        "  z@~ b                                    |  `U, \n" +
                        " ]@[  |                                   ]'  z@' \n" +
                        " d@~' `|, .__     _----L___----, __, .  _t'   `@j \n" +
                        "`@L_,   \"-~ `--\"~-a,           `C.  ~\"\"O_    ._`@ \n" +
                        " q@~'   ]P       ]@[            `Y=,   `H+z_  `a@ \n" +
                        " `@L  _z@        d@               Ya     `-@b,_a' \n" +
                        "  `-@d@a'       )@[               `VL      `a@@' \n" +
                        "    aa~'   ],  .a@'                qqL  ), ./~ \n" +
                        "    @@_  _z~  _d@[                 .V@  .L_d' \n" +
                        "     \"~@@@'  ]@@@'        __      )@n@bza@-\" \n" +
                        "       `-@zzz@@@L        )@@z     ]@@=%-\" \n" +
                        "         \"~~@@@@@bz_    _a@@@@z___a@K\" \n" +
                        "             \"~-@@@@@@@@@@@@@@@@@@~\" \n" +
                        "                `~~~-@~~-@@~~~~~'  ");
                    pass = true;
                }
                else
                {
                    Console.WriteLine("Ce n'est pas le bon mot de passe, réessaye :");
                }
            } while (!pass && essaie < 3);
            if (!pass)
            {
                Console.WriteLine("Tu n'a pas trouver le mdp ! Tu est BLOQUER !!!\n Tien, un croissant comme lot de consolation :\n" +
                        "    ____                                    ?~~bL \n" +
                        "  z@~ b                                    |  `U, \n" +
                        " ]@[  |                                   ]'  z@' \n" +
                        " d@~' `|, .__     _----L___----, __, .  _t'   `@j \n" +
                        "`@L_,   \"-~ `--\"~-a,           `C.  ~\"\"O_    ._`@ \n" +
                        " q@~'   ]P       ]@[            `Y=,   `H+z_  `a@ \n" +
                        " `@L  _z@        d@               Ya     `-@b,_a' \n" +
                        "  `-@d@a'       )@[               `VL      `a@@' \n" +
                        "    aa~'   ],  .a@'                qqL  ), ./~ \n" +
                        "    @@_  _z~  _d@[                 .V@  .L_d' \n" +
                        "     \"~@@@'  ]@@@'        __      )@n@bza@-\" \n" +
                        "       `-@zzz@@@L        )@@z     ]@@=%-\" \n" +
                        "         \"~~@@@@@bz_    _a@@@@z___a@K\" \n" +
                        "             \"~-@@@@@@@@@@@@@@@@@@~\" \n" +
                        "                `~~~-@~~-@@~~~~~'  ");
            }
        }

        static void jourSemaine()
        {
            Console.WriteLine("Je vous donne le jour correspondant.");
            int[] nombres = new int[1];
            nombres = entrerNombre(1);
            int date = nombres[0];
            string[] semaine = new string[] { "Dimanche", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" };
            date = date % 7;
            Console.WriteLine("Le " + (date == 0 ? 7 : date) + " jour de la semaine (reporter sur 7 avec un modulo si le nombre était trop grand) est un :\n " + semaine[date]);
        }
        
        static void convertionCToKAndF()
        {
            Console.WriteLine("Je convertit les °C en °F et °K.");
            int[] nombres = new int[1];
            nombres = entrerNombre(1);
            int celcius = nombres[0];
            Console.WriteLine(celcius + "°C = " + (celcius + 273.15) + "°K");
            Console.WriteLine(celcius + "°C = " + (celcius * 1.8 + 32) + "°F");
        }

        static void paireOuImpaire()
        {
            Console.WriteLine("Je vais vous dire si votre nombre est paire ou impaire.");
            int[] nombres = new int[1];
            nombres = entrerNombre(1);
            if (nombres[0] % 2 == 0)
            {
                Console.WriteLine("Le nombre est paire.");
            }
            else
            {
                Console.WriteLine("Le nombre est impaire.");
            }
        }

        static void positifOuNegatif()
        {
            Console.WriteLine("Je vais vous dire si votre nombre est positif ou négatif.");
            int[] nombres = new int[1];
            nombres = entrerNombre(1);
            if (nombres[0] < 0)
            {
                Console.WriteLine("Le nombre est négatif.");
            }
            else
            {
                Console.WriteLine("Le nombre est positif.");
            }
        }

        static void max()
        {
            Console.WriteLine("Vous allez devoir rentrer 4 nombres.");
            int[] nombres = new int[4];
            nombres = entrerNombre(4);
            Console.WriteLine("Le plus grand nombre est : " + nombres.Max());
        }

        static void moyenne()
        {
            Console.WriteLine("Petit calcul de moyenne.");
            int[] nombres = new int[4];
            nombres = entrerNombre(4);
            Console.WriteLine("La moyenne est : " + nombres.Average());
        }

        static void operation()
        {
            Console.WriteLine("Différente opération vont être exécuter sur les nombre entrer.");
            int[] nombres = new int[2];
            nombres = entrerNombre(2);
            Console.WriteLine("addition : " + (nombres[0] + nombres[1]));
            Console.WriteLine("soustraction : " + (nombres[0] - nombres[1]));
            Console.WriteLine("multiplication : " + (nombres[0] * nombres[1]));
            Console.WriteLine("division entère sans reste : " + (nombres[0] / nombres[1]));
        }

        static void invertionVar()
        {
            Console.WriteLine("On inverse les variable... Ce n'est pas très visuel.");
            int a = 3;
            int b = 5;
            int c;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

        static void nombreEqual()
        {
            Console.WriteLine("Entrer 2 nombre, nous allons vérifier si il sont égaux.");
            int[] nombres = new int[2];
            nombres = entrerNombre(2);
            if (nombres[0] == nombres[1])
            {
                Console.WriteLine("Les 2 nombres sont égaux.");
            }
            else
            {
                Console.WriteLine("Les 2 nombres sont diférent.");
            }
        }

        static void mots()
        {
            Console.WriteLine("Entrer 3 mots :");
            string[] mots = new string[3];
            for (int i = 0; i < 3; i++)
            {
                mots[i] = Console.ReadLine();
            }
            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine(mots[i]);
            }
        }

        static int[] entrerNombre(int nombreDeNombre)
        {
            string[] mots = new string[nombreDeNombre];
            int[] nombres = new int[nombreDeNombre];
            bool pasDeFautes = true;

            for (int i = 0; i < nombreDeNombre; i++)
            {
                Console.WriteLine("Rentrer un nombre : ");
                do
                {

                    mots[i] = Console.ReadLine();
                    if (int.TryParse(mots[i], out nombres[i]))
                    {
                        pasDeFautes = true;
                    }
                    else
                    {
                        pasDeFautes = false;
                        Console.WriteLine("Un nombre ne contient que des chiffres et pas de virgule, rééssayer : ");
                    };
                } while (!pasDeFautes);
            }
            return nombres;
        }

        # endregion
    }
}