using Intex_2.Models;
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
        public DbSet<Assays> Assays { get; set; }
        public DbSet<Assays_Tests> Assays_Tests { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Compounds> Compounds { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Materials> Materials { get; set; }
        public DbSet<Materials_Used> Materials_Used { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Intex_2.Models.Results> Results { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<Samples> Samples { get; set; }
        public DbSet<Tests> Tests { get; set; }
        public DbSet<Tests_Samples> Tests_Samples { get; set; }
        public DbSet<Triggers> Triggers { get; set; }
        public DbSet<Triggers_Tests> Triggers_Tests { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Work_Orders> Work_Orders { get; set; }


        

    }
}