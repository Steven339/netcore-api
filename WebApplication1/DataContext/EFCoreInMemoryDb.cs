using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DataContext
{
    public class EFCoreInMemoryDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("products");
        }

        public DbSet<Products> Products { get; set; }

    }
}
