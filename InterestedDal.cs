using ProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectMVC.Dal
{
    public class InterestedDal : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Interested>().ToTable("Interestedtbl");
        }
        public DbSet<Interested> Interesteds { get; set; }
    }
}