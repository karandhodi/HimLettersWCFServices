using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace HimLettersWCFService
{
    [DataContract]
    public class FacilityException
    {
        [DataMember]
        public string Title;
    }

    [ServiceContract]
    public interface IServiceFacility
    {
        [OperationContract]
        [FaultContract(typeof(FacilityException))]
        [WebInvoke(Method = "GET", UriTemplate = "getfacility", ResponseFormat = WebMessageFormat.Json)]
        List<getFacility_Results> GetFacility();
    }
}
