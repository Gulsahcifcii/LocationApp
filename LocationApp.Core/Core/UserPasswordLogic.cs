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
    public class UserPasswordLogic
    {

        public ResultHelper AddUserPassword(UserPasswordDto userPasswordDto)
        {
            try
            {
                if (isThere(userPasswordDto))
                {
                    return new ResultHelper(false, 0, ResultHelper.SuccessMessage);
                }
                userpassword item = new userpassword();
                item.Password = userPasswordDto.password;
                item.UserID = userPasswordDto.userID;
                item.UserPasswordID = userPasswordDto.userPasswordID;
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<userpassword>().Insert(item);
                    unitofWork.saveChanges();
                    return new ResultHelper(true, item.UserPasswordID, ResultHelper.SuccessMessage);
                }
            }
            catch (Exception ex)
            {
                return new ResultHelper(false, 0, ResultHelper.UnSuccessMessage);
            }
        }
        public ResultHelper SetUserPassword(UserPasswordDto userPasswordDto)
        {
            try
            {
                userpassword item = new userpassword();
                item.Password = userPasswordDto.password;
                item.UserID = userPasswordDto.userID;
                item.UserPasswordID = userPasswordDto.userPasswordID;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<userpassword>().Update(item);
                    unitofWork.saveChanges();
                    return new ResultHelper(true, item.UserPasswordID, ResultHelper.SuccessMessage);
                }
            }
            catch (Exception)
            {
                return new ResultHelper(false, userPasswordDto.userPasswordID, ResultHelper.UnSuccessMessage);
            }
        }
        public ResultHelper DelUserPassword(int UserPasswordID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedUserPassword = unitofWork.GetRepository<userpassword>().GetById(x => x.UserPasswordID == UserPasswordID);
                    unitofWork.GetRepository<userpassword>().Delete(selectedUserPassword);
                    unitofWork.saveChanges();
                    return new ResultHelper(true, selectedUserPassword.UserPasswordID, ResultHelper.SuccessMessage);
                }
            }
            catch (Exception)
            {
                return new ResultHelper(false, UserPasswordID, ResultHelper.UnSuccessMessage);
            }
        }
        public UserPasswordDto GetUserPassword(int UserPasswordID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    userpassword item = new userpassword();
                    item = unitofWork.GetRepository<userpassword>().GetById(x => x.UserPasswordID == UserPasswordID);
                    UserPasswordDto userPasswordDto = new UserPasswordDto();
                    item.Password = userPasswordDto.password;
                    item.UserID = userPasswordDto.userID;
                    item.UserPasswordID = userPasswordDto.userPasswordID;

                    return userPasswordDto;
                }
            }
            catch (Exception)
            {
                return new UserPasswordDto();
            }
        }
        public bool isThere(UserPasswordDto userPasswordDto)
        {
            using (UnitOfWork unitofWork = new UnitOfWork())
            {
                var item = unitofWork.GetRepository<userpassword>().GetById(x => x.UserPasswordID == userPasswordDto.userPasswordID && x.Password == userPasswordDto.password&&x.UserID== userPasswordDto.userID);
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
