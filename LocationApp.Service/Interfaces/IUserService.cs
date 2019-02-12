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
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/AddUserTitle?userId={userId}&name={name}&surName={surName}&gender={gender}&nationID={nationID}&userTitleID={userTitleID}")]
        string AddUser(int userId, string name, string surName, bool gender, string nationID, int userTitleID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, 
            UriTemplate = "/SetUserTitle?userId={userId}&name={name}&surName={surName}&gender={gender}&nationID={nationID}&userTitleID={userTitleID}")]
        string SetUser(int userId, string name, string surName, bool gender, string nationID, int userTitleID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/UserId?userId={userId}")]
        string DelUser(int userId);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/UserId?userId={userId}")]
        string GetUser(int userId);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/GetAllUser")]
        string GetUser();
    }
}
