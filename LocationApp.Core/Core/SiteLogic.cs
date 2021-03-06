﻿using LocationApp.Core.Helper;
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
        public ResultHelper AddSite(SiteDto siteDto)
        {
            try
            {
                if (IsThere(siteDto))
                    return new ResultHelper(false, siteDto.SiteID, ResultHelper.IsThereItem);

                site item = new site();
                item.SiteID = siteDto.SiteID;
                item.Name = siteDto.Name;
                item.Description = siteDto.Description;
                item.Gps = siteDto.Gps;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<site>().Insert(item);
                    unitofWork.saveChanges();

                    return new ResultHelper(true, item.SiteID, ResultHelper.SuccessMessage);
                }
            }
            catch (Exception ex)
            {
                return new ResultHelper(false, siteDto.SiteID, ResultHelper.UnSuccessMessage);
            }
        }
        public ResultHelper SetSite(SiteDto siteDto)
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
                    return new ResultHelper(true, item.SiteID, ResultHelper.SuccessMessage);
                }
            }
            catch (Exception ex)
            {
                return new ResultHelper(false, siteDto.SiteID, ResultHelper.UnSuccessMessage);
            }
        }
        public ResultHelper DelSite(int siteID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedSite = unitofWork.GetRepository<site>().GetById(x => x.SiteID == siteID);
                    unitofWork.GetRepository<site>().Delete(selectedSite);
                    unitofWork.saveChanges();
                    return new ResultHelper(true, siteID, ResultHelper.SuccessMessage);
                }
            }
            catch (Exception)
            {
                return new ResultHelper(false, siteID, ResultHelper.UnSuccessMessage);
            }
        }
        public SiteDto GetSite(int siteID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    site item = unitofWork.GetRepository<site>().GetById(x => x.SiteID == siteID);
                    SiteDto siteDto = new SiteDto();
                    siteDto.SiteID = item.SiteID;
                    siteDto.Description = item.Description;
                    siteDto.Gps = item.Gps;
                    siteDto.Name = item.Name;

                    campussite campussite = unitofWork.GetRepository<campussite>().GetById(x => x.SiteID == item.SiteID);
                    siteDto.campusSiteDto = new CampusSiteDto();
                    siteDto.campusSiteDto.CampusID = campussite.CampusID;
                    siteDto.campusSiteDto.CampusSiteID = campussite.CampusSiteID;
                    siteDto.campusSiteDto.SiteID = campussite.SiteID;
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
                        list.Add(new SiteDto { SiteID = item.SiteID, Name = item.Name, Gps = item.Gps, Description = item.Description });
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<SiteDto>();
            }
        }
        public List<SiteDto> GetSiteWithCampus(int CampusID)
        {
            try
            {
                List<SiteDto> sDtoList = new List<SiteDto>();

                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    var list = from campus in unitOfWork.GetRepository<campu>().Select(null, null)
                               join campusSite in unitOfWork.GetRepository<campussite>().Select(null, null) on campus.CampusID equals campusSite.CampusID
                               join site in unitOfWork.GetRepository<site>().Select(null, null) on campusSite.SiteID equals site.SiteID
                               select new
                               {
                                   CID = campus.CampusID,
                                   CName = campus.Name,
                                   SID = site.SiteID,
                                   SName = site.Name
                               };
                    foreach (var item in list)
                    {
                        SiteDto siteDto = new SiteDto();
                        siteDto.SiteID = item.SID;
                        siteDto.Name = item.SName;
                        siteDto.campusSiteDto = new CampusSiteDto();
                        siteDto.campusSiteDto.CampusID = item.CID;
                        siteDto.campusSiteDto.SiteID = item.SID;
                        sDtoList.Add(siteDto);
                    }
                    return sDtoList;
                }
            }
            catch (Exception ex)
            {
                return new List<SiteDto>();
            }
        }
        public bool IsThere(SiteDto siteDto)
        {
            using (UnitOfWork unitofWork = new UnitOfWork())
            {
                var item = unitofWork.GetRepository<site>().GetById(x => x.Name.ToUpper() == siteDto.Name.ToUpper());
                if (item != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
