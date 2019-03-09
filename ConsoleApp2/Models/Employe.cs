using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employe
    {
        private static int count = 0;

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Salaire { get; set; }

        public Employe(string nom, string prenom, int salaire)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Salaire = salaire;

            this.Id = count;
            count++;
        }

        public override string ToString()
        {
            return $"Id : {this.Id}\nNom : {this.Nom}\nPrenom : {this.Prenom}\nSalaire : {this.Salaire}";
        }
    }
}
