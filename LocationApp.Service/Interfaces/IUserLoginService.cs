using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.UserLoginService")]
    public interface IUserLoginService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddUserLogin?UserLoginID={userLoginID}&Password={password}&CreationDate={creationDate}&IpAdress={ipAdress}&UserID={userID}")]
        string AddUserLogin(int userLoginID, string password, string creationDate, string ipAdress,int userID );

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/SetUserLogin?UserLoginID={userLoginID}&Password={password}&CreationDate={creationDate}&IpAdress={ipAdress}&UserID={userID}")]
        string SetUserLogin(int userLoginID, string password, string creationDate, string ipAdress, int userID);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/DelUserLogin?UserLoginID={userContactTypeID}")]
        string DelUserLogin(int userLoginID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetUserLogin?UserContactTypeID={userContactTypeID}")]
        string GetUserLogin(int userLoginID);

    }
}
