using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.RoomTypeService")]
    public interface IRoomTypeService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/AddRoomType?RoomTypeID={RoomTypeID}&Name={Name}&Description={Description}")]
        string AddRoomType(int RoomTypeID, string Name, string Description);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/SetRoomType?RoomTypeID={RoomTypeID}&Name={Name}&Description={Description}")]
        string SetRoomType(int RoomTypeID, string Name ,string Description);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/DelRoomType?RoomTypeID={RoomTypeID}")]
        string DelRoomType(int RoomTypeID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/GetRoomType?RoomTypeID={RoomTypeID}")]
        string GetRoomType(int RoomTypeID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetAllRoomType")]
        string GetAllRoomType();
    }
}