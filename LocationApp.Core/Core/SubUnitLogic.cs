using LocationApp.Core.Helper;
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
        public ResultHelper AddSubUnit(SubUnitDto subUnitDto)
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
                    return new ResultHelper(true, subUnitDto.SubUnitID, "İşlem Başarılı !");
                }
            }
            catch (Exception ex)
            {
                return new ResultHelper(false, subUnitDto.SubUnitID, "İşlem Başarılı !");
            }
        }
        public ResultHelper SetSubUnit(SubUnitDto subUnitDto)
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
                    return new ResultHelper(true, subUnitDto.SubUnitID, "İşlem Başarılı !");
                }
            }
            catch (Exception ex)
            {
                return new ResultHelper(false, subUnitDto.SubUnitID, "İşlem Başarılı !");
            }
        }
        public ResultHelper DelSubUnit(int subUnitID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedSubUnit = unitofWork.GetRepository<subunit>().GetById(x => x.SubUnitID == subUnitID);
                    unitofWork.GetRepository<subunit>().Delete(selectedSubUnit);
                    unitofWork.saveChanges();
                    return new ResultHelper(true, subUnitID, "İşlem Başarılı !");
                }
            }
            catch (Exception)
            {
                return new ResultHelper(false, subUnitID, "İşlem Başarılı !");
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
        public List<SubUnitDto> GetAllSubUnit(int mainUnitID)
        {
            try
            {
                List<subunit> collection;
                List<SubUnitDto> list = new List<SubUnitDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    if (mainUnitID != 0)
                        collection = unitofWork.GetRepository<subunit>().Select(null, null)
                            .Where(a => a.MainUnitID == mainUnitID).ToList();
                    else
                        collection = unitofWork.GetRepository<subunit>().Select(null, null).ToList();

                    foreach (var item in collection)
                    {
                        list.Add(new SubUnitDto { SubUnitID = item.SubUnitID, Name = item.Name, MainUnitID = (int)item.MainUnitID });
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<SubUnitDto>();
            }
        }

    }
}
