using LocationApp.Data.Database;
using Newtonsoft.Json;
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
        readonly LocationApp.Service.Services.DepartmentService departmentService = new Service.Services.DepartmentService();

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
        public ActionResult Edit(int? id)
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
            return View(JsonConvert.DeserializeObject<List<department>>(departmentService.GetAllDepartment()));
        }
    }
}