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
    public class RoomTypeController : Controller
    {
        readonly LocationApp.Service.Services.RoomTypeService roomTypeService = new Service.Services.RoomTypeService();
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int RoomTypeID, string Name, string Description)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>(
                 roomTypeService.AddRoomType(0, Name, Description));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var item = roomTypeService.GetRoomType(id.Value);
            var result = JsonConvert.DeserializeObject<RoomTypeDto>(item);
            if (result != null)
            {
                return View(result);
            }
            else
                return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(int RoomTypeID, string Name, string Description)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (roomTypeService.SetRoomType(RoomTypeID, Name, Description));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<RoomTypeDto>>(roomTypeService.GetAllRoomType()));
        }
    }
}