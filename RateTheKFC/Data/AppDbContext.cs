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

            modelBuilder.Entity<City>().HasData(new City { Id = 1, Name = "Атырау" });
            modelBuilder.Entity<City>().HasData(new City { Id = 2, Name = "Астана" });
            modelBuilder.Entity<City>().HasData(new City { Id = 3, Name = "Алматы" });
            
            modelBuilder.Entity<Company>().HasData(new Company { Id = 1, Name = "Best Chicken", CityId = 1});    
            modelBuilder.Entity<Company>().HasData(new Company { Id = 2, Name = "KFC Atyrau", CityId = 1});    
            modelBuilder.Entity<Company>().HasData(new Company { Id = 3, Name = "Чики Пики Чикен", CityId = 2});    
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
