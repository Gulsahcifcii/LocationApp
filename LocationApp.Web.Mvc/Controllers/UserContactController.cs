using LocationApp.Data.Dto;
using LocationApp.Web.Mvc.Helpers;
using Newtonsoft.Json;
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
            string result = JsonConvert.DeserializeObject(userContactService.AddUserContact(0, Contact, UserID, UserContactTypeID)
                            ).ToString();

            if (result == "OK")
                return RedirectToAction("List");
            //ViewBag.Message = Helper.GetResultMessage(true);
            else
                ViewBag.Message = Helper.GetResultMessage(false);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var item = userContactService.GetUserContact(id.Value);
            var result = JsonConvert.DeserializeObject<UserContactDto>(item);
            if (result != null)
                return View(result);
            else
                return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(int UserContactID, string Contact, int UserID, int UserContactTypeID)
        {
            string result = JsonConvert.DeserializeObject(
                                        userContactService.SetUserContact(UserContactID, Contact, UserID, UserContactTypeID)
                                        ).ToString();

            if (result == "OK")
                return RedirectToAction("List");
            //ViewBag.Message = Helper.GetResultMessage(true);
            else
                ViewBag.Message = Helper.GetResultMessage(false);
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<UserContactDto>>(userContactService.GetAllUserContact()));
        }
    }
}