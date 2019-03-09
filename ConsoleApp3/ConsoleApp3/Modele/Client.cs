using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Modele
{
    public class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string BirthDate { get; set; }
        public string Adresse { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }

        public Client(string nom, string prenom, string birthDate, string adresse, string cp, string ville)
        {
            Nom = nom;
            Prenom = prenom;
            BirthDate = birthDate;
            Adresse = adresse;
            CP = cp;
            Ville = ville;
        }
    }
}
