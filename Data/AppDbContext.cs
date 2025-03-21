using System;  // Missing Namespace
using Microsoft.EntityFrameworkCore;
using HealthCareApp.Models;  

namespace HealthCareApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Console.WriteLine("AppDbContext initialized!"); // Debugging
        }

        // Define your DbSets (tables)
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique(); // Ensure unique emails

            base.OnModelCreating(modelBuilder); // Base Call Corrected
        }
    }
}
