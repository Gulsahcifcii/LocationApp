using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.BuildService")]
    public interface IBuildService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/AddBuild?buildID={buildID}&campusID={campusID}&siteID={siteID}&name={name}&address={address}&properties={properties}&gps={gps}")]
        string AddBuild(int buildID, int campusID, int siteID, string name, string address, string properties, string gps);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/UpdateBuild?buildID={buildID}&campusID={campusID}&siteID={siteID}&name={name}&address={address}&properties={properties}&gps={gps}")]
        string UpdateBuild(int buildID, int campusID, int siteID, string name, string address, string properties, string gps);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/DelBuild?buildID={buildID}")]
        string DelBuild(int builD);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetBuild?buildID={buildID}")]
        string GetBuild(int builD);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetAllBuild")]
        string GetAllBuild();
    }
}
