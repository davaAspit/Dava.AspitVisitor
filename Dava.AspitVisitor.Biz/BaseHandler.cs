﻿using Dava.AspitVisitor.Database.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dava.AspitVisitor.Biz
{
    public class BaseHandler
    {
        protected AspitVisitorModel Model { get; } = new AspitVisitorModel();

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
