using ConsoleApp3.ADO.NET;
using ConsoleApp3.Interface;
using ConsoleApp3.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Class.Controler
{
    class ControlerEntity : IControler
    {
        IBDDExec BDDExec { get; }
        public ControlerEntity(IBDDExec bDDExec)
        {
            BDDExec = bDDExec;
        }

        public string addClient(string nom, string prenom, string birth, string adresse, string cPostal, string ville)
        {
            ADO.NET.Client client = new ADO.NET.Client { Nom = nom, prenom = prenom, Date_naissance = DateTime.Parse(birth), adresse = adresse, code_postal = cPostal, ville = ville };
            exerciceLocationEntities context = new exerciceLocationEntities();
            context.Client.Add(client);
            return context.SaveChanges().ToString();
        }

        public string addLocation(string NB_KM, string DATE_DEBUT, string DATE_FIN, string CLIENT, string VEHICULE)
        {
            ADO.NET.LOUE location = new ADO.NET.LOUE { NB_KM = int.Parse(NB_KM), DATE_DEBUT = DateTime.Parse(DATE_DEBUT), DATE_FIN = DateTime.Parse(DATE_FIN), CLIENT = int.Parse(CLIENT), VEHICULE = int.Parse(VEHICULE) };
            exerciceLocationEntities context = new exerciceLocationEntities();
            context.LOUE.Add(location);
            return context.SaveChanges().ToString();
        }

        public string delete(string t, string ids)
        {
            int id = int.Parse(ids);
            exerciceLocationEntities context = new exerciceLocationEntities();
            if (t.ToLower() == "client")
            {
                context.Client.Remove(context.Client.Find(id));
            }
            else
            {
                context.LOUE.Remove(context.LOUE.Find(id));
            }
            return context.SaveChanges().ToString();
        }

        public string display(string t, string ids)
        {
            int id = int.Parse(ids);
            exerciceLocationEntities context = new exerciceLocationEntities();
            if (t.ToLower() == "client")
            {
                var req = (from c in context.Client where c.ID == id select c).FirstOrDefault();
                return $"{req.Nom} - {req.prenom} - {req.Date_naissance} - {req.adresse} - {req.code_postal} - {req.ville}";
            }
            else
            {
                var req = (from c in context.LOUE where c.ID == id select c).FirstOrDefault();
                return $"{req.NB_KM} - {req.DATE_DEBUT} - {req.DATE_FIN} - {req.CLIENT} - {req.VEHICULE}";
            }
        }

        public string displayAll(string t)
        {
            StringBuilder str = new StringBuilder();
            exerciceLocationEntities context = new exerciceLocationEntities();
            if (t.ToLower() == "client")
            {
                var req = (from c in context.Client select c);
                foreach (var item in req)
                {
                    str.AppendLine($"{item.ID} - {item.Nom} - {item.prenom} - {item.Date_naissance} - {item.adresse} - {item.code_postal} - {item.ville}");
                }
            }
            else
            {
                var req = (from c in context.LOUE select c);
                foreach (var item in req)
                {
                    str.AppendLine($"{item.ID} - {item.NB_KM} - {item.DATE_DEBUT} - {item.DATE_FIN} - {item.CLIENT} - {item.VEHICULE}");
                }
            }
            return str.ToString();
        }

        public string update(string t, string champs, string value, string id)
        {
            exerciceLocationEntities context = new exerciceLocationEntities();
            ADO.NET.Client clt = context.Client.Find(int.Parse(id));
            switch (champs.ToLower())
            {
                case "nom":
                    clt.Nom = value;
                    break;
                case "prenom":
                    clt.prenom = value;
                    break;
                case "date_naissance":
                    clt.Date_naissance = DateTime.Parse(value);
                    break;
                case "adresse":
                    clt.adresse = value;
                    break;
                case "code_postal":
                    clt.code_postal = value;
                    break;
                case "ville":
                    clt.ville = value;
                    break;
            }
            return context.SaveChanges().ToString();
        }

        public string updateLoue(string t, string champs, string value, string id)
        {
            exerciceLocationEntities context = new exerciceLocationEntities();
            ADO.NET.LOUE clt = context.LOUE.Find(int.Parse(id));
            switch (champs.ToLower())
            {
                case "nb_km":
                    clt.NB_KM = int.Parse(value);
                    break;
                case "date_debut":
                    clt.DATE_DEBUT = DateTime.Parse(value);
                    break;
                case "date_fin":
                    clt.DATE_FIN = DateTime.Parse(value);
                    break;
                case "client":
                    clt.CLIENT = int.Parse(value);
                    break;
                case "vehicule":
                    clt.VEHICULE = int.Parse(value);
                    break;
            }
            return context.SaveChanges().ToString();
        }
    }
}
