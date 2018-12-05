using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Intex_2.DAL
{
    public class DefaultConnection: DbContext
    {
        public DefaultConnection() : base("DefaultConnection")
        {

        }
        
    }
}