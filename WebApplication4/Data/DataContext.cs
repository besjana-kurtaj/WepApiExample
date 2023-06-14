using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


        }
        public DbSet<Super> Super { get; set; }
    }
}
