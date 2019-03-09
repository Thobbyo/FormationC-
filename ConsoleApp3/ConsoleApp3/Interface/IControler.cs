using ConsoleApp3.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Interface
{
    public interface IControler
    {
        string display(string t, string id);
        string displayAll(string t);
        string addClient(string nom, string prenom, string birth, string adresse, string cPostal, string ville);
        string addLocation(string NB_KM, string DATE_DEBUT, string DATE_FIN, string CLIENT, string VEHICULE);
        string update(string t, string champs, string value,  string id);
        string delete(string t, string id);
        string updateLoue(string t, string champs, string value, string id);
    }
}
