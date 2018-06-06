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
    public class UnitTestServicePhysician
    {
        /// <summary> 
        /// Test method to test ServicePhysician
        /// </summary>
        [TestMethod]
        public void TestMethodServicePhysician()
        {
            WebClient proxy = new WebClient();
            byte[] data = proxy.DownloadData("http://localhost:49962/ServicePhysician.svc/getPhysiciansList/1/1");
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<getPhysiciansList_Result>));
            List<getPhysiciansList_Result> srp = obj.ReadObject(stream) as List<getPhysiciansList_Result>;
            Assert.AreEqual(srp[0].Email, "aryanbatra1991@gmail.com");
            Assert.AreEqual(srp[0].Fax, "12345");
            Assert.AreEqual(srp[0].Name, "Pargat, Akash");
        }
    }
}
