using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModele.ViewModels
{
    public class ViewModeleAddArticle:ViewModeleBase
    {
        public ViewModeleAddArticle (Action<ViewModeleBase> action) : base(action) { }

        private string _nomAuteur;

        public string nomAuteur
        {
            get { return _nomAuteur; }
            set { _nomAuteur = value; }
        }

        private string _nomSujet;

        public string nomSujet
        {
            get { return _nomSujet; }
            set { _nomSujet = value; }
        }

        private string _contentArticle;

        public string contentArticle
        {
            get { return _contentArticle; }
            set { _contentArticle = value; }
        }


        public ICommand addArticle
        {
            get
            {
                return new RelayCommand(param =>
                {
                    wikyEntities context = new wikyEntities();
                    ARTICLE article = new ARTICLE();
                    article.auteur = nomAuteur;
                    article.theme = nomSujet;
                    article.contenue = contentArticle;
                    article.date = DateTime.Now;
                    ARTICLE newArt = context.ARTICLE.Add(article);
                    context.SaveChanges();
                    ChangeUserControl(new ViewModeleDetailArticle(newArt.id));
                });
            }
        }
    }
}
