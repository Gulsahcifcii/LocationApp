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
    public class SubUnitService : ISubUnitService
    {
        private SubUnitLogic subUnitLogic = new SubUnitLogic();
        public string AddSubUnit(int subUnitID, string name, int mainUnitID)
        {
            var result = subUnitLogic.AddSubUnit(new SubUnitDto
            {
                SubUnitID = subUnitID,
                MainUnitID = mainUnitID,
                Name = name
            });
            return JsonConvert.SerializeObject(result);
        }
        public string DelSubUnit(int subUnitID)
        {
            var result = subUnitLogic.DelSubUnit(subUnitID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetAllSubUnit(int subUnitID)
        {
            var SubUnit = subUnitLogic.GetAllSubUnit(subUnitID);
            var item = JsonConvert.SerializeObject(SubUnit, Formatting.Indented);
            return item;
        }
        public string GetSubUnit(int subUnitID)
        {
            var result = subUnitLogic.GetSubUnit(subUnitID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetSubUnit(int subUnitID, string name, int mainUnitID)
        {
            var result = subUnitLogic.SetSubUnit(new SubUnitDto
            {
                SubUnitID = subUnitID,
                MainUnitID = mainUnitID,
                Name = name
            });
            return JsonConvert.SerializeObject(result);
        }

    }
}
