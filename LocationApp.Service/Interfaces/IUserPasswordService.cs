using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.UserPasswordService")]
    public interface IUserPasswordService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/AddUserPassword?userPasswordID={userPasswordID}&password={password}&userID={userID}")]
        string AddUserPassword(int userPasswordID, string password, int userID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/SetUserPassword?userPasswordID={userPasswordID}&password={password}&userID={userID}")]
        string SetUserTPassword(int userPasswordID, string password, int userID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, 
            UriTemplate = "/DelUserPassword?userPasswordID={userPasswordID}")]
        string DelUserPassword(int userPasswordID);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetUserPassword?userPasswordID={userPasswordID}")]
        string GetUserPassword(int userPasswordID);
    }
}