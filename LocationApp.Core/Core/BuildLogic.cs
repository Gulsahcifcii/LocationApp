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
    public class BuildLogic
    {
        public string AddBuild(BuildDto buildDto)
        {
            try
            {
                build item = new build();
                item.SiteID = buildDto.SiteID;
                item.BuildID = buildDto.BuildID;
                item.CampusID = buildDto.CampusID;
                item.Gps = buildDto.Gps;
                item.Name = buildDto.Name;
                item.Adress = buildDto.Address;
                item.Properties = buildDto.Properties;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<build>().Insert(item);
                    unitofWork.saveChanges();

                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string SetBuild(BuildDto buildDto)
        {
            try
            {
                build item = new build();
                item.SiteID = buildDto.SiteID;
                item.BuildID = buildDto.BuildID;
                item.CampusID = buildDto.CampusID;
                item.Gps = buildDto.Gps;
                item.Name = buildDto.Name;
                item.Adress = buildDto.Address;
                item.Properties = buildDto.Properties;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<build>().Update(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelBuild(int buildID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedBuild = unitofWork.GetRepository<build>().GetById(x => x.BuildID == buildID);
                    unitofWork.GetRepository<build>().Delete(selectedBuild);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public BuildDto GetBuild(int buildID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    build item = new build();
                    item = unitofWork.GetRepository<build>().GetById(x => x.BuildID == buildID);
                    BuildDto buildDto = new BuildDto();
                    buildDto.BuildID = item.BuildID;
                    buildDto.SiteID = (int)item.SiteID;
                    buildDto.CampusID = (int)item.CampusID;
                    buildDto.Name = item.Name;
                    buildDto.Address = item.Adress;
                    buildDto.Gps = item.Gps;
                    buildDto.Properties = item.Properties;
                    return buildDto;
                }
            }
            catch (Exception ex)
            {
                return new BuildDto();
            }
        }
        public List<BuildDto> GetAllBuild()
        {
            try
            {
                List<BuildDto> list = new List<BuildDto>();
                using (var context = new locationAppEntities())
                {
                    var buildList = from b in context.builds
                                    join c in context.campus on b.CampusID equals c.CampusID
                                    join s in context.sites on b.SiteID equals s.SiteID
                                    select new
                                    {
                                        BID = b.BuildID,
                                        BName = b.Name,
                                        BAdress = b.Adress,
                                        BGps = b.Gps,
                                        BProperties = b.Properties,
                                        BCID = b.CampusID,
                                        CID = c.CampusID,
                                        CName = c.Name,
                                        CDesc = c.Description,
                                        COther = c.Other,
                                        SID = s.SiteID,
                                        SName = s.Name,
                                        SDesc = s.Description,
                                        SGps = s.Gps
                                    };
                    foreach (var item in buildList)
                    {
                        BuildDto bDto = new BuildDto();
                        bDto.BuildID = item.BID;
                        bDto.Name = item.BName;
                        bDto.Address = item.BAdress;
                        bDto.CampusID = item.BCID.Value;
                        bDto.Properties = item.BProperties;
                        bDto.CampusDto.CampusID = item.CID;
                        bDto.CampusDto.Name = item.CName;
                        bDto.CampusDto.Description = item.CDesc;
                        bDto.CampusDto.Other = item.COther;
                        bDto.SiteDto.SiteID = item.SID;
                        bDto.SiteDto.Name = item.SName;
                        bDto.SiteDto.Description = item.SDesc;
                        bDto.SiteDto.Gps = item.SGps;
                        list.Add(bDto);

                    }
                    return list;
                }

            }
            catch (Exception ex)
            {
                return new List<BuildDto>();
            }
        }
    }
}
