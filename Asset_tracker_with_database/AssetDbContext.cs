using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Asset_tracker_with_database
{
    internal class AssetDbContext:DbContext
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Company_Assets;Integrated Security=True"; // Entity framework creates non existing database

        public DbSet<Asset> Assets { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder ModelBuilder) { }
    }
}

