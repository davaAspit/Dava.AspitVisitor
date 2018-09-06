using Dava.AspitVisitor.Database.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dava.AspitVisitor.Biz
{
    public class BaseHandler
    {
        private AspitVisitorModel model = new AspitVisitorModel();

        protected AspitVisitorModel Model { get => model; }

        protected bool SaveChanges()
        {
            int rowsAffected = Model.SaveChanges();

            if (rowsAffected > 0)
                return true;
            else
                return false;
        }
    }
}
