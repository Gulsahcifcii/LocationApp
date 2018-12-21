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
namespace LocationApp.Service.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        private UserLogic userLogic = new UserLogic();

        public string AddUser(int UserId, string Name, string SurName, bool Gender, string NationID, int UserTitleID)
        {
            var result = userLogic.AddUser(new UserDto
            {
                UserId = UserId,
                Name = Name,
                SurName = SurName,
                Gender = Gender,
                NationID = NationID,
                UserTitleID = UserTitleID
        });

            return JsonConvert.SerializeObject(result);
        }

        public string DelUser(int UserId)
        {
            var result = userLogic.DelUser(UserId);
            return JsonConvert.SerializeObject(result);
        }
        public string GetUser(int UserId)
        {
            var result = userLogic.GetUser(UserId);
            return JsonConvert.SerializeObject(result);
        }

        public string SetUser(int UserId, string Name, string SurName, bool Gender, string NationID, int UserTitleID)
        {
            var result = userLogic.AddUser(new UserDto
            {
                UserId = UserId,
                Name = Name,
                SurName = SurName,
                Gender = Gender,
                NationID = NationID,
                UserTitleID = UserTitleID
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
