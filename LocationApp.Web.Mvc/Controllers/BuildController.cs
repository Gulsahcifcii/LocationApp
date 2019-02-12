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
    public class BuildController : Controller
    {
        readonly LocationApp.Service.Services.BuildService buildService = new Service.Services.BuildService();
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int BuildID, int SiteID, int CampusID, string Name, string Address, string Gps, string Properties)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int BuildID, int SiteID, int CampusID, string Name, string Address, string Gps, string Properties)
        {
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<build>>(buildService.GetAllBuild()));
        }
    }
}