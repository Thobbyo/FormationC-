using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ProjetFinalDll.Exceptions;

namespace ProjetFinalDll.Class
{
    [Serializable]
    public abstract class Vehicule
    {

        public static int getNum { get; set; }

        private string _marque;
        public string Marque {
            get {
                return _marque;
            } set {
                // Define a regular expression for check number
                Regex rx = new Regex(@"[0-9]");
                
                bool result = rx.IsMatch(value);
                if (result)
                {
                    throw new ErreurMarqueVehicule("Il ne doit pas y avoir de numéro dans la marque du vehicule");
                }
                else
                {
                    _marque = value;
                }
            }
        }
        
        public string Modele { get; set; }

        private string _numero;
        public string Numero {
            get {
                return _numero;
            }
            private set {
                if(value.Length < 4)
                {
                    _numero = value.PadLeft(4, '0');
                }
                if(value.Length > 6)
                {
                    throw new ErreurNumeroVehicule("Le numéro du vehicule est trop long.");
                }
            }
        }

        public Vehicule(string marque, string modele)
        {
            this.Marque = marque;
            this.Modele = modele;
            this.Numero = getNum.ToString();
            getNum += 1;
        }

        public override string ToString()
        {
            return $"Marque : {this.Marque}\nModele : {this.Modele}\nNumero : {this.Numero}";
        }

    }
}
