using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class DepartmentController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int DepartmentID,int SubUnitID,string Name,string Description,string Other)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int DepartmentID)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int DepartmentID, int SubUnitID, string Name, string Description, string Other)
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}