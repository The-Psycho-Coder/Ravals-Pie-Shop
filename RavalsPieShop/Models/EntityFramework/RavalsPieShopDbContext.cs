using Microsoft.EntityFrameworkCore;
using RavalsPieShop.Models.Data;

namespace RavalsPieShop.Models.EntityFramework
{
    public class RavalsPieShopDbContext : DbContext
    {
        public RavalsPieShopDbContext(DbContextOptions<RavalsPieShopDbContext> options) : base(options)
        {
        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}