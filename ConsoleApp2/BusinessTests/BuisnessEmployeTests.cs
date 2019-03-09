using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Business;
using Business.Contracts;
using Entities;


namespace Business.Tests
{
    [TestClass()]
    public class BuisnessEmployeTests
    {
        [TestMethod()]
        public void dispUserTest()
        {
            var entrepriseService = new BuisnessEmploye(new MockStorage());
            entrepriseService.addUser("TEST", "Test", 25000);
            // entrepriseService.dispUser(0);
            Assert.AreEqual("0", entrepriseService.dispUser(0));
            Assert.AreEqual("5", entrepriseService.dispUser(5));
            Assert.AreEqual("10", entrepriseService.dispUser(10));
        }

        [TestMethod()]
        public void dispAllUserTest()
        {
            var entrepriseService = new BuisnessEmploye(new MockStorage());
            Assert.AreEqual("-1", entrepriseService.dispAllUser());
        }
    }
}