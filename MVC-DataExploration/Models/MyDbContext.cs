using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_DataExploration.Models
{
    public class MyDbContext : DbContext
    {
        //Constructor
        public MyDbContext() : base("Grocer-ClassFirst")
        {

        }

        // Model Collections
        public DbSet<Customer> Customers { get; set; }

    }
}