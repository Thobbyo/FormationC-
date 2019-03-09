using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ProjetFinalDll.Class;
using ProjetFinalDll.Exceptions;

namespace ProjetFinal.Class
{
    public static class Sauvegarde
    {
        public static List<Vehicule> list { get; set; } = new List<Vehicule>();

        /// <summary>
        /// Fonction pour ajouter un véhicule.
        /// </summary>
        /// <param name="vehic" type="Vehicule">Vehicule à ajouter</param>
        /// <returns>string du numéro du véhicule</returns>
        public static string AddVehicule(Vehicule vehic)
        {
            list.Add(vehic);
            return vehic.Numero;
        }

        /// <summary>
        /// Fonction qui suprimme un véhicule
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string DelVehicule(string num)
        {
            string retour = "";
            var req = (from nume in list where nume.Numero == num select nume).FirstOrDefault();
            if (req == null)
            {
                return "Il n'y a pas de véhicule portant ce numéro.";
            }
            bool res = false;
            res = list.Remove(req);

            if (res)
            {
                retour = $"Le véhicule n°{num} à bien été suprimer";
            }
            else if (!res)
            {
                retour = $"Le véhicule n°{num} n'existe pas.";
            }

            return retour;
        }

        /// <summary>
        /// Fonction qui modifie un véhicule
        /// </summary>
        /// <param name="num">Numéro du véhicul</param>
        /// <param name="value">nouvelle valeurs du paramètres</param>
        /// <param name="atribu">Nom de la propriété à modifier</param>
        /// <returns>string</returns>
        public static string updateVehicule(string num, string value, string atribu)
        {
            var req = (from nume in list where nume.Numero == num select nume).ToList();

            foreach (Vehicule item in req)
            {
                try
                {
                    if (atribu == "marque")
                    {
                        item.Marque = value;
                    }
                }
                catch (ErreurMarqueVehicule err)
                {
                    return err.Message;
                }
                if (atribu == "modele")
                {
                    item.Modele = value;
                }
                //try
                //{
                if (atribu == "poid")
                {
                    ((Camion)item).Poids = int.Parse(value);
                }
                if (atribu == "puissance")
                {
                    ((Voiture)item).Puissance = int.Parse(value);
                }
                //}catch(Exception)
                //{
                //    return "Value doit être un nombre.";
                //}
            }
            return "L'élément à bien été modifier";
        }

        /// <summary>
        /// Fonction qui récupère la liste des véhicule selon un paramètres
        /// </summary>
        /// <param name="func">fonction qui renvoi le tableau des élément à afficher</param>
        /// <returns>string</returns>
        public static string findVehicule(string motCle, Func<string, List<Vehicule>, List<Vehicule>> func)
        {
            return toString(func(motCle, list));
        }

        /// <summary>
        /// Fonction qui set la list triée
        /// </summary>
        /// <param name="func">Fonction qui renvoie la liste trier</param>
        /// <returns>string de resultat</returns>
        public static string sortVehicule(Func<List<Vehicule>, List<Vehicule>> func)
        {
            list = func(list);
            return "La list à été trier";
        }

        /// <summary>
        /// Fonction qui sauvergarde la liste des Vehicule
        /// </summary>
        /// <param name="path">Chemin ou enregistrer le fichier</param>
        /// <returns>string de resultat</returns>
        internal static string saveVehicule(string path)
        {
            try
            {
                using (var stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                { // Memory to Disk
                    var binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, list);
                }
            }
            catch (Exception)
            {
                return "Une erreur est survenue.";
            }
            return "La liste à bien été enregistrer.";
        }

        /// <summary>
        /// Fonction qui récupère le fichier et le met dans une liste
        /// </summary>
        /// <param name="path">Chemin ou est enregistrer le fichier</param>
        /// <returns>string de resultat</returns>
        internal static string importVehicule(string path)
        {
            try
            {
                using (var fileStreamRead = new FileStream(path, FileMode.Open, FileAccess.Read))
                {// Disk to memory
                    var binaryFormatter = new BinaryFormatter();
                    list = binaryFormatter.Deserialize(fileStreamRead) as List<Vehicule>;
                }
                var reqMax = (from vec in list select vec.Numero).Max();
                Vehicule.getNum = int.Parse(reqMax) + 1;
            }
            catch (Exception)
            {
                return "Une erreur est survenue.";
            }
            return "La fichier à bien été récupérer.";
        }

        /// <summary>
        /// Fonction qui renvoie la liste des éléments sous forme de string
        /// </summary>
        /// <returns>string</returns>
        public static string toString(List<Vehicule> vehicules = null)
        {
            if (vehicules == null)
            {
                vehicules = list;
            }
            StringBuilder str = new StringBuilder();
            if (vehicules.Count == 0)
            {
                return "Il n'y a pas de véhicule.";
            }
            foreach (Vehicule vec in vehicules)
            {
                str.AppendLine(vec.ToString());
                // On sapare les véhicule entre eux.
                str.Append('-', 20);
                str.Append('\n');
            }
            return str.ToString();
        }

        /// <summary>
        /// Fonction qui renvoie la string d'un véhicule.
        /// </summary>
        /// <param name="num">string du numéro de véhicule</param>
        /// <returns>string</returns>
        public static string toString(string num)
        {
            var req = from nume in list where nume.Numero == num select nume;

            StringBuilder str = new StringBuilder();

            if (req.Count() == 0)
            {
                return "Il n'y a pas de véhicule portant ce numéro.";
            }
            foreach (Vehicule vec in req)
            {
                str.AppendLine(vec.ToString());
                // On sapare les véhicule entre eux.
                str.Append('-', 20);
                str.Append('\n');
            }
            return str.ToString();
        }

        /// <summary>
        /// Fonction qui renvoie le type du véhicule du numéro passer en paramètres
        /// </summary>
        /// <param name="num" type="string">string du numéro de vehicule</param>
        /// <returns>char, c pour camion et v pour voiture</returns>
        internal static char getType(string num)
        {
            var req = from nume in list where nume.Numero == num select nume;

            char res = ' ';

            foreach (Vehicule vec in req)
            {
                if (vec is Voiture)
                {
                    res = 'v';
                }
                if (vec is Camion)
                {
                    res = 'c';
                }
            }
            return res;
        }

    }
}
