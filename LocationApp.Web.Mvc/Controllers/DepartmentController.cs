using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LocationApp.Web.Controllers
{
    public class DepartmentController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int DepartmentID,int SubUnitID,string Name,string Description,string Other)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int DepartmentID)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int DepartmentID, int SubUnitID, string Name, string Description, string Other)
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
    }
}