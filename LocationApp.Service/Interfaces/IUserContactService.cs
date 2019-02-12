using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.UserContactService")]
    public interface IUserContactService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/AddUserContact?userContactID={userContactID}&contact={contact}&userID={userID}&userContactTypeID={userContactTypeID}")]
        string AddUserContact(int userContactID, string contact, int userID, int userContactTypeID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/SetUserContact?userContactID={userContactID}&contact={contact}&userID={userID}&userContactTypeID={userContactTypeID}")]
        string SetUserContact(int userContactID, string contact, int userID, int userContactTypeID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/DelUserContact?userContactID={userContactID}")]
        string DelUserContact(int userContactID);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetUserContact?userContactID={userContactID}")]
        string GetUserContact(int userContactID);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/GetAllUserContact")]
        string GetAllUserContact();
    }
}