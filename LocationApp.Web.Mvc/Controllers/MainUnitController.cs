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
    public class MainUnitController : Controller
    {
        readonly LocationApp.Service.Services.MainUnitService mainUnitService = new Service.Services.MainUnitService();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int MainUnitID, string Name)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int MainUnitID, string Name)
        {
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            return View();
        }
    }
}