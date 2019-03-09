using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Personne : ITravailleur, IEquatable<Personne>, IComparable<Personne>
    {
        public static int test { get; set; } = 0;

        public string nom { get; set; }
        public string prenom { get; set; }
        private DateTime birthdate;

        public string birthDate {
            get {
                return birthdate.GetDateTimeFormats('D')[0];
            }
            set {
                birthdate = Convert.ToDateTime(value);
            }
        }

        public Personne(string nom, string prenom, string birthDate)
        {
            Personne.test += 1;
            this.nom = nom;
            this.prenom = prenom;
            this.birthDate = birthDate;
        }

        public Personne()
        {
            Personne.test += 1;
            Console.WriteLine("Quel est votre nom ?");
            this.nom = Console.ReadLine();
            Console.WriteLine("Quel est votre prénom ?");
            this.prenom = Console.ReadLine();
            Console.WriteLine("Quel est votre date de naissance (format jj/mm/aaaa) ?");
            this.birthDate = Console.ReadLine();
        }

        private void displayPersonne()
        {
            Console.WriteLine($"nom : {this.nom}\nprenom : {this.prenom}\ndate de naissance : {this.birthDate}\nTEST : {Personne.test}\n");
        }

        public void invPrenom()
        {
            string prenomInv = "";
            for (int i = prenom.Length-1; 0 <= i; i--)
            {
                prenomInv += prenom[i];
            }
            prenom = prenomInv;
        }

        public virtual void Afficher()
        {
            displayPersonne();
        }

        public override string ToString()
        {
            return $"nom : {this.nom}\nprenom : {this.prenom}\ndate de naissance : {this.birthDate}\n";
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (!(obj is Personne))
            {
                return false;
            }
            if (this.nom == ((Personne)obj).nom && this.prenom == ((Personne)obj).prenom && this.birthDate == ((Personne)obj).birthDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(Personne other)
        {
            if (this.nom == other.nom && this.prenom == other.prenom && this.birthDate == other.birthDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CompareTo(Personne other)
        {
            return this.nom.CompareTo(other.nom);
        }
    }
}
