using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectTestExample;

namespace People_Test
{
    [TestClass]
    public class UnitTest1
    {
        People people = new People("dianabaydulina", "54321", "maratovnad2Gmail.com", 79020913394);

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual("dianabaydulina", people.Login);
            
        }
        [TestMethod]
        public void GetEmailTest()
        {
            Assert.AreEqual("maratovnad2Gmail.com", people.Email);

        }

        [TestMethod]
        public void GetPhoneTest()
        {
            Assert.AreEqual(79020913394, people.Phone);

        }
        [TestMethod]
        public void GetPassTest()
        {
            Assert.AreEqual("54321", people.Pass);

        }
    }
}
