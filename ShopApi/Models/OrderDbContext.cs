using Microsoft.EntityFrameworkCore;

namespace ShopApi.Models
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options):base(options)  
        {
                
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
