using ConsoleApp3.Interface;
using ConsoleApp3.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Controler : IControler
    {
        IBDDExec BDDExec { get; }
        public Controler(IBDDExec bDDExec)
        {
            BDDExec = bDDExec;
        }

        public string addClient(string nom, string prenom, string birth, string adresse, string cPostal, string ville)
        {
            string req = $"insert into CLIENT Values ('{nom}', '{prenom}', '{birth}', '{adresse}', '{cPostal}', '{ville}');";
            return BDDExec.execReqIUC(req);
        }

        public string addLocation(string NB_KM, string DATE_DEBUT, string DATE_FIN, string CLIENT, string VEHICULE)
        {
            string req = $"insert into CLIENT Values ('{NB_KM}', '{DATE_DEBUT}', '{DATE_FIN}', '{CLIENT}', '{VEHICULE}');";
            return BDDExec.execReqIUC(req);
        }

        public string delete(string t, string id)
        {
            return BDDExec.execReqIUC($"DELETE FROM {t} WHERE id = {id};");
        }

        public string display(string t, string id)
        {
            return BDDExec.execReq($"select * from {t} where id = {id}");
        }

        public string displayAll(string t)
        {
            return BDDExec.execReq("select * from " + t);
        }

        public string update(string t, string champs, string value, string id)
        {
            return BDDExec.execReqIUC($"UPDATE {t} SET {champs} = '{value}' WHERE id = {id};");
        }

        public string updateLoue(string t, string champs, string value, string id)
        {
            return BDDExec.execReqIUC($"UPDATE {t} SET {champs} = '{value}' WHERE id = {id};");
        }
    }
}
