﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service.Interfaces
{
    [ServiceContract]
    public interface ISiteService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/AddSite?siteID={siteID}&name={name}&description={description}&gps={gps}")]
        string AddSite(int siteID, string name, string description, string gps);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "/SetSite?siteID={siteID}&name={name}&description={description}&gps={gps}")]
        string SetSite(int siteID, string name, string description, string gps);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "/DelSite?siteID={siteID}")]
        string DelSite(int siteID);
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "/GetSite?siteID={siteID}")]
        string GetSite(int siteID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetAllSite")]
        string GetAllSite();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetAllSiteWithCampus?campusID={campusID}")]
        string GetAllSiteWithCampus(int campusID);
    }
}
