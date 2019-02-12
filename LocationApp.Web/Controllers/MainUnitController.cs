using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class MainUnitController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int MainUnitID, string Name)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int MainUnitID)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int MainUnitID, string Name)
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