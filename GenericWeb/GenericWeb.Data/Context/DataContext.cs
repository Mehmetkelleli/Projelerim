using GenericWeb.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GenericWeb.Data.Context
{
    public class DataContext:IdentityDbContext<User>
    {
        public DbSet<SiteConfig> SiteConfig { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProductCategory>().HasKey(i => new { i.CategoryId, i.ProductId });
        //}
    }
}
