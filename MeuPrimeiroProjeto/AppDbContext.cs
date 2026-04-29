using Microsoft.EntityFrameworkCore;

namespace MeuProjetoUrbs
{
    public class AppDbContext : DbContext
    {
        public DbSet<CartaoUrbs> Cartoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=urbs.db");
        }
    }
}