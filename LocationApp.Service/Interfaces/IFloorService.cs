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
    public interface IFloorService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/AddFloor?floorID={floorID}&blockID={blockID}&name={name}&other={other}&map={map}")]
        string AddFloor(int floorID, int blockID, int buildID, string name, string other, string map);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/SetFloor?floorID={floorID}&blockID={blockID}&name={name}&other={other}&map={map}")]
        string SetFloor(int floorID, int blockID, int buildID, string name, string other, string map);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/DelFloor?floorID={floorID}")]
        string DelFloor(int floorID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetFloor?floorID={floorID}")]
        string GetFloor(int floorID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetAllFloor")]
        string GetAllFloor();
    }

}
