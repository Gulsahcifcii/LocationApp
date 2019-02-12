using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LocationApp.Web.Controllers
{
    public class UserContactController : Controller
    {
        readonly LocationApp.Service.Services.UserContactService userContactService = new Service.Services.UserContactService();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int UserContactID, string Contact, int UserID, int UserContactTypeID)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int UserContactID, string Contact, int UserID, int UserContactTypeID)
        {
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            return View();
        }
    }
}