using DenemeCalisma1.Models.VeriTabani2;
using Microsoft.EntityFrameworkCore;

namespace DenemeCalisma1.Data
{
    public class DynamicDbContext : DbContext
    {
        private readonly string _connectionString;

        public DynamicDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }

    }

}
