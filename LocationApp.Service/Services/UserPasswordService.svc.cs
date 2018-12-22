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

        public string AddUserPassword(int userPasswordID, string password, int userID)
        {
            var result = userPasswordLogic.AddUserPassword(new UserPasswordDto
            {
                userPasswordID = userPasswordID,
                password = password,
                userID= userID
            });

            return JsonConvert.SerializeObject(result);
        }
        public string DelUserPassword(int userPasswordID)
        {
            var result = userPasswordLogic.DelUserPassword(userPasswordID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetUserPassword(int userPasswordID)
        {
            var result = userPasswordLogic.GetUserPassword(userPasswordID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetUserTPassword(int userPasswordID, string password, int userID)
        {
            var result = userPasswordLogic.AddUserPassword(new UserPasswordDto
            {
                userPasswordID = userPasswordID,
                password = password,
                userID = userID
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
