using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.DepartmentService")]
    public interface IDepartmentService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/AddDepartment?departmentID={departmentID}&description={description}&other={other}&subUnitID={subUnitID}")]
        string AddDepartment(int departmentID, string description, string other, int subUnitID);

        [OperationContract]
        [WebInvoke(Method = "POST",RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/UpdateDepartment?departmentID={departmentID}&description={description}&other={other}&subUnitID={subUnitID}")]
        string UpdateDepartment(int departmentID, string description, string other, int subUnitID);

        [OperationContract]
        [WebInvoke(Method = "GET",RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetDepartment?departmentID={departmentID}")]
        string GetDepartment(int departmentID);

        [OperationContract]
        [WebInvoke(Method = "POST",RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/DelDepartment?departmentID={departmentID}")]
        string DelDepartment(int departmentID);
    }
}
