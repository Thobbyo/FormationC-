using Repository.Contracts;
using Entities;
using System.Collections.Generic;

namespace Business.Tests
{
    internal class MockStorage : IEmployeRepository
    {
        private List<Employe> listEmp = new List<Employe>() { new Employe("0", "00", 10), new Employe("1", "01", 11) };

        public void add(Entities.Employe emp)
        {
            listEmp.Add(emp);
        }

        public string findById(int id)
        {
            return id.ToString();
        }

        public string ToString(System.Collections.Generic.List<Entities.Employe> emplo = null)
        {
            return "-1";
        }
    }
}