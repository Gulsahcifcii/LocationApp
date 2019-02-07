using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class BuildController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}