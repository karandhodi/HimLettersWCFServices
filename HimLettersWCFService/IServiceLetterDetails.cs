using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace HimLettersWCFService
{
    [DataContract]
    public class LetterDetailsException
    {
        [DataMember]
        public string Title;
    }

    [ServiceContract]
    public interface IServiceLetterDetails
    {
        [OperationContract]
        [FaultContract(typeof(LetterDetailsException))]
        [WebInvoke(Method = "GET", UriTemplate = "getletterdetail/{id}", ResponseFormat = WebMessageFormat.Json)]
        List<getLetterDetail_Results> GetLetterDetails(string Id);
    }
}
