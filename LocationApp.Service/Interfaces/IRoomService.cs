using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract]
    public interface IRoomService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/AddRoom?roomID={roomID}&floorID={floorID}&name={name}&roomTypeID={roomTypeID}&map={map}")]
        string AddRoom(int roomID, int floorID, string name, int roomTypeID, string map);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/SetRoom?roomID={roomID}&floorID={floorID}&name={name}&roomTypeID={roomTypeID}&map={map}")]
        string SetRoom(int roomID, int floorID, string name, int roomTypeID, string map);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/DelRoom?roomID={roomID}")]
        string DelRoom(int roomID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/GetRoom?roomID={roomID}")]
        string GetRoom(int roomID);
    }
}
