using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HimLettersWCFService
{
    /// <summary> 
    /// Test method to test ServicePhysicianAll
    /// </summary>
    [TestClass]
    public class UnitTestServicePhysicianAllMethod
    {
        [TestMethod]
        public void TestMethodServicePhysicianAllMethod()
        {
            ServicePhysicianAll obj = new ServicePhysicianAll();
            List<getPhysiciansList_Results> srp = obj.GetPhysicianList("1");

            Assert.AreEqual(srp[0].Email, "aryanbatra1991@gmail.com");
            Assert.AreEqual(srp[0].Fax, "12345");
            Assert.AreEqual(srp[0].Name, "Pargat, Akash");
            Assert.AreEqual(srp[1].Email, "karandhodi1996@gmail.com");
            Assert.AreEqual(srp[1].Fax, "67890");
            Assert.AreEqual(srp[1].Name, "Smith, Janel");

            Assert.AreNotEqual(srp[1].Email, "karandhodi@ymail.com");
            Assert.AreNotEqual(srp[1].Fax, "00000");
            Assert.AreNotEqual(srp[1].Name, "A, Jorge");
        }
    }
}