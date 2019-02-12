using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LocationApp.Web.Controllers
{
    public class UserRoleController : Controller
    {
        readonly LocationApp.Service.Services.UserUserRoleService userRoleService = new Service.Services.UserUserRoleService();

        public ActionResult List()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int UserRoleId,string UserRoleName,string UserRoleDescription,bool Active )
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int UserRoleId, string UserRoleName, string UserRoleDescription, bool Active)
        {
            return View();
        }
    }
}