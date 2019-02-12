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
        public ActionResult Edit(int FloorID)
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
            return View();
        }
    }
}