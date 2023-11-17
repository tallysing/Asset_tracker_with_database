
using Microsoft.EntityFrameworkCore;

namespace Asset_tracker_with_database
{
    internal class AssetDbContext:DbContext // Handles database interactions and management
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Company_Assets;Integrated Security=True"; // Entity framework creates non existing database

        public DbSet<Asset> Assets { get; set; }  // Creates the assets table.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            // We tell the app to use the connection string to connect to the database.
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder ModelBuilder) { }
    }
}

