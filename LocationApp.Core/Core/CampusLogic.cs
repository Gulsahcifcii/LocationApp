using LocationApp.Data.Database;
using LocationApp.Data.Dto;
using LocationApp.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Core.Core
{
    public class CampusLogic
    {
        //TODO: servis sonuçları woc ile gönderilmeli.
        //WebOperationContext webOperationContext = WebOperationContext.Current;
        //WebOperationContext.Current.OutgoingResponse.StatusCode
        public string AddCampus(CampusDto campusDto)
        {
            try
            {
                #region ANY RECORD
                if (isThere(campusDto))
                    return (HttpStatusCode.InternalServerError).ToString();
                #endregion

                campu item = new campu();
                item.Name = campusDto.Name;
                item.CampusID = campusDto.CampusID;
                item.Description = campusDto.Description;
                item.Other = campusDto.Other;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<campu>().Insert(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string SetCampus(CampusDto campusDto)
        {
            try
            {
                campu item = new campu();
                item.CampusID = campusDto.CampusID;
                item.Description = campusDto.Description;
                item.Other = campusDto.Other;
                item.Name = campusDto.Name;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<campu>().Update(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelCampus(int campusID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedCampus = unitofWork.GetRepository<campu>().GetById(x => x.CampusID == campusID);
                    unitofWork.GetRepository<campu>().Delete(selectedCampus);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public CampusDto GetCampus(int campusID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    campu item = new campu();
                    item = unitofWork.GetRepository<campu>().GetById(x => x.CampusID == campusID);
                    CampusDto campusDto = new CampusDto();
                    campusDto.CampusID = item.CampusID;
                    campusDto.Name = item.Name;
                    campusDto.Description = item.Description;
                    campusDto.Other = item.Other;
                    return campusDto;
                }
            }
            catch (Exception ex)
            {
                return new CampusDto();
            }
        }
        public bool isThere(CampusDto campusDto)
        {
            using (UnitOfWork unitofWork = new UnitOfWork())
            {
                var item = unitofWork.GetRepository<campu>().GetById(x => x.Name.ToUpper() == campusDto.Name.ToUpper());
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
        public List<CampusDto> GetAllCampus()
        {
            try
            {
                List<CampusDto> list = new List<CampusDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    List<campu> collection = unitofWork.GetRepository<campu>().Select(null,null).ToList();
                    foreach (var item in collection)
                    {
                        list.Add(new CampusDto { CampusID = item.CampusID, Description = item.Description, Name = item.Name, Other = item.Other });
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<CampusDto>();
            }
        }
    }
}
