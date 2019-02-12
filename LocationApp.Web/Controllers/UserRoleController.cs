using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class UserRoleController : Controller
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
        public IActionResult Create(int UserRoleId,string UserRoleName,string UserRoleDescription,bool Active )
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int UserRoleId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int UserRoleId, string UserRoleName, string UserRoleDescription, bool Active)
        {
            return View();
        }
    }
}