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

    public class UserUserRoleLogic
    {
        WebOperationContext webOperationContext = WebOperationContext.Current;
        public string AddUserUserRole(UserUserRoleDto userUserRoleDto)
        {
            try
            {
                useruserrole item = new useruserrole();
                item.UserUserRoleID = userUserRoleDto.UserUserRoleID;
                item.UserID = userUserRoleDto.UserID;
                item.UserRoleID = userUserRoleDto.UserRoleID;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<useruserrole>().Insert(item);
                    unitofWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }

        public string SetUserUserRole(UserUserRoleDto userUserRoleDto)
        {
            try
            {
                useruserrole item = new useruserrole();
                item.UserUserRoleID = userUserRoleDto.UserUserRoleID;
                item.UserID = userUserRoleDto.UserID;
                item.UserRoleID = userUserRoleDto.UserRoleID;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<useruserrole>().Update(item);
                    unitofWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelUserUserRole(int UserUserRoleID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedUserTitle = unitofWork.GetRepository<useruserrole>().GetById(x => x.UserUserRoleID == UserUserRoleID);
                    unitofWork.GetRepository<useruserrole>().Delete(selectedUserTitle);
                    unitofWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }
        public UserUserRoleDto GetUserUserRole(int UserUserRoleID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    useruserrole item = new useruserrole();
                    item = unitofWork.GetRepository<useruserrole>().GetById(x => x.UserUserRoleID == UserUserRoleID);
                    UserUserRoleDto userUserRoleDto = new UserUserRoleDto();
                    item.UserUserRoleID = userUserRoleDto.UserUserRoleID;
                    item.UserID = userUserRoleDto.UserID;
                    item.UserRoleID = userUserRoleDto.UserRoleID;

                    return userUserRoleDto;
                }
            }
            catch (Exception)
            {
                return new UserUserRoleDto();
            }
        }

    }
}
