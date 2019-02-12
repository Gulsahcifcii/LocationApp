using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LocationApp.Web.Controllers
{
    public class SubUnitController : Controller
    {
        readonly LocationApp.Service.Services.SubUnitService subUnitService = new Service.Services.SubUnitService();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int SubUnitID, string Name, string Description, string Other)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int campusID, string name, string description, string other)
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