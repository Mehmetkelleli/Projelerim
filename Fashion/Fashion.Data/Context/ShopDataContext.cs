using Fashion.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Data.Context
{
    public class ShopDataContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<HomePageSlider> HomePageSliders { get; set; }
        public DbSet<Pictures> Pictures { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<SiteConfig> SiteConfig { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3DP2PDF;Database=FashionShop;MultipleActiveResultSets=true;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(i => new { i.CategoryId, i.ProductId });
        }
    }
}
