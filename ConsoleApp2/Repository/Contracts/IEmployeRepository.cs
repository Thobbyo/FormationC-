using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repository.Contracts
{
    public interface IEmployeRepository
    {
        void add(Employe emp);

        string findById(int id);

        string ToString(List<Employe> emplo = null);
    }
}
