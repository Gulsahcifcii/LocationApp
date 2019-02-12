using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class SubUnitController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int SubUnitID, string Name, string Description, string Other)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int campusID)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int campusID, string name, string description, string other)
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