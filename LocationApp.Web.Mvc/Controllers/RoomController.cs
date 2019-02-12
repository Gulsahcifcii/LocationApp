using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LocationApp.Web.Controllers
{
    public class RoomController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int RoomID,int FloorID,int RoomTypeID, string Map)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int RoomTypeID)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int RoomID, int FloorID, int RoomTypeID, string Map)
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