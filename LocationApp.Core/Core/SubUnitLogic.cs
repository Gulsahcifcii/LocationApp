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
    public class SubUnitLogic
    {
        WebOperationContext webOperationContext = WebOperationContext.Current;
        public string AddSubUnit(SubUnitDto subUnitDto)
        {
            try
            {
                subunit item = new subunit();
                item.SubUnitID = subUnitDto.SubUnitID;
                item.MainUnitID = subUnitDto.MainUnitID;
                item.Name = subUnitDto.Name;
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<subunit>().Insert(item);
                    unitofWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string SetSubUnit(SubUnitDto subUnitDto)
        {
            try
            {
                subunit item = new subunit();
                item.SubUnitID = subUnitDto.SubUnitID;
                item.MainUnitID = subUnitDto.MainUnitID;
                item.Name = subUnitDto.Name;
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<subunit>().Update(item);
                    unitofWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelSubUnit(int subUnitID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedSubUnit = unitofWork.GetRepository<subunit>().GetById(x => x.SubUnitID == subUnitID);
                    unitofWork.GetRepository<subunit>().Delete(selectedSubUnit);
                    unitofWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }
        public SubUnitDto GetSubUnit(int subUnitID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    subunit item = new subunit();
                    item = unitofWork.GetRepository<subunit>().GetById(x => x.SubUnitID == subUnitID);
                    SubUnitDto subUnitDto = new SubUnitDto();
                    subUnitDto.SubUnitID = item.SubUnitID;
                    subUnitDto.Name = item.Name;
                    subUnitDto.MainUnitID = (int)item.MainUnitID;
                    return subUnitDto;
                }
            }
            catch (Exception)
            {
                return new SubUnitDto();
            }
        }
    }
}
