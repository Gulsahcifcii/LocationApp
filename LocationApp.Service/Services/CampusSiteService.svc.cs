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
    public class CampusSiteService : ICampusSiteService
    {
        private Core.Core.CampusSiteLogic campusSiteLogic = new Core.Core.CampusSiteLogic();
        public string AddCampusSite(int campusSiteID, int siteID, int campusID, string other)
        {
            var result = campusSiteLogic.AddCampusSite(new Data.Dto.CampusSiteDto
            {
                CampusID = campusID,
                CampusSiteID = campusSiteID,
                Other = other,
                SiteID = siteID
            });
            return JsonConvert.SerializeObject(result);
        }
        public string DelCampusSite(int campusSiteID)
        {
            var result = campusSiteLogic.GetCampusSite(campusSiteID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetCampusSite(int campusSiteID, int siteID, int campusID)
        {
            var result = campusSiteLogic.GetCampusSite(campusSiteID);
            return JsonConvert.SerializeObject(result);
        }
        public string UpdateCampusSite(int campusSiteID, int siteID, int campusID, string other)
        {
            var result = campusSiteLogic.SetCampusSite(new Data.Dto.CampusSiteDto
            {
                CampusID = campusID,
                CampusSiteID = campusSiteID,
                Other = other,
                SiteID = siteID
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
