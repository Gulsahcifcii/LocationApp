using LocationApp.Data.Database;
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int FloorID, int BlockID, string Name, string Other,string Map)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int FloorID, int BlockID, string Name, string Other, string Map)
        {
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<floor>>(floorService.GetAllFloor()));
        }
    }
}