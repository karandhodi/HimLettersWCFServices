using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HimLettersWCFService
{
    /// <summary> 
    /// Test method to test ServicePhysician
    /// </summary>
    [TestClass]
    public class UnitTestServicePhysicianMethod
    {
        [TestMethod]
        public void TestMethodServicePhysicianMethod()
        {
            ServicePhysician obj = new ServicePhysician();
            List<getPhysiciansList_Results> srp = obj.GetPhysicianList("1","1");

            Assert.AreEqual(srp[0].Email, "aryanbatra1991@gmail.com");
            Assert.AreEqual(srp[0].Fax, "12345");
            Assert.AreEqual(srp[0].Name, "Pargat, Akash");

            Assert.AreNotEqual(srp[0].Email, "karandhodi1996@gmail.com");
            Assert.AreNotEqual(srp[0].Fax, "12");
            Assert.AreNotEqual(srp[0].Name, "Dhodi, Karan");
        }
    }
}