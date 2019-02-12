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
   public class UserService : IUserService
    {
        private UserLogic userLogic = new UserLogic();

        public string AddUser(int userId, string name, string surName, bool gender, string nationID, int userTitleID)
        {
            var result = userLogic.AddUser(new UserDto
            {
                UserId = userId,
                Name = name,
                SurName = surName,
                Gender = gender,
                NationID = nationID,
                UserTitleID = userTitleID
        });

            return JsonConvert.SerializeObject(result);
        }
        public string DelUser(int userId)
        {
            var result = userLogic.DelUser(userId);
            return JsonConvert.SerializeObject(result);
        }
        public string GetUser(int userId)
        {
            var result = userLogic.GetUser(userId);
            return JsonConvert.SerializeObject(result);
        }
        public string GetUser()
        {
            var userTitle = userLogic.GetAllUser();
            var item = JsonConvert.SerializeObject(user, Formatting.Indented);
            return item;
        }
        public string SetUser(int userId, string name, string surName, bool gender, string nationID, int userTitleID)
        {
            var result = userLogic.AddUser(new UserDto
            {
                UserId = userId,
                Name = name,
                SurName = surName,
                Gender = gender,
                NationID = nationID,
                UserTitleID = userTitleID
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
