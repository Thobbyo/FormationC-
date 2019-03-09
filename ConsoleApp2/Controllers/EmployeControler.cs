using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Business;
using Business.Contracts;

namespace Controllers
{
    public class EmployeControler
    {
        IBuisinessEmploye EmployeBuisiness { get; }
        public EmployeControler(IBuisinessEmploye employeBuisiness)
        {
            EmployeBuisiness = employeBuisiness;
        }

        public string addUser(string nom, string prenom, string salaire)
        {
            int salaireR;
            if (int.TryParse(salaire, out salaireR))
            {
                EmployeBuisiness.addUser(nom, prenom, salaireR);
            }
            else
            {
                return "Il y a eu un problème dans les champs rentrer.";
            }
            return "";
        }

        public string dispUser(string id)
        {
            int idR;
            if (int.TryParse(id, out idR))
            {
                return EmployeBuisiness.dispUser(idR);
            }
            else
            {
                return "Il y a eu un problème dans les champs rentrer.";
            }
        }

        public string dispAllUser()
        {
            return EmployeBuisiness.dispAllUser();
        }

    }
}
