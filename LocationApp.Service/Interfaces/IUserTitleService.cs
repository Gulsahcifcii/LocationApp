using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.UserTitleService")]
    public interface IUserTitleService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/AddUserTitle?titleId={titleId}&titleName={titleName}")]
        string AddUserTitle(int titleId, string titleName);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/SetUserTitle?titleId={titleId}&titleName={titleName}")]
        string SetUserTitle(int titleId, string titleName);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/DelUserTitle?userTitleId={userTitleId}")]
        string DelUserTitle(int userTitleId);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, 
            UriTemplate = "/GetUserTitle?userTitleId={userTitleId}")]
        string GetUserTitle(int userTitleId);
    }
}
