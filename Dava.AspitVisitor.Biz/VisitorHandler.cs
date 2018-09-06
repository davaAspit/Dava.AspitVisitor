using Dava.AspitVisitor.Database.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dava.AspitVisitor.Biz
{
    public class VisitorHandler : BaseHandler
    {
        public List<Visitor> GetAllVisitors()
        {
            return Model.Visitors.ToList();
        }

        public bool Add(Visitor visitor)
        {
            Model.Visitors.Add(visitor);
            return SaveChanges();
        }
    }
}
