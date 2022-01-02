using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace web_project.Models
{
    public class SiteContext:DbContext
    {
        public SiteContext():base("databaseConnection")
        {

        }
        public DbSet<admin> Admins { get; set; }
        public DbSet<comment> Comments { get; set; }
        public DbSet<trainer> Trainers { get; set; }
        public DbSet<users> Users { get; set; }
        public DbSet<videos> Videos { get; set; }


    }
}