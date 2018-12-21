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
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddUserUserRole?UserUserRoleID={UserUserRoleID}&UserID={UserID}&UserRoleID={UserRoleID}")]
        string AddUserUserRole(int UserUserRoleID, int UserID, int UserRoleID);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/SetUserUserRole?UserUserRoleID={UserUserRoleID}&UserID={UserID}&UserRoleID={UserRoleID}")]
        string SetUserUserRole(int UserUserRoleID, int UserID, int UserRoleID);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/DelUserUserRole?UserUserRoleID={UserUserRoleID}")]
        string DelUserUserRole(int UserUserRoleID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetUserUserRole?UserUserRoleID={UserUserRoleID}")]
        string GetUserUserRole(int UserUserRoleID);

    }
}