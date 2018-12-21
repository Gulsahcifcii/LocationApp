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

namespace LocationApp.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserContactTypeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserContactTypeService.svc or UserContactTypeService.svc.cs at the Solution Explorer and start debugging.
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
