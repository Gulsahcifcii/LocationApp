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
    public class UserContactTypeService : IUserContactTypeService
    {
        private UserContactTypeLogic userContactTypeLogic = new UserContactTypeLogic();
        public string AddUserContactType(int userContactID, string typeName, string description)
        {
            var result = userContactTypeLogic.AddUserContactType(new UserContactTypeDto
            {
                TypeName = typeName,
                UserContactTypeID = userContactID
            });

            return JsonConvert.SerializeObject(result);
        }
        public string DelUserContactType(int userContactTypeID)
        {
            var result = userContactTypeLogic.DelUserContactType(userContactTypeID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetUserContactType(int userContactTypeID)
        {
            var result = userContactTypeLogic.GetUserContactType(userContactTypeID);
            return JsonConvert.SerializeObject(result);
        }
        public string SetUserContactType(int userContactTypeID, string typeName, string description)
        {
            var result = userContactTypeLogic.SetUserContactType(new UserContactTypeDto
            {
                TypeName = typeName,
                Description = description,
                UserContactTypeID = Convert.ToInt32(userContactTypeID)
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
