using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfExercice
{
    class Message : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string _contenu;

        public string Contenu
        {
            get { return _contenu; }
            set
            {
                _contenu = value;
                OnPropertyChanged("Contenu");
            }
        }

        private string _emetteur;

        public string Emetteur
        {
            get { return _emetteur; }
            set { _emetteur = value; }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Message(string msg)
        {
            Contenu = msg;
            Date = DateTime.Now;
            Emetteur = "TOI";
        }
    }
}
