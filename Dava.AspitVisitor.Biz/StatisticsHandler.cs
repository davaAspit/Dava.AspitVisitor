using Dava.AspitVisitor.Database.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dava.AspitVisitor.Biz
{
    class StatisticsHandler : BaseHandler
    {
        public int NumberOfVisitorsAt(Department department) => Model.Visitors.Count(v => v.DepartmentId == department.DepartmentId);

        public int NumberOfVisitorsInAll() => Model.Visitors.Count();


    }
}
