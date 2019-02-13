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
    public class MainUnitController : Controller
    {
        readonly LocationApp.Service.Services.MainUnitService mainUnitService = new Service.Services.MainUnitService();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int MainUnitID, string Name)
        {
            string result = JsonConvert.DeserializeObject(
                            mainUnitService.AddMainUnit(0, Name)
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
            var item = mainUnitService.GetMainUnit(id.Value);
            var result = JsonConvert.DeserializeObject<MainUnitDto>(item);
            if (result != null)
                return View(result);
            else
                return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(int MainUnitID, string Name)
        {
            string result = JsonConvert.DeserializeObject(
                                        mainUnitService.SetMainUnit(MainUnitID, Name)
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
            return View(JsonConvert.DeserializeObject<List<MainUnitDto>>(mainUnitService.GetAllMainUnit()));
        }
    }
}