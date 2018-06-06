using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HimLettersWCFService
{
    [TestClass]
    public class UnitTestServiceLetterDetailsMethod
    {
        /// <summary> 
        /// Test method to test ServiceLetterDetails
        /// </summary>
        [TestMethod]
        public void TestMethodServiceLetterDetailsMethod()
        {
            ServiceLetterDetails obj = new ServiceLetterDetails();
            List<getLetterDetail_Results> srp = obj.GetLetterDetails("2");

            Assert.AreEqual(srp[0].Chart_On_Hold, "Yes");
            Assert.AreEqual(srp[0].Charts_To_Include, "All");
            Assert.AreEqual(srp[0].Deficiencies_To_Include, null);
            Assert.AreEqual(srp[0].Deficient_Day_Range_End, "10");
            Assert.AreEqual(srp[0].Deficient_Day_Range_Start, "10");
            Assert.AreEqual(srp[0].Include_Documents, null);
            Assert.AreEqual(srp[0].Include_Visits, "Delinquent");
            Assert.AreEqual(srp[0].Physicians_To_Include, "All");

            Assert.AreNotEqual(srp[0].Chart_On_Hold, "No");
            Assert.AreNotEqual(srp[0].Deficiencies_To_Include, "Yes");
            Assert.AreNotEqual(srp[0].Deficient_Day_Range_End, "100");
            Assert.AreNotEqual(srp[0].Deficient_Day_Range_Start, "110");
        }
    }
}