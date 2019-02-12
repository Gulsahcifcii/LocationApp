using LocationApp.Service.Interfaces;
using LocationApp.Core.Core;
using LocationApp.Data.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocationApp.Service.Services
{
    public class FloorService : IFloorService
    {
        private FloorLogic floorLogic = new FloorLogic();
        public string AddFloor(int floorID, int blockID, int buildID, string name, string other, string map)
        {
            var result = floorLogic.AddFloor(new FloorDto
            {
                BlockID = blockID,
                BuildID = buildID,
                FloorID = floorID,
                Map = map,
                Name = name,
                Other = other
            });
            return JsonConvert.SerializeObject(result);
        }
        public string DelFloor(int floorID)
        {
            var result = floorLogic.DelFloor(floorID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetFloor(int floorID)
        {
            var result = floorLogic.GetFloor(floorID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetFloor(int floorID, int blockID, int buildID, string name, string other, string map)
        {
            var result = floorLogic.SetFloor(new FloorDto
            {
                BlockID = blockID,
                BuildID = buildID,
                FloorID = floorID,
                Map = map,
                Name = name,
                Other = other
            });
            return JsonConvert.SerializeObject(result);
        }
        public string GetAllFloor()
        {
            var floor = floorLogic.GetAllFloor();
            var item = JsonConvert.SerializeObject(floor, Formatting.Indented);
            return item;
        }
    }
}
