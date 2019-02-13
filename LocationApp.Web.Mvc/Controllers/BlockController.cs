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
    public class BlockController : Controller
    {
        LocationApp.Service.Services.BlockService blockService = new Service.Services.BlockService();
        LocationApp.Service.Services.BuildService buildService = new Service.Services.BuildService();
        [HttpGet]
        public ActionResult Create()
        {
            GetBuilds(0);
            return View();
        }
        [HttpPost]
        public ActionResult Create(int BuildID, string Name, string Gps)
        {
            ResultHelper result = JsonConvert.DeserializeObject
                <ResultHelper>(blockService.AddBlock(0, BuildID, Name, Gps));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(false);
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var item = blockService.GetBlock(id.Value);
            var result = JsonConvert.DeserializeObject<BlockDto>(item);
            if (result != null)
            {
                GetBuilds(result.BuildID);
                return View(result);
            }
            else
                return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(int BlockID, int BuildID, string Name, string Gps)
        {
            string result = JsonConvert.DeserializeObject
               (blockService.UpdateBlock(BlockID, BuildID, Name, Gps)
               ).ToString();
            if (result == "OK")
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(false);
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            var item = JsonConvert.DeserializeObject<List<BlockDto>>(blockService.GetAllBlock());
            return View(item);
        }

        void GetBuilds(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<BuildDto>>(buildService.GetAllBuild());
            SelectList slist = new SelectList(list, "BuildID", "Name", selectedValue);
            ViewBag.BuildID = slist;
        }
    }
}