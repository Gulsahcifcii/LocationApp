using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class UserContactController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int UserContactID, string Contact, int UserID, int UserContactTypeID)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int UserContactID)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int UserContactID, string Contact, int UserID, int UserContactTypeID)
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