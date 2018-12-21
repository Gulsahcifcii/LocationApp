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
   public class UserPasswordService : IUserPasswordService
    {
        private UserPasswordLogic userPasswordLogic = new UserPasswordLogic();

        public string AddUserPassword(int UserPasswordID, string Password, int UserID)
        {
            var result = userPasswordLogic.AddUserPassword(new UserPasswordDto
            {
                userPasswordID = UserPasswordID,
                password = Password,
                userID= UserID
            });

            return JsonConvert.SerializeObject(result);
        }
        public string DelUserPassword(int UserPasswordID)
        {
            var result = userPasswordLogic.DelUserPassword(UserPasswordID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetUserPassword(int UserPasswordID)
        {
            var result = userPasswordLogic.GetUserPassword(UserPasswordID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetUserTPassword(int UserPasswordID, string Password, int UserID)
        {
            var result = userPasswordLogic.AddUserPassword(new UserPasswordDto
            {
                userPasswordID = UserPasswordID,
                password = Password,
                userID = UserID
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
