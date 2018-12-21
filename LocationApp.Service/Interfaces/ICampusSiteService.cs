using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract(Namespace = "LocationApp.Service.Services.CampusSiteService")]
    public interface ICampusSiteService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/AddCampusSite?campusSiteID={campusSiteID}&siteID={siteID}&campusID={campusID}&other={other}")]

        string AddCampusSite(int campusSiteID, int siteID, int campusID, string other);

        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/UpdateCampusSite?campusSiteID={campusSiteID}&siteID={siteID}&campusID={campusID}&other={other}")]
        string UpdateCampusSite(int campusSiteID, int siteID, int campusID, string other);

        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetCampusSite?campusSiteID={campusSiteID}&siteID={siteID}&campusID={campusID}&other={other}")]
        string GetCampusSite(int campusSiteID,int siteID,int campusID);

        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/DelCampusSite?campusSiteID={campusSiteID}")]
        string DelCampusSite(int campusSiteID);

    }
}
