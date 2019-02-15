using LocationApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LocationApp.Core.Core;
using Newtonsoft.Json;
using LocationApp.Data.Dto;

namespace LocationApp.Service.Services
{
    public class DepartmentRoomService : IDepartmentRoomService
    {
        private DepartmentRoomLogic departmentRoomLogic = new DepartmentRoomLogic();
        public string AddDepartmentRoom(int departmentRoomID, int departmentID, int roomID, string other)
        {
            var result = departmentRoomLogic.AddDepartmentRoom(new DepartmentRoomDto
            {
                DepartmentID = departmentID,
                DepartmentRoomID = departmentRoomID,
                Other = other,
                RoomID = roomID
            });
            return JsonConvert.SerializeObject(result);
        }
        public string DelDepartmentRoom(int departmentRoomID, int departmentID, int roomID)
        {
            var result = departmentRoomLogic.DelDepartmentRoom(departmentRoomID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetDepartmentRoom(int departmentRoomID, int departmentID, int roomID)
        {
            var result = departmentRoomLogic.GetDepartmentRoom(departmentRoomID);
            return JsonConvert.SerializeObject(result);
        }
        public string UpdateDepartmentRoom(int departmentRoomID, int departmentID, int roomID, string other)
        {
            var result = departmentRoomLogic.SetDepartmentRoom(new DepartmentRoomDto
            {
                DepartmentID = departmentID,
                DepartmentRoomID = departmentRoomID,
                Other = other,
                RoomID = roomID
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
