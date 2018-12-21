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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserUserRoleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserUserRoleService.svc or UserUserRoleService.svc.cs at the Solution Explorer and start debugging.
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
