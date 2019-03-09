using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employe : Personne
    {
        public int salaire { get; set; }

        public Employe(string nom, string prenom, string birthdate, int salaire) : base(nom, prenom, birthdate)
        {
            this.salaire = salaire;
        }

        public override void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return base.ToString() + $"salaire : {this.salaire}\n";
        }
    }
}
