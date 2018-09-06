using Dava.AspitVisitor.Database.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dava.AspitVisitor.Biz
{
    public class DepartmentHandler : BaseHandler
    {
        public List<Department> GetAllDepartments()
        {
            return Model.Departments.ToList();
        }

        public bool Add(Department department)
        {
            Model.Departments.Add(department);
            return SaveChanges();
        }

        public Department GetDepartment(int id)
        {
            return Model.Departments.Find(id);
            //return Model.Departments.First(d => d.DepartmentId == id);
        }

        public Department GetNordjylland()
        {
            return Model.Departments.FirstOrDefault(d => d.Name == "Nordjylland");
        }

        
    }
}
