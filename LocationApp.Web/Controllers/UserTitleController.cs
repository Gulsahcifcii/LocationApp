using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class UserTitleController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int UserTitleID, string TitleName)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int UserTitleID)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
    }
}