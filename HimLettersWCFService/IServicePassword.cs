using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace HimLettersWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicePassword" in both code and config file together.
    [ServiceContract]
    public interface IServicePassword
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getpassword/{Username}", ResponseFormat = WebMessageFormat.Json)]
        List<getPass_Results> GetPassword(string Username);
    }
}
