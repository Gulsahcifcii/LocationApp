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
        public ActionResult Create(string UserRoleName,string UserRoleDescription,bool Active=false )
        {
            
            string result = JsonConvert.DeserializeObject(
                          userRoleService.AddUserRole(0, UserRoleName, UserRoleDescription, Active)
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
            string result = JsonConvert.DeserializeObject(
                                        userRoleService.SetUserRole(UserRoleId, UserRoleName, UserRoleDescription, Active)
                                        ).ToString();

            if (result == "OK")
                return RedirectToAction("List");
            //ViewBag.Message = Helper.GetResultMessage(true);
            else
                ViewBag.Message = Helper.GetResultMessage(false);
            return View();
        }
    }
}