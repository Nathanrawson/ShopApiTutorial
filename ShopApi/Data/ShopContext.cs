using Microsoft.EntityFrameworkCore;
using ShopApi.Data.EntityModels;

namespace ShopApi.Data
{
    public class ShopContext: DbContext
    {   
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        public DbSet<ShopItem> ShopItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopItem>().ToTable("ShopItem");
        }
    }
}
