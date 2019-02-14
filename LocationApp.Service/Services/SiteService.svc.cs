using LocationApp.Core.Core;
using LocationApp.Data.Dto;
using LocationApp.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocationApp.Service.Services
{
     public class SiteService : ISiteService
    {
        private SiteLogic siteLogic = new SiteLogic();
        public string AddSite(int siteID, string name, string description, string gps)
        {
            var result = siteLogic.AddSite (new SiteDto
            {
                SiteID=siteID,
                Description=description,
                Gps=gps,
                Name=name
            });
            return JsonConvert.SerializeObject(result);
        }
        public string DelSite(int roomID)
        {
            var result = siteLogic.DelSite(roomID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetSite(int siteID)
        {
            var result = siteLogic.GetSite(siteID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetSite(int siteID, string name, string description, string gps)
        {
            var result = siteLogic.SetSite(new SiteDto
            {
                SiteID = siteID,
                Description = description,
                Gps = gps,
                Name = name
            });
            return JsonConvert.SerializeObject(result);
        }
        public string GetAllSite()
        {
            var site = siteLogic.GetAllSite();
            var item = JsonConvert.SerializeObject(site, Formatting.Indented);
            return item;
        }
        public string GetAllSiteWithCampus(int campusID)
        {
            var site = siteLogic.GetSiteWithCampus(campusID);
            var item = JsonConvert.SerializeObject(site, Formatting.Indented);
            return item;
        }
    }
}
