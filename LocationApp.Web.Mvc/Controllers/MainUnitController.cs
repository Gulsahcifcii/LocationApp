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
    public class MainUnitController : Controller
    {
        readonly LocationApp.Service.Services.MainUnitService mainUnitService = new Service.Services.MainUnitService();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Name)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>(mainUnitService.AddMainUnit(0, Name));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
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
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>(mainUnitService.SetMainUnit(MainUnitID, Name));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<MainUnitDto>>(mainUnitService.GetAllMainUnit()));
        }
    }
}