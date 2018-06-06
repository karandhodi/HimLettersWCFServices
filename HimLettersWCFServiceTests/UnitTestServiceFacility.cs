using HimLettersWCFService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;

namespace HimLettersWCFServiceTests
{
    [TestClass]
    public class UnitTestServiceFacility
    {
        /// <summary> 
        /// Test method to test ServiceFacility
        /// </summary> 
        [TestMethod]
        public void TestMethodServiceFacility()
        {
            WebClient proxy = new WebClient();
            byte[] data = proxy.DownloadData("http://localhost:49962/ServiceFacility.svc/getfacility");
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<getFacility_Result>));
            List<getFacility_Result> srp = obj.ReadObject(stream) as List<getFacility_Result>;
            Assert.AreEqual(srp[0].Id, 1);
            Assert.AreEqual(srp[0].Facility_Name, "Facility A");
            Assert.AreEqual(srp[1].Id, 2);
            Assert.AreEqual(srp[1].Facility_Name, "Facility B");
            Assert.AreEqual(srp[2].Id, 3);
            Assert.AreEqual(srp[2].Facility_Name, "Facility C");
            Assert.AreEqual(srp[3].Id, 4);
            Assert.AreEqual(srp[3].Facility_Name, "Facility D");
        }
    }
}
