using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModele.ViewModels
{
    public class ViewModeleRouting : ViewModeleBase
    {

        Action<ViewModeleBase> func;

        private ViewModeleBase _currentContent = new ViewModeleDetailArticle();

        public ViewModeleRouting()
        {
            func = param => currentContent = param;
        }

        public ViewModeleBase currentContent
        {
            get { return _currentContent; }
            set
            {
                _currentContent = value;
                OnPropertyChanged("currentContent");
            }
        }

        public ICommand detailArticleCommande
        {
            get
            {
                return new RelayCommand(param =>
                {
                    currentContent = new ViewModeleDetailArticle();
                });
            }
        }

        public ICommand listArticleCommande
        {
            get
            {
                return new RelayCommand(param =>
                {
                    currentContent = new ViewModeleListArticle(func);
                });
            }
        }

        public ICommand addArticleCommande
        {
            get
            {
                return new RelayCommand(param =>
                {
                    currentContent = new ViewModeleAddArticle(func);
                });
            }
        }

    }
}
