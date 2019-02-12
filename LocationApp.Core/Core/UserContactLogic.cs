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
    public class UserContactLogic
    {
        WebOperationContext webOperationContext = WebOperationContext.Current;
        public string AddUserContact(UserContactDto userContactDto)
        {
            try
            {
                usercontact item = new usercontact();
                item.UserContactID = userContactDto.UserContactID;
                item.UserID = userContactDto.UserID;
                item.UserContactTypeID = userContactDto.UserContactTypeID;
                item.Contact = userContactDto.Contact;


                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<usercontact>().Insert(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }

        public string SetUserContact(UserContactDto userContactDto)
        {
            try
            {
                usercontact item = new usercontact();
                item.UserContactID = userContactDto.UserContactID;
                item.UserID = userContactDto.UserID;
                item.UserContactTypeID = userContactDto.UserContactTypeID;
                item.Contact = userContactDto.Contact;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<usercontact>().Update(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }

        public string DelUserContact(int UserContactID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedUserContact = unitofWork.GetRepository<usercontact>().GetById(x => x.UserContactID == UserContactID);
                    unitofWork.GetRepository<usercontact>().Delete(selectedUserContact);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public UserContactDto GetUserContact(int UserContactID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    usercontact item = new usercontact();
                    item = unitofWork.GetRepository<usercontact>().GetById(x => x.UserContactID == UserContactID);
                    UserContactDto userContactDto = new UserContactDto();
                    item.UserContactID = userContactDto.UserContactID;
                item.UserID = userContactDto.UserID;
                item.UserContactTypeID = userContactDto.UserContactTypeID;
                item.Contact = userContactDto.Contact;

                    return userContactDto;
                }
            }
            catch (Exception)
            {
                return new UserContactDto();
            }
        }
    }
}
