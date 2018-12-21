using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using LocationApp.Data.Dto;
using LocationApp.Data.UnitOfWork;
using System.Net;
using LocationApp.Data.Database;

namespace LocationApp.Core.Core
{
    public class UserLoginLogic
    {
        WebOperationContext webOperationContext = WebOperationContext.Current;

        public string AddUserLogin(UserLoginDto userLoginDto)
        {
            try
            {
                userlogin item = new userlogin();
                item.UserLoginID = userLoginDto.UserLoginID;
                item.Password = userLoginDto.Password;
                item.IpAdress = userLoginDto.IpAdress;
                item.UserID = userLoginDto.UserID;


                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.GetRepository<userlogin>().Insert(item);
                    unitOfWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }

            }
            catch (Exception ex)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }

        public string SetUserLogin(UserLoginDto userLoginDto)
        {
            try
            {
                userlogin item = new userlogin();
                item.UserLoginID = userLoginDto.UserLoginID;
                item.Password = userLoginDto.Password;
                item.IpAdress = userLoginDto.IpAdress;
                item.UserID = userLoginDto.UserID;

                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.GetRepository<userlogin>().Insert(item);
                    unitOfWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }
        public UserLoginDto GetUserLogin(int userLoginID)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    userlogin item = new userlogin();
                    item = unitOfWork.GetRepository<userlogin>().GetById(x => x.UserLoginID == userLoginID);
                    UserLoginDto userLoginDto = new UserLoginDto();
                    userLoginDto.Password = item.Password;
                    userLoginDto.CreationDate = Convert.ToDateTime(item.CreationDate); //TODO: tarih parse işlemi gerekiyor mu?
                    userLoginDto.IpAdress = item.IpAdress;
                    userLoginDto.UserID = Convert.ToInt32(item.UserID);

                    return userLoginDto;
                }
            }
            catch (Exception)
            {
                return new UserLoginDto();
            }
        }
        public string DelUserLogin(int userLoginID)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    var selectedUserLoginID = unitOfWork.GetRepository<userlogin>().GetById(x => x.UserLoginID == userLoginID);
                    unitOfWork.GetRepository<userlogin>().Delete(selectedUserLoginID);
                    unitOfWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();

                }
            }
            catch (Exception ex)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }
    }
}
