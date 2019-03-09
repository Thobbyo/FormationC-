using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpfExercice.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #region EXO 1, 2, 3, 4
        private string _name = "Mon NOM !!!";

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _nameUnter;

        public string NameUnter
        {
            get { return _nameUnter; }
            set
            {
                _nameUnter = value;
                OnPropertyChanged("NameUnter");
            }
        }

        public ICommand buttonCommande
        {
            get
            {
                return new RelayCommand(param =>
                {
                    Name = (string)param;
                });
            }
        }

        public ObservableCollection<string> ListString { get; set; } = new ObservableCollection<string> { "test1", "test2", "test3" };

        #endregion

        #region EXO 5

        public ObservableCollection<string> ListeNom { get; set; } = new ObservableCollection<string>();

        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set
            {
                _nom = value;
                OnPropertyChanged("Nom");
            }
        }

        private int _index;

        public int Index
        {
            get { return _index; }
            set
            {
                _index = value;
                OnPropertyChanged("Index");
            }
        }

        public ICommand addNom
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListeNom.Add((string)param);
                });
            }
        }

        public ICommand updateNom
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListeNom[Index] = (string)param;
                });
            }
        }

        public ICommand deleteNom
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListeNom.RemoveAt(ListeNom.IndexOf((string)param));
                }, param => { return ListeNom.Count > 0 && ListeNom.Contains((string)param); });
            }
        }

        #endregion

        #region EXO 6

        public ObservableCollection<Message> ListMessage { get; set; } = new ObservableCollection<Message>();

        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        private Message _selectMessage;

        public Message SelectMessage
        {
            get { return _selectMessage; }
            set
            {
                if(value != null)
                {
                    Text = value.Contenu;
                }
                _selectMessage = value;
                OnPropertyChanged("SelectMessage");
            }
        }

        public ICommand updateMessage
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListMessage[Index].Contenu = (string)param;
                });
            }
        }

        public ICommand addMessage
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListMessage.Add(new Message((string)param));
                });
            }
        }

        public ICommand deleteMessage
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListMessage.RemoveAt(Index);
                }, param => { return ListMessage.Count > 0 && Index >= 0; });
            }
        }

        #endregion
    }
}
