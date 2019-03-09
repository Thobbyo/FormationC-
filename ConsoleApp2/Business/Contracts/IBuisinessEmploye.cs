using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contracts
{
    public interface IBuisinessEmploye
    {
        void addUser(string nom, string prenom, int salaire);
        string dispUser(int id);
        string dispAllUser();
    }
}
