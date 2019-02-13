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
    public interface ISubUnitService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/AddSubUnit?subUnitID={subUnitID}&name={name}&mainUnitID={mainUnitID}")]
        string AddSubUnit(int subUnitID, string name, int mainUnitID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "/SetSubUnit?subUnitID={subUnitID}&name={name}&mainUnitID={mainUnitID}")]
        string SetSubUnit(int subUnitID, string name, int mainUnitID);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "/DelSubUnit?subUnitID={subUnitID}")]
        string DelSubUnit(int subUnitID);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "/GetSubUnit?subUnitID={subUnitID}")]
        string GetSubUnit(int subUnitID);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/GetAllSubUnit")]
        string GetAllSubUnit();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/GetAllSubUnitWithByMainUnitID?mainUnitID={mainUnitID}")]
        string GetAllSubUnitWithByMainUnitID(int mainUnitID);
       
    }
}
