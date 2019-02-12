using LocationApp.Data.Database;
using LocationApp.Data.Dto;
using LocationApp.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Core.Core
{
    public class SiteLogic
    {
        WebOperationContext webOperationContext = WebOperationContext.Current;
        public string AddSite(SiteDto siteDto)
        {
            try
            {
                site item = new site();
                item.SiteID = siteDto.SiteID;
                item.Name = siteDto.Name;
                item.Description = siteDto.Description;
                item.Gps = siteDto.Gps;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<site>().Insert(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string SetSite(SiteDto siteDto)
        {
            try
            {
                site item = new site();
                item.SiteID = siteDto.SiteID;
                item.Name = siteDto.Name;
                item.Description = siteDto.Description;
                item.Gps = siteDto.Gps;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<site>().Update(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelSite(int siteID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedSite = unitofWork.GetRepository<site>().GetById(x => x.SiteID == siteID);
                    unitofWork.GetRepository<site>().Delete(selectedSite);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public SiteDto GetSite(int siteID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    site item = new site();
                    item = unitofWork.GetRepository<site>().GetById(x => x.SiteID == siteID);
                    SiteDto siteDto = new SiteDto();
                    siteDto.SiteID = item.SiteID;
                    siteDto.Description = item.Description;
                    siteDto.Gps = item.Gps;
                    siteDto.Name = item.Name;
                    return siteDto;
                }
            }
            catch (Exception ex)
            {
                return new SiteDto();
            }
        }
        public List<SiteDto> GetAllSite()
        {
            try
            {
                List<SiteDto> list = new List<SiteDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    List<site> collection = unitofWork.GetRepository<site>().Select(null, null).ToList();
                    foreach (var item in collection)
                    {
                        list.Add(new SiteDto { SiteID=item.SiteID,Name=item.Name,Gps=item.Gps,Description=item.Description });
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<SiteDto>();
            }
        }
    }
}
