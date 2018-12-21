using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMainUnitService" in both code and config file together.
    [ServiceContract]
    public interface IMainUnitService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddMainUnit?mainUnitId={mainUnitId}&mainUnitName={mainUnitName}")]
        string AddMainUnit(int mainUnitId, string mainUnitName);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/SetMainUnit?mainUnitId={mainUnitId}&mainUnitName={mainUnitName}")]
        string SetMainUnit(int mainUnitId, string mainUnitName);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/DelMainUnit?mainUnitId={mainUnitId}")]
        string DelMainUnit(int mainUnitId);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetMainUnit?mainUnitId={mainUnitId}")]
        string GetMainUnit(int mainUnitId);




    }
}
