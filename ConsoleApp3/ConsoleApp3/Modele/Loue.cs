using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Modele
{
    public class Loue
    {
        public string Nb_km { get; set; }
        public string Date_debut { get; set; }
        public string Date_fin { get; set; }
        public string Client { get; set; }
        public string Vehicule { get; set; }

        public Loue(string nbkm, string date_debut, string date_fin, string client, string vehicule)
        {
            Nb_km = nbkm;
            Date_debut = date_debut;
            Date_fin = date_fin;
            Client = client;
            Vehicule = vehicule;
        }
    }
}
