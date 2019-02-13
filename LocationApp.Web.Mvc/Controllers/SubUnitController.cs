using LocationApp.Core.Helper;
using LocationApp.Data.Dto;
using LocationApp.Service.Services;
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
    public class SubUnitController : Controller
    {
        readonly LocationApp.Service.Services.SubUnitService subUnitService = new Service.Services.SubUnitService();
        readonly LocationApp.Service.Services.MainUnitService mainUnitService = new Service.Services.MainUnitService();

        [HttpGet]
        public ActionResult Create()
        {
            GetMainUnit(0);
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Name, int MainUnitID)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (subUnitService.AddSubUnit(0, Name, MainUnitID));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var item = subUnitService.GetSubUnit(id.Value);
            var result = JsonConvert.DeserializeObject<SubUnitDto>(item);
            if (result != null)
            {
                GetMainUnit(result.MainUnitID);
                return View(result);
            }
            else
                return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(int SubUnitID, string Name, int MainUnitID)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (subUnitService.SetSubUnit(SubUnitID, Name, MainUnitID));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<SubUnitDto>>(subUnitService.GetAllSubUnit(0)));
        }
        void GetMainUnit(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<MainUnitDto>>(mainUnitService.GetAllMainUnit());
            SelectList slist = new SelectList(list, "mainUnitID", "Name", selectedValue);
            ViewBag.MainUnitID = slist;
        }
    }
}