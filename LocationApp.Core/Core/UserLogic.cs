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
using LocationApp.Core.Helper;

namespace LocationApp.Core.Core
{
   public class UserLogic
    {
        public ResultHelper AddUser(UserDto userDto)
        {
            try
            {
                if (isThere(userDto))
                {
                    return new ResultHelper(false, 0, ResultHelper.UnSuccessMessage);
                }
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
                    return new ResultHelper(true, item.UserID, ResultHelper.SuccessMessage);
                }
            }
            catch (Exception ex)
            {
                return new ResultHelper(false, 0, ResultHelper.UnSuccessMessage);
            }
        }
        public ResultHelper SetUser(UserDto userDto)
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
                    return new ResultHelper(true, item.UserID, ResultHelper.SuccessMessage);
                }
            }
            catch (Exception)
            {
                return new ResultHelper(false, userDto.UserId, ResultHelper.UnSuccessMessage);
            }
        }
        public ResultHelper DelUser(int UserID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedUser = unitofWork.GetRepository<user>().GetById(x => x.UserID == UserID);
                    unitofWork.GetRepository<user>().Delete(selectedUser);
                    unitofWork.saveChanges();
                    return new ResultHelper(true, selectedUser.UserID, ResultHelper.SuccessMessage);
                }
            }
            catch (Exception)
            {
                return new ResultHelper(false, UserID, ResultHelper.UnSuccessMessage);
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
        public List<UserDto> GetAllUser()
        {
            try
            {
                List<UserDto> list = new List<UserDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    List<user> collection = unitofWork.GetRepository<user>().Select(null, null).ToList();
                    foreach (var item in collection)
                    {
                        list.Add(new UserDto {UserId=item.UserID,Name=item.Name,SurName=item.SurName,Gender=(bool)item.Gender,NationID=item.NationID,UserTitleID=(int)item.UserTitleID});
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<UserDto>();
            }
        }
        public bool isThere(UserDto userDto)
        {
            using (UnitOfWork unitofWork = new UnitOfWork())
            {
                var item = unitofWork.GetRepository<user>().GetById(x => x.UserID == userDto.UserId && x.Name == userDto.Name && x.SurName == userDto.SurName && x.Gender == userDto.Gender && x.NationID == userDto.NationID && x.UserTitleID == userDto.UserTitleID);
                if (item != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
