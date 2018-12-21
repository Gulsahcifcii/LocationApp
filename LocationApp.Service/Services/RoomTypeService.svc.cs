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
    }
}
