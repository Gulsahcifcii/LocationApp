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
    public class RoomLogic
    {
        public ResultHelper AddRoom(RoomDto roomDto)
        {
            try
            {
                room item = new room();
                item.FloorID = roomDto.FloorID;
                item.Map = roomDto.Map;
                item.Name = roomDto.Name;
                item.RoomID = roomDto.RoomID;
                item.RoomTypeID = roomDto.RoomTypeID;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<room>().Insert(item);
                    unitofWork.saveChanges();
                    return new ResultHelper(true, roomDto.RoomID, "İşlem Başarılı !");

                }
            }
            catch (Exception ex)
            {
                return new ResultHelper(false, roomDto.RoomID, "İşlem Başarılı !");
            }
        }
        public ResultHelper SetRoom(RoomDto roomDto)
        {
            try
            {
                room item = new room();
                item.FloorID = roomDto.FloorID;
                item.Map = roomDto.Map;
                item.Name = roomDto.Name;
                item.RoomID = roomDto.RoomID;
                item.RoomTypeID = roomDto.RoomTypeID;
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<room>().Update(item);
                    unitofWork.saveChanges();
                    return new ResultHelper(true, roomDto.RoomID, "İşlem Başarılı !");
                }
            }
            catch (Exception ex)
            {
                return new ResultHelper(false, roomDto.RoomID, "İşlem Başarılı !");
            }
        }
        public ResultHelper DelRoom(int roomID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedRoom = unitofWork.GetRepository<room>().GetById(x => x.RoomID == roomID);
                    unitofWork.GetRepository<room>().Delete(selectedRoom);
                    unitofWork.saveChanges();
                    return new ResultHelper(true, roomID, "İşlem Başarılı !");
                }
            }
            catch (Exception)
            {
                return new ResultHelper(false, roomID, "İşlem Başarılı !");
            }
        }
        public RoomDto GetRoom(int roomID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    room item = new room();
                    item = unitofWork.GetRepository<room>().GetById(x => x.RoomID == roomID);
                    RoomDto roomDto = new RoomDto();
                    roomDto.FloorID = (int)item.FloorID;
                    roomDto.RoomID = item.RoomID;
                    roomDto.RoomTypeID = (int)item.RoomTypeID;
                    roomDto.Name = item.Name;
                    roomDto.Map = item.Map;

                    return roomDto;
                }
            }
            catch (Exception)
            {
                return new RoomDto();
            }
        }
        public List<RoomDto> GetAllRoom()
        {
            try
            {
                List<RoomDto> list = new List<RoomDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    List<room> collection = unitofWork.GetRepository<room>().Select(null, null).ToList();
                    foreach (var item in collection)
                    {
                        list.Add(new RoomDto {FloorID=item.FloorID.Value,Map=item.Map,Name=item.Name,RoomID=item.RoomID,RoomTypeID=item.RoomTypeID.Value});
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<RoomDto>();
            }
        }
    }
}
