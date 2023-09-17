using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ViewModel.Models;

namespace ViewModel.Data
{
    public class ApplicationDbContext: DbContext

    {
        public ApplicationDbContext()
            : base("name=MySqlConnection")
        {

        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

    }
}