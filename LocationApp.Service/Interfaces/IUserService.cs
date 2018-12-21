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
    public interface IUserService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddUserTitle?UserId={UserId}&Name={Name}&SurName={SurName}&Gender={Gender}&NationID={NationID}&UserTitleID={UserTitleID}")]
        string AddUser(int UserId, string Name, string SurName, bool Gender, string NationID, int UserTitleID);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/SetUserTitle?UserId={UserId}&Name={Name}&SurName={SurName}&Gender={Gender}&NationID={NationID}&UserTitleID={UserTitleID}")]
        string SetUser(int UserId, string Name, string SurName, bool Gender, string NationID, int UserTitleID);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/UserId?UserId={UserId}")]
        string DelUser(int UserId);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/UserId?UserId={UserId}")]
        string GetUser(int UserId);

    }
}
