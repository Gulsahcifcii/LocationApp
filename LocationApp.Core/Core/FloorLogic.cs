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
                    return new ResultHelper(true, item.FloorID, ResultHelper.SuccessMessage);
                }
            }
            catch (Exception ex)
            {
                return new ResultHelper(false, floorDto.FloorID, ResultHelper.UnSuccessMessage);
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
                    return new ResultHelper(true, floorDto.FloorID, ResultHelper.SuccessMessage);
                }
            }
            catch (Exception ex)
            {
                return new ResultHelper(false, floorDto.FloorID, ResultHelper.UnSuccessMessage);
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
                    return new ResultHelper(true, floorID, ResultHelper.SuccessMessage);
                }
            }
            catch (Exception)
            {
                return new ResultHelper(false, floorID, ResultHelper.UnSuccessMessage);
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
                        FloorDto fDto = new FloorDto();
                        fDto.FloorID = item.FloorID;
                        fDto.Name = item.Name;
                        fDto.Map = item.Map;
                        fDto.Other = item.Other;
                        fDto.BuildID = item.BuildID.Value;
                        fDto.BlockID = item.BlockID.Value;
                        if (item.BuildID != 0)
                        {
                            var fBuild = unitofWork.GetRepository<build>().GetById(a => a.BuildID == fDto.BuildID);
                            fDto.BuildDto = new BuildDto();
                            fDto.BuildDto.BuildID = fBuild.BuildID;
                            fDto.BuildDto.Name = fBuild.Name;
                        }
                        if (item.BlockID != 0)
                        {
                            fDto.BlockDto = new BlockDto();
                            var fBlock = unitofWork.GetRepository<block>().GetById(a => a.BlockID == fDto.BlockID);
                            fDto.BlockDto.BlockID = fBlock.BlockID;
                            fDto.BlockDto.Name = fBlock.Name;
                        }
                        list.Add(fDto);
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<FloorDto>();
            }
        }

        public List<FloorDto> GetAllFloorByBlockID(int blockID)
        {
            try
            {
                List<FloorDto> list = new List<FloorDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    List<floor> collection = unitofWork.GetRepository<floor>().Select(null,null).Where(a => a.BlockID == blockID).ToList();
                    foreach (var item in collection)
                    {
                        FloorDto fDto = new FloorDto();
                        fDto.FloorID = item.FloorID;
                        fDto.Name = item.Name;
                        fDto.Map = item.Map;
                        fDto.Other = item.Other;
                        fDto.BuildID = item.BuildID.Value;
                        fDto.BlockID = item.BlockID.Value;
                        if (item.BuildID != 0)
                        {
                            var fBuild = unitofWork.GetRepository<build>().GetById(a => a.BuildID == fDto.BuildID);
                            fDto.BuildDto = new BuildDto();
                            fDto.BuildDto.BuildID = fBuild.BuildID;
                            fDto.BuildDto.Name = fBuild.Name;
                        }
                        if (item.BlockID != 0)
                        {
                            fDto.BlockDto = new BlockDto();
                            var fBlock = unitofWork.GetRepository<block>().GetById(a => a.BlockID == fDto.BlockID);
                            fDto.BlockDto.BlockID = fBlock.BlockID;
                            fDto.BlockDto.Name = fBlock.Name;
                        }
                        list.Add(fDto);
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<FloorDto>();
            }
        }

        public List<FloorDto> GetAllFloorByBuildID(int buildID)
        {
            try
            {
                List<FloorDto> list = new List<FloorDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    List<floor> collection = unitofWork.GetRepository<floor>().Select(null,null).Where(a=>a.BuildID==buildID).ToList();
                    foreach (var item in collection)
                    {
                        FloorDto fDto = new FloorDto();
                        fDto.FloorID = item.FloorID;
                        fDto.Name = item.Name;
                        fDto.Map = item.Map;
                        fDto.Other = item.Other;
                        fDto.BuildID = item.BuildID.Value;
                        fDto.BlockID = item.BlockID.Value;
                        if (item.BuildID != 0)
                        {
                            var fBuild = unitofWork.GetRepository<build>().GetById(a => a.BuildID == fDto.BuildID);
                            fDto.BuildDto = new BuildDto();
                            fDto.BuildDto.BuildID = fBuild.BuildID;
                            fDto.BuildDto.Name = fBuild.Name;
                        }
                        if (item.BlockID != 0)
                        {
                            fDto.BlockDto = new BlockDto();
                            var fBlock = unitofWork.GetRepository<block>().GetById(a => a.BlockID == fDto.BlockID);
                            fDto.BlockDto.BlockID = fBlock.BlockID;
                            fDto.BlockDto.Name = fBlock.Name;
                        }
                        list.Add(fDto);
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
