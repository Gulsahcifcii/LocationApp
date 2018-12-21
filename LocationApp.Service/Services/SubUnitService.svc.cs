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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SubUnitService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SubUnitService.svc or SubUnitService.svc.cs at the Solution Explorer and start debugging.
    public class SubUnitService : ISubUnitService
    {
        private SubUnitLogic subUnitLogic = new SubUnitLogic();
        public string AddSubUnit(int subUnitID,string name, int mainUnitID)
        {
            var result = subUnitLogic.AddSubUnit(new SubUnitDto
            {
              SubUnitID=subUnitID,
              MainUnitID=mainUnitID,
              Name=name
            });
            return JsonConvert.SerializeObject(result);
        }
        public string DelSubUnit(int subUnitID)
        {
            var result = subUnitLogic.DelSubUnit(subUnitID);
            return JsonConvert.SerializeObject(result);
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
