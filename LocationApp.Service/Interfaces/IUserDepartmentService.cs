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
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/AddUserDepartment?userDepartmentID={userDepartmentID}&userID={userID}&departmentID={departmentID}")]
        string AddUserDepartment(int userDepartmentID, int userID, int departmentID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, 
            UriTemplate = "/SetUserDepartment?userDepartmentID={userDepartmentID}&userID={userID}&departmentID={departmentID}")]
        string SetUserDepartment(int userDepartmentID, int userID, int departmentID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/DelUserDepartment?userDepartmentID={userDepartmentID}")]
        string DelUserDepartment(int userDepartmentID);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetUserDepartment?userDepartmentID={userDepartmentID}")]
        string GetUserDepartment(int userDepartmentID);

    }
}