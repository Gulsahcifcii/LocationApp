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
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddUserContactType?UserContactTypeID={UserContactTypeID}&TypeName={TypeName}&Description={Description}")]
        string AddUserRole(int userRoleID, string userRoleName, string userRoleDescription,bool active);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/SetUserContactType?UserContactTypeID={UserContactTypeID}&TypeName={TypeName}&Description={Description}")]
        string SetUserRole(int userRoleID, string userRoleName, string userRoleDescription, bool active);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/DelUserContactType?UserContactTypeID={UserContactTypeID}")]
        string DelUserRole(int userRoleID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetUserContactType?UserContactTypeID={UserContactTypeID}")]
        string GetUserRole(int userRoleID);

    }
}
