using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class BuildController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int BuildID, int SiteID, int CampusID, string Name, string Address, string Gps, string Properties)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int BuildID)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int BuildID, int SiteID, int CampusID, string Name, string Address, string Gps, string Properties)
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