using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace HimLettersWCFService
{
    [DataContract]
    public class LetterTypeException
    {
        [DataMember]
        public string Title;
    }

    [ServiceContract]
    public interface IServiceLetterType
    {
        [OperationContract]
        [FaultContract(typeof(LetterTypeException))]
        [WebInvoke(Method = "GET", UriTemplate = "getlettertypelist", ResponseFormat = WebMessageFormat.Json)]
        List<getLetterTypeList_Results> GetLetterTypeList();
    }
}
