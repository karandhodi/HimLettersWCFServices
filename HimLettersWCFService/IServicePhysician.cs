using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace HimLettersWCFService
{
    [DataContract]
    public class PhysicianException
    {
        [DataMember]
        public string Title;
    }
    [ServiceContract]
    public interface IServicePhysician
    {
        [OperationContract]
        [FaultContract(typeof(PhysicianException))]
        [WebInvoke(Method = "GET", UriTemplate = "getphysicianslist/{letterTypeId}/{facilityId}", ResponseFormat = WebMessageFormat.Json)]
        List<getPhysiciansList_Results> GetPhysicianList(string letterTypeId, string facilityId);
    }
}
