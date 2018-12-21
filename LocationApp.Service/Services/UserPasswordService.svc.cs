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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserPasswordService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserPasswordService.svc or UserPasswordService.svc.cs at the Solution Explorer and start debugging.
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
