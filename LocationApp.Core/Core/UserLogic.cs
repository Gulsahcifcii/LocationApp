using LocationApp.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocationApp.Data;
using System.ServiceModel.Web;
using LocationApp.Data.Dto;
using LocationApp.Data.UnitOfWork;
using System.Net;

namespace LocationApp.Core.Core
{
   public class UserLogic
    {
        WebOperationContext webOperationContext = WebOperationContext.Current;

        public string AddUser(UserDto userDto)
        {
            try
            {
                user item = new user();
                item.UserID = userDto.UserId;
                item.Name = userDto.Name;
                item.SurName = userDto.SurName;
                item.Gender = userDto.Gender;
                item.NationID = userDto.NationID;
                item.UserTitleID = userDto.UserTitleID;


                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<user>().Insert(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }

        public string SetUser(UserDto userDto)
        {
            try
            {
                user item = new user();
                item.UserID = userDto.UserId;
                item.Name = userDto.Name;
                item.SurName = userDto.SurName;
                item.Gender = userDto.Gender;
                item.NationID = userDto.NationID;
                item.UserTitleID = userDto.UserTitleID;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<user>().Update(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelUser(int UserID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedUser = unitofWork.GetRepository<user>().GetById(x => x.UserID == UserID);
                    unitofWork.GetRepository<user>().Delete(selectedUser);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public UserDto GetUser(int UserID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    user item = new user();
                    item = unitofWork.GetRepository<user>().GetById(x => x.UserID == UserID);
                    UserDto userDto = new UserDto();
                    item.UserID = userDto.UserId;
                    item.Name = userDto.Name;
                    item.SurName = userDto.SurName;
                    item.Gender = userDto.Gender;
                    item.NationID = userDto.NationID;
                    item.UserTitleID = userDto.UserTitleID;

                    return userDto;
                }
            }
            catch (Exception)
            {
                return new UserDto();
            }
        }
    }
}
