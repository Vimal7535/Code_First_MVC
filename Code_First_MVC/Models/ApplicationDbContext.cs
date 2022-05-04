using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_First_MVC.Models
{
    public class ApplicationDbContext:DbContext
    {
      public  ApplicationDbContext() : base("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MVCDB;Integrated Security=True") { }
        public DbSet<Employees> Employees { get; set; } 
    }
}