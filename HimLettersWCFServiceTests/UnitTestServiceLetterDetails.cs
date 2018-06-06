using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HimLettersWCFService;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace HimLettersWCFServiceTests
{
    [TestClass]
    public class UnitTestServiceLetterDetails
    {
        /// <summary> 
        /// Test method to test ServiceLetterDetails
        /// </summary>
        [TestMethod]
        public void TestMethodServiceLetterDetails()
        {
            WebClient proxy = new WebClient();
            byte[] data = proxy.DownloadData("http://localhost:49962/ServiceLetterDetails.svc/getLetterDetail/2");
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<getLetterDetail_Result>));
            List<getLetterDetail_Result> srp = obj.ReadObject(stream) as List<getLetterDetail_Result>;
            Assert.AreEqual(srp[0].Chart_On_Hold,"Yes");
            Assert.AreEqual(srp[0].Charts_To_Include, "All");
            Assert.AreEqual(srp[0].Deficiencies_To_Include, null);
            Assert.AreEqual(srp[0].Deficient_Day_Range_End, "10");
            Assert.AreEqual(srp[0].Deficient_Day_Range_Start, "10");
            Assert.AreEqual(srp[0].Include_Documents, null);
            Assert.AreEqual(srp[0].Include_Visits, "Delinquent");
            Assert.AreEqual(srp[0].Physicians_To_Include, "All");
        }
    }
}
