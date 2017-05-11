using System;
using DataLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DataLayer.Entities;

namespace DataLayer
{
    public class GreatTestDbContext : DbContext
    {
        

        public GreatTestDbContext()
            :base("name=GreatTestDbContext")
        {
            Database.SetInitializer(new GreatTestDbInitializer());
        }

        public DbSet<Question> Quests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}