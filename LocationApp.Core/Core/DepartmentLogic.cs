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
    public class DepartmentLogic
    {
        WebOperationContext webOperationContext = WebOperationContext.Current;
        public string AddDepartment(DepartmentDto departmentDto)
        {
            try
            {
                department item = new department();
                item.DepartmentID = departmentDto.DepartmentID;
                item.Description = departmentDto.Description;
                item.Other = departmentDto.Other;
                item.SubUnitID = departmentDto.SubUnitID;
                item.Name = departmentDto.Name;

                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.GetRepository<department>().Insert(item);
                    unitOfWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string SetDepartment(DepartmentDto departmentDto)
        {
            try
            {
                department item = new department();
                item.DepartmentID = departmentDto.DepartmentID;
                item.Description = departmentDto.Description;
                item.Other = departmentDto.Other;
                item.SubUnitID = departmentDto.SubUnitID;
                item.Name = departmentDto.Name;

                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.GetRepository<department>().Update(item);
                    unitOfWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelDepartment(int departmentID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedDeparment = unitofWork.GetRepository<department>().GetById(x => x.DepartmentID == departmentID);
                    unitofWork.GetRepository<department>().Delete(selectedDeparment);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public DepartmentDto GetDepartment(int departmentID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    department item = new department();
                    item = unitofWork.GetRepository<department>().GetById(x => x.DepartmentID == departmentID);
                    DepartmentDto departmentDto = new DepartmentDto();
                    departmentDto.DepartmentID = item.DepartmentID;
                    departmentDto.SubUnitID = (int)item.SubUnitID;
                    departmentDto.Description = item.Description;
                    departmentDto.Other = item.Other;

                    return departmentDto;
                }
            }
            catch (Exception ex)
            {
                return new DepartmentDto();
            }
        }
        public List<DepartmentDto> GetAllDepartment()
        {
            try
            {
                List<DepartmentDto> list = new List<DepartmentDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    List<department> collection = unitofWork.GetRepository<department>().Select(null, null).ToList();
                    foreach (var item in collection)
                    {
                        list.Add(new DepartmentDto {  DepartmentID=item.DepartmentID,Description=item.Description,Name=item.Name,Other=item.Other,SubUnitID=item.SubUnitID.Value});
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<DepartmentDto>();
            }
        }
    }
}
