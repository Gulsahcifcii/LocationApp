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
    public class BuildService : IBuildService
    {
        private Core.Core.BuildLogic buildLogic = new Core.Core.BuildLogic();
        public string AddBuild(int buildID, int campusID, int siteID, string name, string address, string properties, string gps)
        {
            var result = buildLogic.AddBuild(new Data.Dto.BuildDto
            {
                BuildID = buildID,
                Address = address,
                CampusID = campusID,
                Gps = gps,
                Name = name,
                Properties = properties,
                SiteID = siteID
            });

            return JsonConvert.SerializeObject(result);
        }
        public string DelBuild(int buildID)
        {
            var result = buildLogic.DelBuild(buildID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetBuild(int buildID)
        {
            var result = buildLogic.GetBuild(buildID);
            return JsonConvert.SerializeObject(result);
        }
        public string UpdateBuild(int buildID, int campusID, int siteID, string name, string address, string properties, string gps)
        {
            var result = buildLogic.SetBuild(new Data.Dto.BuildDto
            {
                BuildID = buildID,
                Address = address,
                CampusID = campusID,
                Gps = gps,
                Name = name,
                Properties = properties,
                SiteID = siteID
            });

            return JsonConvert.SerializeObject(result);
        }
        public string GetAllBuild()
        {
            var build = buildLogic.GetAllBuild();
            var item = JsonConvert.SerializeObject(build, Formatting.Indented);
            return item;
        }
    }
}
