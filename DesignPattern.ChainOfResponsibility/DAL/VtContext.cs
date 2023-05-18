using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class VtContext : DbContext
    {
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-N81IS28;database=designPattern1;integrated security=true");
        }
    }
}
