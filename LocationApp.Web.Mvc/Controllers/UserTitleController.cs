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
    public class UserTitleController : Controller
    {
        LocationApp.Service.Services.UserTitleService userTitleService = new Service.Services.UserTitleService();
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string TitleName)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int? id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int UserTitleID,string TitleName)
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
    }
}