using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.UserUserRoleService")]
    public interface IUserUserRoleService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/AddUserUserRole?userUserRoleID={userUserRoleID}&userID={userID}&userRoleID={userRoleID}")]
        string AddUserUserRole(int userUserRoleID, int userID, int userRoleID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/SetUserUserRole?UserUserRoleID={userUserRoleID}&userID={userID}&userRoleID={userRoleID}")]
        string SetUserUserRole(int userUserRoleID, int userID, int userRoleID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/DelUserUserRole?userUserRoleID={userUserRoleID}")]
        string DelUserUserRole(int userUserRoleID);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetUserUserRole?userUserRoleID={userUserRoleID}")]
        string GetUserUserRole(int userUserRoleID);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetAllUserUserRole")]
        string GetAllUserUserRole();
    }
}