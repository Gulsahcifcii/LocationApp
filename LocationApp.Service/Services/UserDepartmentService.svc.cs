using LocationApp.Core.Core;
using LocationApp.Data.Dto;
using LocationApp.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace LocationApp.Service.Services
{
     public class UserDepartment : IUserDepartmentService
    {
        private UserDepartmenLogic userDepartmenLogic = new UserDepartmenLogic();

        public string AddUserDepartment(int userDepartmentID, int userID, int departmentID)
        {

            var result = userDepartmenLogic.AddUserDepartment(new UserDepartmentDto
            {
                UserDepartmentID = userDepartmentID,
                DepartmentID = departmentID,
                UserID = userID
            });

            return JsonConvert.SerializeObject(result);
        }
        public string DelUserDepartment(int UserDepartmentID)
        {
            var result = userDepartmenLogic.DelUserDepartment(UserDepartmentID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetUserDepartment(int UserDepartmentID)
        {
            var result = userDepartmenLogic.GetUserDepartment(UserDepartmentID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetUserDepartment(int UserDepartmentID, int UserID, int DepartmentID)
        {
            var result = userDepartmenLogic.AddUserDepartment(new UserDepartmentDto
            {
                UserDepartmentID = UserDepartmentID,
                UserID = UserID,
                DepartmentID = DepartmentID,
               
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
