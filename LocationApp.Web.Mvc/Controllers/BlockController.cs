using LocationApp.Data.Database;
using LocationApp.Data.Dto;
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
            GetDropDownListForSite();
            return View();
        }
        [HttpPost]
        public ActionResult Create(int BlockID, int BuildID, string Name, string Gps)
        {
            var result = JsonConvert.DeserializeObject(blockService.AddBlock(BlockID, BuildID, Name, Gps));
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int BlockID, int BuildID, string Name, string Gps)
        {
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<block>>(blockService.GetAllBlock()));
        }

        void GetDropDownListForSite()
        {
            var list = JsonConvert.DeserializeObject<List<BuildDto>>(buildService.GetAllBuild());
            SelectList slist = new SelectList(list, "BuildID", "Name");
            ViewBag.SiteID = slist;
        }
    }
}