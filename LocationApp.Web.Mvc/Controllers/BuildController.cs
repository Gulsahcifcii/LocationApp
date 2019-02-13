using LocationApp.Core.Helper;
using LocationApp.Data.Database;
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
    public class BuildController : Controller
    {
        readonly LocationApp.Service.Services.BuildService buildService = new Service.Services.BuildService();
        readonly LocationApp.Service.Services.CampusService campusService = new Service.Services.CampusService();
        readonly LocationApp.Service.Services.SiteService siteService = new Service.Services.SiteService();
        [HttpGet]
        public ActionResult Create()
        {
            GetSite(0);
            GetCampus(0);
            return View();
        }
        [HttpPost]
        public ActionResult Create(int SiteID, int CampusID, string Name, string Address, string Gps, string Properties)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (buildService.AddBuild(0, CampusID, SiteID, Name, Address, Properties, Gps));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result,result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var item = buildService.GetBuild(id.Value);
            var result = JsonConvert.DeserializeObject<BuildDto>(item);
            if (result != null)
            {
                GetSite(result.SiteID);
                GetCampus(result.CampusID);
                return View(result);
            }
            else
                return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(int BuildID, int SiteID, int CampusID, string Name, string Address, string Gps, string Properties)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
               (buildService.UpdateBuild(BuildID, CampusID, SiteID, Name, Address, Properties, Gps));
            if (result.Result)
                return RedirectToAction("List");
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result,result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<BuildDto>>(buildService.GetAllBuild()));
        }
        void GetSite(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<SiteDto>>(siteService.GetAllSite());
            SelectList slist = new SelectList(list, "SiteID", "Name", selectedValue);
            ViewBag.SiteID = slist;
        }
        void GetCampus(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<CampusDto>>(campusService.GetAllCampus());
            SelectList slist = new SelectList(list, "CampusID", "Name", selectedValue);
            ViewBag.CampusID = slist;
        }
    }
}