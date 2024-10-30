using FaceBug.ProfileApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace FaceBug.ProfileApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<ProfileModel> Profiles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

