﻿using LocationApp.Data.Database;
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
    public class MainUnitLogic
    {
        WebOperationContext webOperationContext = WebOperationContext.Current;
        public string AddMainUnit(MainUnitDto mainUnitDto)
        {
            try
            {
                mainunit item = new mainunit();
                item.MainUnitID = mainUnitDto.MainUnitID;
                item.Name = mainUnitDto.Name;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<mainunit>().Insert(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string SetMainUnit(MainUnitDto mainUnitDto)
        {
            try
            {
                mainunit item = new mainunit();
                item.MainUnitID = mainUnitDto.MainUnitID;
                item.Name = mainUnitDto.Name;

                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    unitofWork.GetRepository<mainunit>().Update(item);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelMainUnit(int mainUnitID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedMainUnit = unitofWork.GetRepository<mainunit>().GetById(x => x.MainUnitID == mainUnitID);
                    unitofWork.GetRepository<mainunit>().Delete(selectedMainUnit);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public MainUnitDto GetMainUnit(int mainUnitID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    mainunit item = new mainunit();
                    item = unitofWork.GetRepository<mainunit>().GetById(x => x.MainUnitID == mainUnitID);
                    MainUnitDto mainUnitDto = new MainUnitDto();
                    mainUnitDto.MainUnitID = item.MainUnitID;
                    mainUnitDto.Name = item.Name;

                    return mainUnitDto;
                }
            }
            catch (Exception)
            {
                return new MainUnitDto();
            }
        }
        public List<MainUnitDto> GetAllMainUnit()
        {
            try
            {
                List<MainUnitDto> list = new List<MainUnitDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    List<mainunit> collection = unitofWork.GetRepository<mainunit>().Select(null, null).ToList();
                    foreach (var item in collection)
                    {
                        list.Add(new MainUnitDto {MainUnitID=item.MainUnitID,Name=item.Name});
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<MainUnitDto>();
            }
        }
    }
}
