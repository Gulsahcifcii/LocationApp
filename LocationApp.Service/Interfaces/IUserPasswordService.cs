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
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddUserPassword?UserPasswordID={titleId}&Password={Password}&UserID={UserID}")]
        string AddUserPassword(int UserPasswordID, string Password,int UserID);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/SetUserPassword?UserPasswordID={titleId}&Password={Password}&UserID={UserID}")]
        string SetUserTPassword(int UserPasswordID, string Password, int UserID);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/DelUserPassword?UserPasswordID={UserPasswordID}")]
        string DelUserPassword(int UserPasswordID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetUserPassword?UserPasswordID={UserPasswordID}")]
        string GetUserPassword(int UserPasswordID);

    }
}