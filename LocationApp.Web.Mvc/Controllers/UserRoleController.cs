using LocationApp.Core.Helper;
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
    public class UserRoleController : Controller
    {
        readonly LocationApp.Service.Services.UserRoleService userRoleService = new Service.Services.UserRoleService();

        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<UserRoleDto>>(userRoleService.GetAllUserRole()));
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        //TODO:checkbox düzelt
        [HttpPost]
        public ActionResult Create(string UserRoleName, string UserRoleDescription, bool Active = false)
        {

            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (userRoleService.AddUserRole(0, UserRoleName, UserRoleDescription, Active));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var item = userRoleService.GetUserRole(id.Value);
            var result = JsonConvert.DeserializeObject<UserRoleDto>(item);
            if (result != null)
                return View(result);
            else
                return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(int UserRoleId, string UserRoleName, string UserRoleDescription, bool Active)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (userRoleService.SetUserRole(UserRoleId, UserRoleName, UserRoleDescription, Active));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result,result.ResultDescription);
            return View();
        }
    }
}