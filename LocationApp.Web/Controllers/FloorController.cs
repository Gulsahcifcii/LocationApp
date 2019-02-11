using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class FloorController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int FloorID, int BlockID, string Name, string Other,string Map)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int FloorID)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int FloorID, int BlockID, string Name, string Other, string Map)
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