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
    public class FloorController : Controller
    {
        readonly LocationApp.Service.Services.FloorService floorService = new Service.Services.FloorService();
        readonly LocationApp.Service.Services.BuildService buildService = new Service.Services.BuildService();
        readonly LocationApp.Service.Services.BlockService blockService = new Service.Services.BlockService();

        [HttpGet]
        public ActionResult Create()
        {
            GetAllBuild(0);
            GetAllBlock(0);
            return View();
        }
        [HttpPost]
        public ActionResult Create(int? BlockID, int? BuildID, string Name, string Other, string Map)
        {
            if (!BlockID.HasValue)
                BlockID = 0;
            if (!BuildID.HasValue)
                BuildID = 0;
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
               (floorService.AddFloor(0, BlockID.Value, BuildID.Value, Name, Other, Map));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var item = floorService.GetFloor(id.Value);
            var result = JsonConvert.DeserializeObject<FloorDto>(item);
            if (result != null)
            {
                GetAllBuild(result.BuildID);
                GetAllBlock(result.BlockID);
                return View(result);
            }
            else
                return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(int FloorID, int BlockID, int BuildID, string Name, string Other, string Map)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
              (floorService.SetFloor(FloorID, BlockID, BuildID, Name, Other, Map));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<FloorDto>>(floorService.GetAllFloor()));
        }

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
            SelectList slist = new SelectList(list, "BlockID", "Name", selectedValue);
            list.Insert(0, new BlockDto { BlockID = 0, Name = "Seçiniz" });
            ViewBag.BlockID = slist;
        }
    }
}