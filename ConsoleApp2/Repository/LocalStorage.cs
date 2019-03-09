using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repository.Contracts;

namespace Repository
{
    public sealed class LocalStorage : IEmployeRepository
    {
        public List<Employe> ListesEmploye { get; set; }

        public LocalStorage() {
            this.ListesEmploye = new List<Employe>();
        }

        public void add(Employe emp)
        {
            this.ListesEmploye.Add(emp);
        }

        public string findById(int id)
        {
            var req = from emp in this.ListesEmploye where emp.Id == id select emp ;
            return this.ToString(req.ToList());
        }

        public string ToString(List<Employe> emplo = null)
        {
            if(emplo == null)
            {
                emplo = this.ListesEmploye;
            }
            StringBuilder strb = new StringBuilder();

            foreach (Employe emp in emplo)
            {
                strb.Append(emp.ToString());
                strb.Append('\n');
                strb.Append('-', 20);
                strb.Append('\n');
            }

            return strb.ToString();
        }
    }
}
