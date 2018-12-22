using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.UserRoleService")]
    public interface IUserRoleService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/AddUserRole?userRoleID={userRoleID}&userRoleName={userRoleName}&userRoleDescription={userRoleDescription}&active={active}")]
        string AddUserRole(int userRoleID, string userRoleName, string userRoleDescription, bool active);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/SetUserRole?userRoleID={userRoleID}&userRoleName={userRoleName}&userRoleDescription={userRoleDescription}&active={active}")]
        string SetUserRole(int userRoleID, string userRoleName, string userRoleDescription, bool active);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/DelUserRole?userRoleID={userRoleID}")]
        string DelUserRole(int userRoleID);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetUserRole?userRoleID={userRoleID}")]
        string GetUserRole(int userRoleID);

    }
}
