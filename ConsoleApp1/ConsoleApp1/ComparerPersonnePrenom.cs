using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ComparerPersonnePrenom : IComparer<Personne>
    {
        public int Compare(Personne x, Personne y)
        {
            return x.prenom.CompareTo(y.prenom);
        }
    }
}
