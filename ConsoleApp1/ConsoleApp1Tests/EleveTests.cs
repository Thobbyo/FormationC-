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
    public class EleveTests
    {
        [TestMethod()]
        [ExpectedException(typeof(InvalidNoteException))]
        public void EleveTestNote()
        {
            Eleve e = new Eleve("pierre", 18, 28);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidAgeException))]
        public void EleveTestAge()
        {
            Eleve e = new Eleve("pierre", 17, 17);
        }
    }
}