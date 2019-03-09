using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Eleve
    {
        public string nom { get; set; }
        private int Age;

        public int age
        {
            get { return Age; }
            set {
                if(value < 18 || value > 26)
                {
                    throw new InvalidAgeException();
                }
                else
                {
                    Age = value;
                }
            }
        }

        private int Moyenne;

        public int moyenne
        {
            get { return Moyenne; }
            set {
                if (value < 0 || value > 20)
                {
                    throw new InvalidNoteException();
                }
                else
                {
                    Moyenne = value;
                }
            }
        }

        public Eleve(string nom, int age, int note)
        {
            this.nom = nom;
            this.age = age;
            this.moyenne = note;
        }

    }
}
