using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using HimLettersWCFService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HimLettersWCFServiceTests
{
    [TestClass]
    public class UnitTestServiceLetterType
    {
        /// <summary> 
        /// Test method to test ServiceLetterType
        /// </summary> 
        [TestMethod]
        public void TestMethodServiceLetterType()
        {
            WebClient proxy = new WebClient();
            byte[] data = proxy.DownloadData("http://localhost:49962/ServiceLetterType.svc/getlettertypelist");
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<getLetterTypeList_Result>));
            List<getLetterTypeList_Result> srp = obj.ReadObject(stream) as List<getLetterTypeList_Result>;
            
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
        }
    }
}
