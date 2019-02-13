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
    public class FloorLogic
    {
        public ResultHelper AddFloor(FloorDto floorDto)
        {
            try
            {
                floor item = new floor();
                item.FloorID = floorDto.FloorID;
                item.Map = floorDto.Map;
                item.Name = floorDto.Name;
                item.Other = floorDto.Other;
                item.BlockID = floorDto.BlockID;
                item.BuildID = floorDto.BuildID;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<floor>().Insert(item);
                    unitofWork.saveChanges();
                    return new ResultHelper(true, floorDto.FloorID, "İşlem Başarılı !");
                }
            }
            catch (Exception ex)
            {
                return new ResultHelper(false, floorDto.FloorID, "İşlem Başarılı !");
            }
        }
        public ResultHelper SetFloor(FloorDto floorDto)
        {
            try
            {
                floor item = new floor();
                item.FloorID = floorDto.FloorID;
                item.Map = floorDto.Map;
                item.Name = floorDto.Name;
                item.Other = floorDto.Other;
                item.BlockID = floorDto.BlockID;
                item.BuildID = floorDto.BuildID;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<floor>().Update(item);
                    unitofWork.saveChanges();
                    return new ResultHelper(true, floorDto.FloorID, "İşlem Başarılı !");
                }
            }
            catch (Exception ex)
            {
                return new ResultHelper(false, floorDto.FloorID, "İşlem Başarılı !");
            }
        }
        public ResultHelper DelFloor(int floorID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedFloor = unitofWork.GetRepository<floor>().GetById(x => x.FloorID == floorID);
                    unitofWork.GetRepository<floor>().Delete(selectedFloor);
                    unitofWork.saveChanges();
                    return new ResultHelper(true, floorID, "İşlem Başarılı !");
                }
            }
            catch (Exception)
            {
                return new ResultHelper(false, floorID, "İşlem Başarılı !");
            }
        }
        public FloorDto GetFloor(int floorID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    floor item = new floor();
                    item = unitofWork.GetRepository<floor>().GetById(x => x.FloorID == floorID);
                    FloorDto floorDto = new FloorDto();
                    floorDto.FloorID = item.FloorID;
                    floorDto.Map = item.Map;
                    floorDto.Name = item.Name;
                    floorDto.Other = item.Other;
                    floorDto.BlockID = (int)item.BlockID;
                    floorDto.BuildID = (int)item.BuildID;

                    return floorDto;
                }
            }
            catch (Exception)
            {
                return new FloorDto();
            }
        }

        public List<FloorDto> GetAllFloor()
        {
            try
            {
                List<FloorDto> list = new List<FloorDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    List<floor> collection = unitofWork.GetRepository<floor>().Select(null, null).ToList();
                    foreach (var item in collection)
                    {
                        list.Add(new FloorDto {BlockID=item.BlockID.Value,BuildID=item.BuildID.Value,FloorID=item.FloorID,Map=item.Map,Name=item.Name,Other=item.Other });
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<FloorDto>();
            }
        }
    }
}
