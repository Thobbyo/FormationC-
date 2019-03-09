using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Repository.Contracts;
using Business.Contracts;
using Entities;


namespace Business
{
    public class BuisnessEmploye : IBuisinessEmploye
    {
        IEmployeRepository EmployeRepository { get; }
        public BuisnessEmploye(IEmployeRepository employeRepository)
        {
            EmployeRepository = employeRepository;
        }

        public void addUser(string nom, string prenom, int salaire)
        {
            EmployeRepository.add(new Employe(nom, prenom, salaire));
        }

        public string dispUser(int id)
        {
            return EmployeRepository.findById(id);
        }

        public string dispAllUser()
        {
            return EmployeRepository.ToString();
        }
    }
}
