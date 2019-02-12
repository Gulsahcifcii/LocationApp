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
    public class UserTitleService : IUserTitleService
    {
        private UserTitleLogic userTitleLogic = new UserTitleLogic();

        public string AddUserTitle(int userTitleId, string titleName)
        {
            var result = userTitleLogic.AddUserTitle(new UserTitleDto
            {
                TitleName = titleName,
                UserTitleId = Convert.ToInt32(userTitleId)
            });

            return JsonConvert.SerializeObject(result);
        }
        public string DelUserTitle(int userTitleId)
        {
            var result = userTitleLogic.DelUserTitle(userTitleId);
            return JsonConvert.SerializeObject(result);
        }
        public string GetUserTitle(int userTitleId)
        {
            var result = userTitleLogic.GetUserTitle(userTitleId);
            return JsonConvert.SerializeObject(result);
        }
        public string SetUserTitle(int userTitleId, string titleName)
        {
            var result = userTitleLogic.SetUserTitle(new UserTitleDto
            {
                TitleName = titleName,
                UserTitleId = Convert.ToInt32(userTitleId)
            });
            return JsonConvert.SerializeObject(result);
        }
        public string GetAllUserTitle()
        {
            var userTitle = userTitleLogic.GetAllUserTitle();
            var item = JsonConvert.SerializeObject(userTitle, Formatting.Indented);
            return item;
        }
    }
}
