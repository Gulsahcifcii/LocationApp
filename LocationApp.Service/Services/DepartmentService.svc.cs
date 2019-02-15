using LocationApp.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocationApp.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        Core.Core.DepartmentLogic departmentLogic = new Core.Core.DepartmentLogic();
        public string AddDepartment(int departmentID, string name, string description, string other, int subUnitID)
        {
            var result = departmentLogic.AddDepartment(new Data.Dto.DepartmentDto
            {
                DepartmentID = departmentID,
                Name=name,
                Description = description,
                Other = other,
                SubUnitID = subUnitID
            });
            return JsonConvert.SerializeObject(result);
        }
        public string DelDepartment(int departmentID)
        {
            var result = departmentLogic.DelDepartment(departmentID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetDepartment(int departmentID)
        {
            var result = departmentLogic.GetDepartment(departmentID);
            return JsonConvert.SerializeObject(result);
        }
        public string UpdateDepartment(int departmentID, string name, string description, string other, int subUnitID)
        {
            var result = departmentLogic.SetDepartment(new Data.Dto.DepartmentDto
            {
                DepartmentID = departmentID,
                Description = description,
                Other = other,
                SubUnitID = subUnitID
            });
            return JsonConvert.SerializeObject(result);
        }
        public string GetAllDepartment()
        {
            var department = departmentLogic.GetAllDepartment();
            var item = JsonConvert.SerializeObject(department, Formatting.Indented);
            return item;
        }
    }
}
