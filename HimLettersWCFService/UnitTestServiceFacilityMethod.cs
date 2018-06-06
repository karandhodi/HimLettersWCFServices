using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HimLettersWCFService
{
    [TestClass]
    public class UnitTestServiceLetterFacilityMethod
    {
        /// <summary> 
        /// Test method to test ServiceFacility
        /// </summary> 
        [TestMethod]
        public void TestMethodServiceFacilityMethod()
        {
            ServiceFacility obj = new ServiceFacility();
            List<getFacility_Results> srp = obj.GetFacility();

            Assert.AreEqual(srp[0].Id, 1);
            Assert.AreEqual(srp[0].Facility_Name, "Facility A");
            Assert.AreEqual(srp[1].Id, 2);
            Assert.AreEqual(srp[1].Facility_Name, "Facility B");
            Assert.AreEqual(srp[2].Id, 3);
            Assert.AreEqual(srp[2].Facility_Name, "Facility C");
            Assert.AreEqual(srp[3].Id, 4);
            Assert.AreEqual(srp[3].Facility_Name, "Facility D");

            Assert.AreNotEqual(srp[0].Facility_Name, "Facility B");
            Assert.AreNotEqual(srp[1].Facility_Name, "Facility C");
            Assert.AreNotEqual(srp[2].Facility_Name, "Facility D");
            Assert.AreNotEqual(srp[3].Facility_Name, "Facility A");

        }
    }
}