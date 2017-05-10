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
        public virtual DbSet<Question> Quests { get; set; }

        public GreatTestDbContext()
            :base("name=GreatTestDbContext")
        {
            Database.SetInitializer<GreatTestDbContext>(new DropCreateDatabaseIfModelChanges<GreatTestDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}