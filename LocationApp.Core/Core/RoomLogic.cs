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
        WebOperationContext webOperationContext = WebOperationContext.Current;
        public string AddRoom(RoomDto roomDto)
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
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string SetRoom(RoomDto roomDto)
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
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelRoom(int roomID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedRoom = unitofWork.GetRepository<room>().GetById(x => x.RoomID == roomID);
                    unitofWork.GetRepository<room>().Delete(selectedRoom);
                    unitofWork.saveChanges();
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
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
    }
}
