using LocationApp.Data.Database;
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
            string result = JsonConvert.DeserializeObject(
                           userTitleService.AddUserTitle(0,TitleName)
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
            var item = userTitleService.GetUserTitle(id.Value);
            var result = JsonConvert.DeserializeObject<UserTitleDto>(item);
            if (result != null)
                return View(result);
            else
                return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(int UserTitleID,string TitleName)
        {
            string result = JsonConvert.DeserializeObject(
                                       userTitleService.SetUserTitle(UserTitleID, TitleName)
                                       ).ToString();

            if (result == "OK")
                return RedirectToAction("List");
            //ViewBag.Message = Helper.GetResultMessage(true);
            else
                ViewBag.Message = Helper.GetResultMessage(false);
            return View();
        }

        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<UserTitleDto>>(userTitleService.GetAllUserTitle()));
        }
    }
}