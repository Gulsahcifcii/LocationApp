using LocationApp.Core.Helper;
using LocationApp.Data.Database;
using LocationApp.Data.Dto;
using LocationApp.Web.Mvc.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LocationApp.Web.Controllers
{
    public class RoomController : Controller
    {
        readonly LocationApp.Service.Services.RoomService roomService = new Service.Services.RoomService();
        readonly LocationApp.Service.Services.BuildService buildService = new Service.Services.BuildService();
        readonly LocationApp.Service.Services.BlockService blockService = new Service.Services.BlockService();
        readonly LocationApp.Service.Services.DepartmentService department = new Service.Services.DepartmentService();
        readonly LocationApp.Service.Services.DepartmentRoomService departmentRoomService = new Service.Services.DepartmentRoomService();
        readonly LocationApp.Service.Services.FloorService floorService = new Service.Services.FloorService();
        readonly LocationApp.Service.Services.RoomTypeService roomTypeService = new Service.Services.RoomTypeService();


        [HttpGet]
        public ActionResult Create()
        {
            GetAllBuild(0);
            GetAllBlock(0);
            GetAllRoomType(0);
            GetAllFloor(0);
            GetAllDepartment(0);
            return View();
        }
        [HttpPost]
        public ActionResult Create(int? BuildID, int? BlockID, int? FloorID, int? DepartmentID, int? RoomTypeID, string Name, string Map)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (roomService.AddRoom(0, FloorID.Value, Name, RoomTypeID.Value, Map));
            if (result.Result)
            {
                ResultHelper resultC = JsonConvert.DeserializeObject<ResultHelper>
                    (departmentRoomService.AddDepartmentRoom(0, DepartmentID.Value, result.ResultSet, ""));
                if (resultC.Result)
                {
                    return RedirectToAction("List");
                }
                else
                    ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            }
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            int buildID = 0;
            int blockID = 0;
            var item = JsonConvert.DeserializeObject<RoomDto>
                            (roomService.GetRoom(id.Value));
            if (item.BuildDto != null)
                buildID = item.BuildDto.BuildID;
            if (item.BlockDto != null)
                blockID = item.BlockDto.BlockID;

            GetAllBuild(buildID);
            GetAllBlock(blockID);
            GetAllRoomType(item.RoomTypeID);
            GetAllFloor(item.FloorID);
            GetAllDepartment(item.DepartmentDto.DepartmentID);
            return View(item);
        }
        [HttpPost]
        public ActionResult Edit(int DepartmentRoomID, int DepartmentID, string Name, int RoomID, int FloorID, int RoomTypeID, string Map)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
     (roomService.SetRoom(RoomID, FloorID, Name, RoomTypeID, Map));
            if (result.Result)
            {
                ResultHelper resultC = JsonConvert.DeserializeObject<ResultHelper>
                    (departmentRoomService.UpdateDepartmentRoom(DepartmentRoomID, DepartmentID, result.ResultSet, ""));
                if (resultC.Result)
                {
                    return RedirectToAction("List");
                }
                else
                    ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            }
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {

            return View(JsonConvert.DeserializeObject<List<RoomDto>>(roomService.GetAllRoom()));
        }
        [HttpGet]
        public JsonResult GetFloorByBlockID(int blockID)
        {
            var data = JsonConvert.DeserializeObject<List<FloorDto>>(floorService.GetAllFloorByBlockID(blockID));
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetFloorByBuildID(int buildID)
        {
            var data = JsonConvert.DeserializeObject<List<SubUnitDto>>(floorService.GetAllFloorByBuildID(buildID));
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        #region Dropdownlist
        void GetAllBuild(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<BuildDto>>(buildService.GetAllBuild());
            list.Insert(0, new BuildDto { BuildID = 0, Name = "Seçiniz" });
            SelectList slist = new SelectList(list, "BuildID", "Name", selectedValue);
            ViewBag.BuildID = slist;
        }
        void GetAllBlock(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<BlockDto>>(blockService.GetAllBlock());
            list.Insert(0, new BlockDto { BlockID = 0, Name = "Seçiniz" });
            SelectList slist = new SelectList(list, "BlockID", "Name", selectedValue);
            ViewBag.BlockID = slist;
        }
        void GetAllRoomType(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<RoomTypeDto>>(roomTypeService.GetAllRoomType());
            SelectList slist = new SelectList(list, "RoomTypeID", "Name", selectedValue);
            list.Insert(0, new RoomTypeDto { RoomTypeID = 0, Name = "Seçiniz" });
            ViewBag.RoomTypeID = slist;
        }
        void GetAllFloor(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<FloorDto>>(floorService.GetAllFloor());
            list.Insert(0, new FloorDto { FloorID = 0, Name = "Seçiniz" });
            SelectList slist = new SelectList(list, "FloorID", "Name", selectedValue);
            ViewBag.FloorID = slist;
        }
        void GetAllDepartment(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<DepartmentDto>>(department.GetAllDepartment());
            SelectList slist = new SelectList(list, "DepartmentID", "Name", selectedValue);
            list.Insert(0, new DepartmentDto { DepartmentID = 0, Name = "Seçiniz" });
            ViewBag.DepartmentID = slist;
        }
        #endregion
    }
}