using Modele;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModele.ViewModels
{
    public class ViewModeleListArticle:ViewModeleBase
    {
        public ViewModeleListArticle(Action<ViewModeleBase> action) : base(action)
        {
            wikyEntities context = new wikyEntities();
            listArticle = new ObservableCollection<ARTICLE>(context.ARTICLE);
        }

        private ObservableCollection<ARTICLE> _listArticle;

        public ObservableCollection<ARTICLE> listArticle
        {
            get { return _listArticle; }
            set { _listArticle = value; }
        }
        
        public ICommand detailArticleCommande
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ChangeUserControl(new ViewModeleDetailArticle((int)param));
                });
            }
        }
    }
}
