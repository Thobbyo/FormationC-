using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModele.ViewModels
{
    public class ViewModeleDetailArticle:ViewModeleBase
    {
        public ViewModeleDetailArticle(int index = 1)
        {
            Index = index;
            wikyEntities context = new wikyEntities();
            ARTICLE monArticle = context.ARTICLE.Find(Index);
            auteurArticle = monArticle.auteur;
            contentArticle = monArticle.contenue;
            sujetArticle = monArticle.theme;
            dateArticle = monArticle.date.ToString();
        }

        private int _index;

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        private string _content;

        public string contentArticle
        {
            get { return _content; }
            set { _content = value; }
        }

        private string _sujet;

        public string sujetArticle
        {
            get { return _sujet; }
            set { _sujet = value; }
        }

        private string _date;

        public string dateArticle
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _auteur;

        public string auteurArticle
        {
            get { return _auteur; }
            set { _auteur = value; }
        }
    }
}
