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
    public class UserContactService : IUserContactService
    {
        private UserContactLogic userContactLogic = new UserContactLogic();
        public string AddUserContact(int UserContactID, string Contact, int UserID, int UserContactTypeID)
        {
            var result = userContactLogic.AddUserContact(new UserContactDto
            {
                UserContactID = UserContactID,
                Contact = Contact,
                UserContactTypeID = UserContactTypeID,
                UserID=UserID
            });

            return JsonConvert.SerializeObject(result);
        }
        public string DelUserContact(int UserContactID)
        {
            var result = userContactLogic.DelUserContact(UserContactID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetUserContact(int UserContactID)
        {
            var result = userContactLogic.GetUserContact(UserContactID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetUserContact(int UserContactID, string Contact, int UserID, int UserContactTypeID)
        {
            var result = userContactLogic.AddUserContact(new UserContactDto
            {
                UserContactID = UserContactID,
                Contact = Contact,
                UserContactTypeID = UserContactTypeID,
                UserID = UserID
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
