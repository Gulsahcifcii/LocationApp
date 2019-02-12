using LocationApp.Data.Database;
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
    public class CampusService : ICampusService
    {
        private Core.Core.CampusLogic campusLogic = new Core.Core.CampusLogic();
        public string AddCampus(int campusID, string name, string description, string other)
        {
            var result = campusLogic.AddCampus(new Data.Dto.CampusDto
            {
                CampusID = campusID,
                Description = description,
                Other = other,
                Name = name
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
            var campus  = campusLogic.GetCampus(campusID);
            var item = JsonConvert.SerializeObject(campus, Formatting.Indented);
            return item;
        }
        public string UpdateCampus(int campusID, string name, string description, string other)
        {
            var result = campusLogic.SetCampus(new Data.Dto.CampusDto
            {
                CampusID = campusID,
                Description = description,
                Other = other,
                Name = name
            });
            return JsonConvert.SerializeObject(result);
        }

        public string GetAllCampus()
        {
            var campus = campusLogic.GetAllCampus();
            var item = JsonConvert.SerializeObject(campus, Formatting.Indented);
            return item;
        }

    }
}
