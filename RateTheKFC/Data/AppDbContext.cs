using RateTheKFC.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace RateTheKFC.Data {
    public class AppDbContext : DbContext {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<City> Cities { get; set; }
        public string DbPath { get; }
        public AppDbContext() {
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var appFolder = "RateTheKFC";
            var appDir = Path.Combine(appData, appFolder);
            Directory.CreateDirectory(appDir);
            var fileName = "RateTheKFC.db";
            DbPath= System.IO.Path.Combine(appDir, fileName);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            //modelBuilder.Entity<Fe>().HasData(new Company { Id = 1, Name = "Best Chicken", CityId= });    
            //modelBuilder.Entity<Company>().HasData(new Company { Id = 1, Name = "Best Chicken", CityId= });    
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
