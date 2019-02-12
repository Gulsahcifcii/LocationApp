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
    public class SiteController : Controller
    {
        readonly LocationApp.Service.Services.SiteService siteService = new Service.Services.SiteService();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int SiteID, string Name, string Description, string Gps)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int SiteID, string Name, string Description, string Gps)
        {
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<site>>(siteService.GetAllSite()));
        }
    }
}