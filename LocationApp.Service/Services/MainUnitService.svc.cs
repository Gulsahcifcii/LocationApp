using System;
using LocationApp.Core.Core;
using LocationApp.Data.Dto;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LocationApp.Service.Interfaces;

namespace LocationApp.Service.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MainUnitService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MainUnitService.svc or MainUnitService.svc.cs at the Solution Explorer and start debugging.
    public class MainUnitService : IMainUnitService
    {
        private MainUnitLogic mainUnitLogic = new MainUnitLogic();
       
        public string AddMainUnit(int mainUnitID, string mainUnitName)
        {
            var result = mainUnitLogic.AddMainUnit(new MainUnitDto
            {
                Name = mainUnitName,
                MainUnitID = mainUnitID
            });

            return JsonConvert.SerializeObject(result);
        }
        public string DelMainUnit(int mainUnitID)
        {
            var result = mainUnitLogic.DelMainUnit(mainUnitID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetMainUnit(int mainUnitID)
        {
            var result = mainUnitLogic.GetMainUnit(mainUnitID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetMainUnit(int mainUnitID, string mainUnitName)
        {
            var result = mainUnitLogic.SetMainUnit(new MainUnitDto
            {
                Name = mainUnitName,
                MainUnitID = mainUnitID
            });
            return JsonConvert.SerializeObject(result);
        }
       
    }
}
