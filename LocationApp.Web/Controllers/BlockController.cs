using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class BlockController : Controller
    {
        LocationApp.Service.Services.BlockService blockService = new Service.Services.BlockService();
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int BlockID, int BuildID, string Name, string Gps)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int BlockID)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int BlockID, int BuildID, string Name, string Gps)
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