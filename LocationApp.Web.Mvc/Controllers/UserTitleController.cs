using LocationApp.Core.Helper;
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
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (userTitleService.AddUserTitle(0, TitleName));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
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
        public ActionResult Edit(int UserTitleID, string TitleName)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (userTitleService.SetUserTitle(UserTitleID, TitleName));

            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }

        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<UserTitleDto>>(userTitleService.GetAllUserTitle()));
        }
    }
}