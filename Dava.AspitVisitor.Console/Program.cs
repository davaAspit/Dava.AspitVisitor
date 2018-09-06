using Dava.AspitVisitor.Biz;
using Dava.AspitVisitor.Database.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dava.AspitVisitor.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitorHandler visitorHandler = new VisitorHandler();
            DepartmentHandler departmentHandler = new DepartmentHandler();
            var d = departmentHandler.GetNordjylland();
            Visitor v = new Visitor()
            {
                Age = 52,
                Department = d,
                FirstName = "Karsten",
                LastName = "Hansen",
                Municipality = new Municipality() { Navn = "Hjørring"},
                VisitTime = DateTime.Now,
                WantsToEnrollAspit = true
            };

            visitorHandler.Add(v);
        }
    }
}
