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
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddUserContact?UserContactID={UserContactID}&titleName={titleName}&UserID={UserID}&UserContactTypeID={UserContactTypeID}")]
        string AddUserContact(int UserContactID, string Contact, int UserID, int UserContactTypeID);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/SetUserContact?UserContactID={UserContactID}&titleName={titleName}&UserID={UserID}&UserContactTypeID={UserContactTypeID}")]
        string SetUserContact(int UserContactID, string Contact, int UserID, int UserContactTypeID);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/DelUserContact?UserContactID={UserContactID}")]
        string DelUserContact(int UserContactID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetUserContact?UserContactID={UserContactID}")]
        string GetUserContact(int UserContactID);

    }
}