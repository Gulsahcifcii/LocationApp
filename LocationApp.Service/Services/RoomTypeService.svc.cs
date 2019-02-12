using LocationApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LocationApp.Data;
using LocationApp.Core.Core;
using Newtonsoft.Json;
using LocationApp.Data.Dto;
using LocationApp.Data.Database;
using LocationApp.Data.UnitOfWork;

namespace LocationApp.Service.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private RoomTypeLogic roomTypeLogic = new RoomTypeLogic();
        public string AddRoomType(int RoomTypeID, string Name, string Description)
        {
            var result = roomTypeLogic.AddRoomType(new Data.Dto.RoomTypeDto
            {
                RoomTypeID = Convert.ToInt32(RoomTypeID),
                Name = Name,
                Description=Description
                
            });

            return JsonConvert.SerializeObject(result);
        }
        public string DelRoomType(int RoomTypeID)
        {
            var result = roomTypeLogic.DelRoomType(RoomTypeID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetRoomType(int RoomTypeID)
        {
            var result = roomTypeLogic.GetRoomType(RoomTypeID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetRoomType(int RoomTypeID, string Name, string Description)
        {
            var result = roomTypeLogic.AddRoomType(new Data.Dto.RoomTypeDto
            {
                RoomTypeID = Convert.ToInt32(RoomTypeID),
                Name = Name,
                Description=Description
                
            });
            return JsonConvert.SerializeObject(result);
        }
        public string GetAllRoomType()
        {
            var roomType = roomTypeLogic.GetAllRoomType();
            var item = JsonConvert.SerializeObject(roomType, Formatting.Indented);
            return item;
        }
    }
}
