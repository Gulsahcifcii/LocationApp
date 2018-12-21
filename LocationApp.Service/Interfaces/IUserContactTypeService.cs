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
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddUserContactType?UserContactTypeID={UserContactTypeID}&TypeName={TypeName}&Description={Description}")]
        string AddUserContactType(int UserContactTypeID, string TypeName, string Description);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/SetUserContactType?UserContactTypeID={UserContactTypeID}&TypeName={TypeName}&Description={Description}")]
        string SetUserContactType(int UserContactTypeID, string TypeName, string Description);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/DelUserContactType?UserContactTypeID={UserContactTypeID}")]
        string DelUserContactType(int UserContactTypeID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetUserContactType?UserContactTypeID={UserContactTypeID}")]
        string GetUserContactType(int UserContactTypeID);

    }
}
