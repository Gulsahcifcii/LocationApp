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
    public class UserRoleLogic
    {
        WebOperationContext webOperationContext = WebOperationContext.Current;
        public string AddUserRole(UserRoleDto userRoleDto)
        {
            try
            {
                userrole item = new userrole();
                item.UserRoleID = userRoleDto.UserRoleID;
                item.UserRoleName = userRoleDto.UserRoleName;
                item.UserRoleDescription = userRoleDto.UserRoleDescription;
                item.Active = userRoleDto.Active;

                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.GetRepository<userrole>().Insert(item);
                    unitOfWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string SetUserRole(UserRoleDto userRoleDto)
        {
            try
            {
                userrole item = new userrole();
                item.UserRoleID = userRoleDto.UserRoleID;
                item.UserRoleName = userRoleDto.UserRoleName;
                item.UserRoleDescription = userRoleDto.UserRoleDescription;
                item.Active = userRoleDto.Active;

                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.GetRepository<userrole>().Insert(item);
                    unitOfWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString(); ;
            }
        }
        public UserRoleDto GetUserRole(int userRoleID)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    userrole item = new userrole();
                    item = unitOfWork.GetRepository<userrole>().GetById(x => x.UserRoleID == userRoleID);
                    UserRoleDto userRoleDto = new UserRoleDto();
                    userRoleDto.UserRoleName = item.UserRoleName;
                    userRoleDto.UserRoleDescription = item.UserRoleDescription;
                    userRoleDto.Active = Convert.ToBoolean( item.Active);

                    return userRoleDto;
                }
            }
            catch (Exception)
            {
                return new UserRoleDto();
            }
        }
        public string DelUserRole(int userRoleID)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    var selectedUserRoleID = unitOfWork.GetRepository<userrole>().GetById(x => x.UserRoleID == userRoleID);
                    unitOfWork.GetRepository<userrole>().Delete(selectedUserRoleID);
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
