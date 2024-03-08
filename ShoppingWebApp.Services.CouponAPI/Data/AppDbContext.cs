using Microsoft.EntityFrameworkCore;
using ShoppingWebApp.Services.CouponAPI.Models;

namespace ShoppingWebApp.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Coupon> Coupons{ get; set; }
    }
}
