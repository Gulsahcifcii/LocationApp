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
    public class UserTitleLogic
    {
        //WebOperationContext webOperationContext = WebOperationContext.Current;
        public string AddUserTitle(UserTitleDto userTitleDto)
        {
            try
            {
                usertitle item = new usertitle();
                item.UserTitleID = userTitleDto.UserTitleId;
                item.TitleName = userTitleDto.TitleName;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<usertitle>().Insert(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }

        public string SetUserTitle(UserTitleDto userTitleDto)
        {
            try
            {
                usertitle item = new usertitle();
                item.UserTitleID = userTitleDto.UserTitleId;
                item.TitleName = userTitleDto.TitleName;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<usertitle>().Update(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelUserTitle(int userTitleId)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedUserTitle = unitofWork.GetRepository<usertitle>().GetById(x => x.UserTitleID == userTitleId);
                    unitofWork.GetRepository<usertitle>().Delete(selectedUserTitle);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public UserTitleDto GetUserTitle(int userTitleId)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    usertitle item = new usertitle();
                    item = unitofWork.GetRepository<usertitle>().GetById(x => x.UserTitleID == userTitleId);
                    UserTitleDto userTitleDto = new UserTitleDto();
                    userTitleDto.TitleName = item.TitleName;
                    userTitleDto.UserTitleId = item.UserTitleID;

                    return userTitleDto;
                }
            }
            catch (Exception)
            {
                return new UserTitleDto();
            }
        }
        public List<UserTitleDto> GetAllUserTitle()
        {
            try
            {
                List<UserTitleDto> list = new List<UserTitleDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    List<usertitle> collection = unitofWork.GetRepository<usertitle>().Select(null, null).ToList();
                    foreach (var item in collection)
                    {
                        list.Add(new UserTitleDto { TitleName=item.TitleName,UserTitleId=item.UserTitleID});
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<UserTitleDto>();
            }
        }
    }
}
