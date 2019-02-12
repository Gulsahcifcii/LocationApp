using LocationApp.Data.Database;
using LocationApp.Data.Dto;
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
            var result = campusService.AddCampus(0, Name, Description, Other);
            string result1 = JsonConvert.DeserializeObject(result).ToString();
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int ? id)
        {
            var item = campusService.GetCampus(id.Value);
            var result = JsonConvert.DeserializeObject<CampusDto>(item);
            if (result!=null)
            {
                campu campu = new campu();
                campu.CampusID = result.CampusID;
                campu.Description = result.Description;
                campu.Name = result.Name;
                campu.Other = campu.Other;
                return View(campu);
            }
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(int CampusID, string Name, string Description, string Other)
        {
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            return View(JsonConvert.DeserializeObject<List<campu>>(campusService.GetAllCampus()));
        }
    }
}