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
    public class UserContactTypeLogic
    {
        WebOperationContext webOperationContext = WebOperationContext.Current;
        public string AddUserContactType(UserContactTypeDto userContactTypeDto)
        {
            try
            {
                usercontacttype item = new usercontacttype();
                item.UserContactTypeID = userContactTypeDto.UserContactTypeID;
                item.TypeName = userContactTypeDto.TypeName;
                item.Description = userContactTypeDto.Description;

                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.GetRepository<usercontacttype>().Insert(item);
                    unitOfWork.saveChanges();
                    return(webOperationContext.OutgoingResponse.StatusCode=HttpStatusCode.OK).ToString();
                }
            }
            catch(Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string SetUserContactType(UserContactTypeDto userContactTypeDto)
        {
            try
            {
                usercontacttype item = new usercontacttype();
                item.UserContactTypeID = userContactTypeDto.UserContactTypeID;
                item.TypeName = userContactTypeDto.TypeName;
                item.Description = userContactTypeDto.Description;

                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.GetRepository<usercontacttype>().Update(item);
                    unitOfWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch(Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public UserContactTypeDto GetUserContactType(int userContactTypeID)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    usercontacttype item = new usercontacttype();
                    item = unitOfWork.GetRepository<usercontacttype>().GetById(x => x.UserContactTypeID == userContactTypeID);
                    UserContactTypeDto userContactTypeDto = new UserContactTypeDto();
                    userContactTypeDto.TypeName = item.TypeName;
                    userContactTypeDto.UserContactTypeID = item.UserContactTypeID;

                    return userContactTypeDto;
                }
            }
            catch (Exception)
            {
                return new UserContactTypeDto();                
            }
        }
        public string DelUserContactType(int userContactTypeID)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    var selectedUserContactType = unitOfWork.GetRepository<usercontacttype>().GetById(x => x.UserContactTypeID == userContactTypeID);
                    unitOfWork.GetRepository<usercontacttype>().Delete(selectedUserContactType);
                    unitOfWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();

                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public List<UserContactTypeDto> GetAllUserContactType()
        {
            try
            {
                List<UserContactTypeDto> list = new List<UserContactTypeDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    List<UserContactTypeDto> collection = unitofWork.GetRepository<UserContactTypeDto>().Select(null, null).ToList();
                    foreach (var item in collection)
                    {
                        list.Add(new UserContactTypeDto {UserContactTypeID=item.UserContactTypeID,TypeName=item.TypeName,Description=item.Description});
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<UserContactTypeDto>();
            }
        }
    }
}
