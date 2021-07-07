using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers
{
    public class CustomerDal: DbContext
    {
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().ToTable("tblCustomers");
        }
        public DbSet<Customer> Customers  { get; set; }
    }
}