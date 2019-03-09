using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalDll.Class
{
    [Serializable]
    public class Voiture : Vehicule
    {
        private int _puissance;
        public int Puissance
        {
            get { return _puissance; }
            set {
                if(value >= 0)
                {
                    _puissance = value;
                }
                else
                {
                    _puissance = 0;
                }
            }
        }

        public Voiture(string marque, string modele, int puissance) : base(marque, modele)
        {
            this.Puissance = puissance;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPuissance : {this.Puissance}";
        }
    }
}
