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
    public class SiteController : Controller
    {
        readonly LocationApp.Service.Services.SiteService siteService = new Service.Services.SiteService();
        readonly LocationApp.Service.Services.CampusSiteService campusSiteService = new Service.Services.CampusSiteService();
        readonly LocationApp.Service.Services.CampusService campusService = new Service.Services.CampusService();

        [HttpGet]
        public ActionResult Create()
        {
            GetCampus(0);
            GetSite(0);
            return View();
        }
        [HttpPost]
        public ActionResult Create(int CampusID, string Name, string Description, string Gps)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (siteService.AddSite(0, Name, Description, Gps));
            if (result.Result)
            {
                ResultHelper resultC = JsonConvert.DeserializeObject<ResultHelper>
                (campusSiteService.AddCampusSite(0, result.ResultSet, CampusID, null));
                if (resultC.Result)
                {
                    return RedirectToAction("List");
                }
                else
                    ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            }
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var item = siteService.GetSite(id.Value);
            var result = JsonConvert.DeserializeObject<SiteDto>(item);
            if (result != null)
            {
                GetCampus(result.campusSiteDto.CampusID);
                GetSite(result.SiteID);
                return View(result);
            }
            else
                return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(int SiteID, int CampusSiteID, int CampusID, string Name, string Description, string Gps)
        {
            ResultHelper result = JsonConvert.DeserializeObject<ResultHelper>
                (siteService.SetSite(SiteID, Name, Description, Gps));
            if (result.Result)
            {
                ResultHelper resultC = JsonConvert.DeserializeObject<ResultHelper>
                (campusSiteService.UpdateCampusSite(CampusSiteID, result.ResultSet, CampusID, null));
                if (resultC.Result)
                {
                    return RedirectToAction("List");
                }
                else
                    ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            }
            else
                ViewBag.Message = Helper.GetResultMessage(result.Result, result.ResultDescription);
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<SiteDto>>(siteService.GetAllSite()));
        }
        #region Dropdownlist
        void GetCampus(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<CampusDto>>(campusService.GetAllCampus());
            SelectList slist = new SelectList(list, "CampusID", "Name", selectedValue);
            ViewBag.CampusID = slist;
        }
        void GetSite(int selectedValue)
        {
            var list = JsonConvert.DeserializeObject<List<SiteDto>>(siteService.GetAllSiteWithCampus(selectedValue));
            SelectList slist = new SelectList(list, "SiteID", "Name", selectedValue);
            ViewBag.SiteID = slist;
        }
        #endregion
    }
}