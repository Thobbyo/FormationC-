using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalDll.Class
{
    [Serializable]
    public class Camion : Vehicule
    {
        private int _poids;

        public int Poids
        {
            get { return _poids; }
            set {
                if(value < 3500)
                {
                    _poids = 3500;
                }
                else
                {
                    _poids = value;
                }
            }
        }

        public Camion(string marque, string modele, int poids) : base(marque, modele)
        {
            this.Poids = poids;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPoids : {this.Poids}";
        }
    }
}
