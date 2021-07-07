using ProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectMVC.Controllers
{

    public class UserDal : DbContext
    {
        
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Login_user>().ToTable("tblUser");
        }
        
        public DbSet<Login_user> User { get; set; }
    }

}