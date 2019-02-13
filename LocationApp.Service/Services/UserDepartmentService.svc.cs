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
        private UserDepartmenLogic userDepartmentLogic = new UserDepartmenLogic();
        public string AddUserDepartment(int userDepartmentID, int userID, int departmentID)
        {

            var result = userDepartmentLogic.AddUserDepartment(new UserDepartmentDto
            {
                UserDepartmentID = userDepartmentID,
                DepartmentID = departmentID,
                UserID = userID
            });

            return JsonConvert.SerializeObject(result);
        }
        public string DelUserDepartment(int UserDepartmentID)
        {
            var result = userDepartmentLogic.DelUserDepartment(UserDepartmentID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetAllUserDepartment()
        {
            var userDepartment = userDepartmentLogic.GetAllUserDepartment();
            var item = JsonConvert.SerializeObject(userDepartment, Formatting.Indented);
            return item;
        }
        public string GetUserDepartment(int UserDepartmentID)
        {
            var result = userDepartmentLogic.GetUserDepartment(UserDepartmentID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetUserDepartment(int UserDepartmentID, int UserID, int DepartmentID)
        {
            var result = userDepartmentLogic.AddUserDepartment(new UserDepartmentDto
            {
                UserDepartmentID = UserDepartmentID,
                UserID = UserID,
                DepartmentID = DepartmentID,
               
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
