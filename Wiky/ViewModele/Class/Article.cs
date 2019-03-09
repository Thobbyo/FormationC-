using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModele.Class
{
    class Article
    {
        public Article(string emetteur, string sujet, DateTime date)
        {
            articleDate = date;
            articleEmetteur = emetteur;
            articleSujet = sujet;
        }

        public Article(ARTICLE art)
        {
            articleDate = art.date;
            articleEmetteur = art.auteur;
            articleSujet = art.theme;
        }

        private string _articleEmetteur;

        public string articleEmetteur
        {
            get { return _articleEmetteur; }
            set { _articleEmetteur = value; }
        }

        private DateTime? _articleDate;

        public DateTime? articleDate
        {
            get { return _articleDate; }
            set { _articleDate = value; }
        }

        private string _articleSujet;

        public string articleSujet
        {
            get { return _articleSujet; }
            set { _articleSujet = value; }
        }


    }
}
