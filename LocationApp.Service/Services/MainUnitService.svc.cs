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
