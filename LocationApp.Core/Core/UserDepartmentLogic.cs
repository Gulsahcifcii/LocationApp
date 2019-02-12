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
    public class UserDepartmenLogic
    {
        WebOperationContext webOperationContext = WebOperationContext.Current;

        public string AddUserDepartment(UserDepartmentDto userDepartmentDto)
        {
            try
            {
                userdepartment item = new userdepartment();
                item.UserID = userDepartmentDto.UserID;
                item.UserDepartmentID = userDepartmentDto.UserDepartmentID;
                item.DepartmentID = userDepartmentDto.DepartmentID;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<userdepartment>().Insert(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }

        public string SetUserDepartment(UserDepartmentDto userDepartmentDto)
        {
            try
            {
                userdepartment item = new userdepartment();
                item.UserID = userDepartmentDto.UserID;
                item.UserDepartmentID = userDepartmentDto.UserDepartmentID;
                item.DepartmentID = userDepartmentDto.DepartmentID;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<userdepartment>().Update(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelUserDepartment(int UserDepartmentID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedUserDepartment = unitofWork.GetRepository<userdepartment>().GetById(x => x.UserDepartmentID == UserDepartmentID);
                    unitofWork.GetRepository<userdepartment>().Delete(selectedUserDepartment);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public UserDepartmentDto GetUserDepartment(int UserDepartmentID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    userdepartment item = new userdepartment();
                    item = unitofWork.GetRepository<userdepartment>().GetById(x => x.UserDepartmentID == UserDepartmentID);
                    UserDepartmentDto userDepartmentDto = new UserDepartmentDto();
                    item.UserID = userDepartmentDto.UserID;
                    item.UserDepartmentID = userDepartmentDto.UserDepartmentID;
                    item.DepartmentID = userDepartmentDto.DepartmentID;

                    return userDepartmentDto;
                }
            }
            catch (Exception)
            {
                return new UserDepartmentDto();
            }
        }
    }
}
