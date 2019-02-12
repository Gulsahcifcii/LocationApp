using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LocationApp.Web.Controllers
{
    public class UserTitleController : Controller
    {
        LocationApp.Service.Services.UserTitleService titleService = new Service.Services.UserTitleService();
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
        public ActionResult Create(string TitleName)
        {
            titleService.AddUserTitle(0, TitleName);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int UserTitleID)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }
    }
}