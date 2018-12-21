using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.UserDepartmentService")]
    public interface IUserDepartmentService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddUserDepartment?UserDepartmentID={UserDepartmentID}&UserID={UserID}&DepartmentID={DepartmentID}")]
        string AddUserDepartment(int UserDepartmentID, int UserID, int DepartmentID);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/SetUserDepartment?UserDepartmentID={UserDepartmentID}&UserID={UserID}&DepartmentID={DepartmentID}")]
        string SetUserDepartment(int UserDepartmentID, int UserID, int DepartmentID);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/DelUserDepartment?UserDepartmentID={UserDepartmentID}")]
        string DelUserDepartment(int UserDepartmentID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetUserDepartment?UserDepartmentID={UserDepartmentID}")]
        string GetUserDepartment(int UserDepartmentID);

    }
}