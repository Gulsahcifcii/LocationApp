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
        WebOperationContext webOperationContext = WebOperationContext.Current;
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
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
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
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
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
                    return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (webOperationContext.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError).ToString();
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
    }
}
