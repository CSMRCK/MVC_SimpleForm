using Microsoft.EntityFrameworkCore;

namespace SomethingMVC.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options): base(options)
        {
            // вызов Database.EnsureCreated() при отсутствии базы данных автоматически создает ее.
            Database.EnsureCreated();
        }
    }
}
