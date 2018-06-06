using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HimLettersWCFService
{
    [DataContract]
    public class PhysicianAllException
    {
        [DataMember]
        public string Title;
    }

    [ServiceContract]
    public interface IServicePhysicianAll
    {
        [OperationContract]
        [FaultContract(typeof(PhysicianAllException))]
        [WebInvoke(Method = "GET", UriTemplate = "getphysicianslistall/{letterTypeId}", ResponseFormat = WebMessageFormat.Json)]
        List<getPhysiciansList_Results> GetPhysicianList(string letterTypeId);
    }
}
