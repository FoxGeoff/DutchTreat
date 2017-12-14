using Dutch_Treat.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dutch_Treat.Data
{
    public class DuchContext : DbContext
    {
        public DuchContext(DbContextOptions<DuchContext> options):base(options)
        {

        }

        DbSet<Product> Products { get; set; }
        DbSet<Order> Orders { get; set; }
    }
}