using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class RoomController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int RoomID,int FloorID,int RoomTypeID, string Map)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int RoomTypeID)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int RoomID, int FloorID, int RoomTypeID, string Map)
        {
            return View();
        }
        [HttpGet]
        public IActionResult List()
        {
            return View();
        }
    }
}