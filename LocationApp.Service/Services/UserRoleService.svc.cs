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
    public class UserRoleService : IUserRoleService
    {
        private UserRoleLogic userRoleLogic = new UserRoleLogic();
        public string AddUserRole(int userRoleID, string userRoleName, string userRoleDescription, bool active)
        {
            var result = userRoleLogic.AddUserRole(new UserRoleDto
            {
                UserRoleName=userRoleName,
                UserRoleDescription=userRoleDescription,
                Active=active,
                UserRoleID=userRoleID
            });

            return JsonConvert.SerializeObject(result);
        }
        public string DelUserRole(int userRoleID)
        {
            var result = userRoleLogic.DelUserRole(userRoleID);
            return JsonConvert.SerializeObject(result);
        }

        public string GetAllUserRole()
        {
            var userRole = userRoleLogic.GetAllUserRole();
            var item = JsonConvert.SerializeObject(userRole, Formatting.Indented);
            return item;
        }

        public string GetUserRole(int userRoleID)
        {
            var result = userRoleLogic.GetUserRole(userRoleID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetUserRole(int userRoleID, string userRoleName, string userRoleDescription, bool active)
        {
            var result = userRoleLogic.SetUserRole(new UserRoleDto
            {
                UserRoleName = userRoleName,
                UserRoleDescription = userRoleDescription,
                Active = active,
                UserRoleID = userRoleID
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
