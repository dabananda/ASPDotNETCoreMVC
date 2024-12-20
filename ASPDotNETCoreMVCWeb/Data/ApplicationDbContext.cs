using ASPDotNETCoreMVCWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNETCoreMVCWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
                (
                    new Category { Id = 1, Name = "Web Development", DisplayOrder = 1 },
                    new Category { Id = 2, Name = "AI/Machine Learning", DisplayOrder = 2 },
                    new Category { Id = 3, Name = "Database", DisplayOrder = 3 },
                    new Category { Id = 4, Name = "Programming", DisplayOrder = 4 },
                    new Category { Id = 5, Name = "Network & Security", DisplayOrder = 5 }
                );
        }
    }
}
