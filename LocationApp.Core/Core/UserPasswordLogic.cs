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
    public class UserPasswordLogic
    {
        WebOperationContext webOperationContext = WebOperationContext.Current;

        public string AddUserPassword(UserPasswordDto userPasswordDto)
        {
            try
            {
                userpassword item = new userpassword();
                item.Password = userPasswordDto.password;
                item.UserID = userPasswordDto.userID;
                item.UserPasswordID = userPasswordDto.userPasswordID;


                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<userpassword>().Insert(item);
                    unitofWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }

        public string SetUserPassword(UserPasswordDto userPasswordDto)
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
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelUserPassword(int UserPasswordID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedUserPassword = unitofWork.GetRepository<userpassword>().GetById(x => x.UserPasswordID == UserPasswordID);
                    unitofWork.GetRepository<userpassword>().Delete(selectedUserPassword);
                    unitofWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
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


     
    }
}
