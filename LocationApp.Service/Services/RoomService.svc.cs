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
     public class RoomService : IRoomService
    {
        private RoomLogic roomLogic = new RoomLogic();
        public string AddRoom(int roomID,int floorID,string name,int roomTypeID,string map)
        {
            var result = roomLogic.AddRoom(new RoomDto
            {
                FloorID = floorID,
                Map = map,
                Name = name,
                RoomID = roomID,
                RoomTypeID=roomTypeID
            });
            return JsonConvert.SerializeObject(result);
        }
        public string DelRoom(int roomID)
        {
            var result = roomLogic.DelRoom(roomID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetRoom(int roomID)
        {
            var result = roomLogic.GetRoom(roomID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetRoom(int roomID, int floorID, string name, int roomTypeID, string map)
        {
            var result = roomLogic.SetRoom(new RoomDto
            {
                FloorID = floorID,
                Map = map,
                Name = name,
                RoomID = roomID,
                RoomTypeID = roomTypeID
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
