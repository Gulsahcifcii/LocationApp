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
     public class UserUserRoleService : IUserUserRoleService
    {
        private UserUserRoleLogic userUserRoleLogic = new UserUserRoleLogic();

        public string AddUserUserRole(int UserUserRoleID, int UserID, int UserRoleID)
        {
            var result = userUserRoleLogic.AddUserUserRole(new UserUserRoleDto
            {
                UserUserRoleID = UserUserRoleID,
                UserID = UserID,
                UserRoleID = UserRoleID
        });

            return JsonConvert.SerializeObject(result);
        }
        public string DelUserUserRole(int UserUserRoleID)
        {
            var result = userUserRoleLogic.DelUserUserRole(UserUserRoleID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetUserUserRole(int UserUserRoleID)
        {
            var result = userUserRoleLogic.GetUserUserRole(UserUserRoleID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetUserUserRole(int UserUserRoleID, int UserID, int UserRoleID)
        {
            var result = userUserRoleLogic.AddUserUserRole(new UserUserRoleDto
            {
                UserUserRoleID = UserUserRoleID,
                UserID = UserID,
                UserRoleID = UserRoleID
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
