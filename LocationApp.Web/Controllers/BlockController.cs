using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class BlockController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int blockId, int buildId, string name, string gps)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int blockId)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int blockId, int buildId, string name, string gps)
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