using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class SiteController : Controller
    {
        [HttpGet]
        public IActionResult Create(int SiteID)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int SiteID, string Name, string Description, string Gps)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int SiteID)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int SiteID, string Name, string Description, string Gps)
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