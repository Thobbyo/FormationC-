using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class PersonneTests
    {
        [TestMethod()]
        public void invPrenomTest()
        {
            Personne p = new Personne("Pierre", "Paul", "03/02/1997");
            p.invPrenom();
            Assert.AreEqual(p.prenom, "luaP") ;
        }
    }
}