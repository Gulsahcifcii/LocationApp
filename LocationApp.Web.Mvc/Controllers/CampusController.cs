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
    public class CampusController : Controller
    {
        LocationApp.Service.Services.CampusService campusService = new Service.Services.CampusService();
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Name, string Description, string Other)
        {
            string result = JsonConvert.DeserializeObject(
                campusService.AddCampus(0, Name, Description, Other)
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
            var item = campusService.GetCampus(id.Value);
            var result = JsonConvert.DeserializeObject<CampusDto>(item);
            if (result != null)
                return View(result);
            else
                return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(int CampusID, string Name, string Description, string Other)
        {
            string result = JsonConvert.DeserializeObject(
                            campusService.UpdateCampus(CampusID, Name, Description, Other)
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
            return View(JsonConvert.DeserializeObject<List<CampusDto>>(campusService.GetAllCampus()));
        }
    }
}