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
    public class DepartmentController : Controller
    {
        readonly LocationApp.Service.Services.SubUnitService subUnitService = new Service.Services.SubUnitService();
        readonly LocationApp.Service.Services.MainUnitService mainUnitService = new Service.Services.MainUnitService();
        readonly LocationApp.Service.Services.DepartmentService departmentService = new Service.Services.DepartmentService();

        [HttpGet]
        public ActionResult Create()
        {
            GetMainUnit(0);
            GetSubUnits(0);
            return View();
        }
        [HttpPost]
        public ActionResult Create(int SubUnitID, string Name, string Description, string Other)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (departmentService.AddDepartment(0, Name, Description, Other, SubUnitID));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result,result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var item = departmentService.GetDepartment(id.Value);
            var result = JsonConvert.DeserializeObject<DepartmentDto>(item);
            if (result != null)
            {
                GetMainUnit(result.SubUnitDto.MainUnitID);
                GetSubUnits(result.SubUnitDto.SubUnitID);
                return View(result);
            }
            else
                return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(int DepartmentID, int SubUnitID, string Name, string Description, string Other)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (departmentService.UpdateDepartment(DepartmentID, Name, Description, Other, SubUnitID));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result,result.ResultDescription);
            return View();
        }
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<DepartmentDto>>(departmentService.GetAllDepartment()));
        }
        void GetMainUnit(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<MainUnitDto>>(mainUnitService.GetAllMainUnit());
            list.Add(new MainUnitDto { MainUnitID = 0, Name = "Seçiniz" });
            SelectList slist = new SelectList(list, "MainUnitID", "Name", selectedValue);
            
            ViewBag.MainUnitID = slist;
        }
        void GetSubUnits(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<SubUnitDto>>(subUnitService.GetAllSubUnitWithByMainUnitID(0));
            list.Add(new SubUnitDto { SubUnitID = 0, Name = "Seçiniz" });
            SelectList slist = new SelectList(list, "SubUnitID", "Name", selectedValue);
            ViewBag.SubUnitID = slist;
        }
        [HttpGet]
        public JsonResult GetSubUnit(int mainUnitID)
        {
            var data = JsonConvert.DeserializeObject<List<SubUnitDto>>(subUnitService.GetAllSubUnitWithByMainUnitID(mainUnitID));
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}