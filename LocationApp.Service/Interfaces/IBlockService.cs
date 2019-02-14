using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.BlockService")]
    public interface IBlockService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/AddBlock?blockID={blockID}&buildID={buildID}&name={name}&gps={gps}")]
        string AddBlock(int blockID, int buildID, string name, string gps);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/Update?blockID={blockID}&buildID={buildID}&name={name}&gps={gps}")]
        string UpdateBlock(int blockID, int buildID, string name, string gps);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/DeleteBlock?blockID={blockID}")]
        string DeleteBlock(int blockID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetBlock?blockID={blockID}")]
        string GetBlock(int blockID);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetAllBlock")]
        string GetAllBlock();

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetAllBlockWithByBuildID?buildID={buildID}")]
        string GetAllBlockWithByBuildID(int buildID);
    }
}
