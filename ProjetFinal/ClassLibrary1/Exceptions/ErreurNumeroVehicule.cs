using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalDll.Exceptions
{
    public class ErreurNumeroVehicule : Exception
    {
        public ErreurNumeroVehicule(string mess) : base(mess) { }
    }
}
