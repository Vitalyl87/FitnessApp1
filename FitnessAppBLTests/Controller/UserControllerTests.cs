using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessAppBL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAppBL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        

        

        [TestMethod()]
        public void SetUserDataTest()
        {
            string userName = "megaNameUser";
            var controller = new UserController(userName);
            controller.SetUserData("man", DateTime.Parse("10.01.1980"), double.Parse("100"), double.Parse("190"));
            Assert.AreEqual("man", controller.CurrentUser.Gender.Name);
        }

        [TestMethod()]
        public void SaveTest()
        {
            string userName = "megaNameUser";
            var controller = new UserController(userName);

            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}