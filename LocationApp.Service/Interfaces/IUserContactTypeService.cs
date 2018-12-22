using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.UserContactTypeService")]
    public interface IUserContactTypeService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/AddUserContactType?UserContactTypeID={UserContactTypeID}&TypeName={TypeName}&Description={Description}")]
        string AddUserContactType(int userContactTypeID, string typeName, string description);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/SetUserContactType?userContactTypeID={userContactTypeID}&typeName={typeName}&description={description}")]
        string SetUserContactType(int userContactTypeID, string typeName, string description);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/DelUserContactType?userContactTypeID={userContactTypeID}")]
        string DelUserContactType(int userContactTypeID);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetUserContactType?userContactTypeID={userContactTypeID}")]
        string GetUserContactType(int userContactTypeID);

    }
}
