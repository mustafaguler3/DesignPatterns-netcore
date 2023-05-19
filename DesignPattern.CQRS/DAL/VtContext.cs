using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class VtContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=designPattern1;integrated security=true");
        }
    }
}
