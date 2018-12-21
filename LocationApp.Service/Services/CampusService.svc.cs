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
    public class CampusService : ICampusService
    {
        private Core.Core.CampusLogic campusLogic = new Core.Core.CampusLogic();
        public string AddCampus(int campusID, string description, string other)
        {
            var result = campusLogic.AddCampus(new Data.Dto.CampusDto
            {
                CampusID = campusID,
                Description = description,
                Other = other
            });
            return JsonConvert.SerializeObject(result);
        }
        public string DelCampus(int campusID)
        {
            var result = campusLogic.DelCampus(campusID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetCampus(int campusID)
        {
            var result = campusLogic.GetCampus(campusID);
            return JsonConvert.SerializeObject(result);
        }
        public string UpdateCampus(int campusID, string description, string other)
        {
            var result = campusLogic.SetCampus(new Data.Dto.CampusDto
            {
                CampusID = campusID,
                Description = description,
                Other = other
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
