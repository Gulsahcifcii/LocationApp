using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.DepartmentRoomService")]
    public interface IDepartmentRoomService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/AddDepartmentRoom?departmentRoomID={departmentRoomID}&departmentID={departmentID}&roomID={roomID}&other={other}")]
        string AddDepartmentRoom(int departmentRoomID, int departmentID, int roomID, string other);

        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/UpdateDepartmentRoom?departmentRoomID={departmentRoomID}&departmentID={departmentID}&roomID={roomID}&other={other}")]
        string UpdateDepartmentRoom(int departmentRoomID, int departmentID, int roomID, string other);

        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetDepartmentRoom?departmentRoomID={departmentRoomID}&departmentID={departmentID}&roomID={roomID}")]
        string GetDepartmentRoom(int departmentRoomID, int departmentID, int roomID);

        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/DelDepartmentRoom?departmentRoomID={departmentRoomID}&departmentID={departmentID}&roomID={roomID}")]
        string DelDepartmentRoom(int departmentRoomID, int departmentID, int roomID);


    }
}
