using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HimLettersWCFService
{
    [TestClass]
    public class UnitTestServiceLetterTypeMethod
    {
        /// <summary> 
        /// Test method to test ServiceLetterType
        /// </summary>
        [TestMethod]
        public void TestMethodServiceLetterTypeMethod()
        {
            ServiceLetterType obj = new ServiceLetterType();
            List<getLetterTypeList_Results> srp = obj.GetLetterTypeList();

            Assert.AreEqual(srp[0].Id, 1);
            Assert.AreEqual(srp[0].Name, "Ashok_1_delinquent");
            Assert.AreEqual(srp[1].Id, 2);
            Assert.AreEqual(srp[1].Name, "Ashok_104_DocumentLetter");
            Assert.AreEqual(srp[2].Id, 3);
            Assert.AreEqual(srp[2].Name, "Ashok3_Suspended");
            Assert.AreEqual(srp[3].Id, 4);
            Assert.AreEqual(srp[3].Name, "Suspension Letter");
            Assert.AreEqual(srp[4].Id, 5);
            Assert.AreEqual(srp[4].Name, "Reminder Letter");

            Assert.AreNotEqual(srp[0].Name, "Ashok delinquent");
            Assert.AreNotEqual(srp[1].Name, "Ashok DocumentLetter");
            Assert.AreNotEqual(srp[2].Name, "Ashok3 Suspended");
        }

    }
}