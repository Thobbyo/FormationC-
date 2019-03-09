using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModele
{
    public class ViewModeleBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ViewModeleBase(Action<ViewModeleBase> action = null)
        {
            ChangeUserControl = action;
        }

        public Action<ViewModeleBase> ChangeUserControl { get; set; }
    }
}
