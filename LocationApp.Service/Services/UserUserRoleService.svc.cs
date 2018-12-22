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

        public string AddUserUserRole(int userUserRoleID, int userID, int userRoleID)
        {
            var result = userUserRoleLogic.AddUserUserRole(new UserUserRoleDto
            {
                UserUserRoleID = userUserRoleID,
                UserID = userID,
                UserRoleID = userRoleID
        });

            return JsonConvert.SerializeObject(result);
        }
        public string DelUserUserRole(int userUserRoleID)
        {
            var result = userUserRoleLogic.DelUserUserRole(userUserRoleID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetUserUserRole(int userUserRoleID)
        {
            var result = userUserRoleLogic.GetUserUserRole(userUserRoleID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetUserUserRole(int userUserRoleID, int userID, int userRoleID)
        {
            var result = userUserRoleLogic.AddUserUserRole(new UserUserRoleDto
            {
                UserUserRoleID = userUserRoleID,
                UserID = userID,
                UserRoleID = userRoleID
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
