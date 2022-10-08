using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegApp;
using System;

namespace RegAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            string actual = User.TestPassword("123Dd@!");
                       
            string expected = "Пароль нормальный";

            Assert.AreEqual(expected,actual);
        }
    }
}
