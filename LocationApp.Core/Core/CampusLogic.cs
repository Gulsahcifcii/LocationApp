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
        WebOperationContext webOperationContext = WebOperationContext.Current;
        public string AddCampus(CampusDto campusDto)
        {
            try
            {
                campu item = new campu();
                item.CampusID = campusDto.CampusID;
                item.Description = campusDto.Description;
                item.Other = campusDto.Other;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<campu>().Insert(item);
                    unitofWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
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

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<campu>().Update(item);
                    unitofWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
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
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
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
    }
}
