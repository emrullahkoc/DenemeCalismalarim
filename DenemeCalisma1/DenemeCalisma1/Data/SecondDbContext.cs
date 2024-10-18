using DenemeCalisma1.Models.VeriTabani2;
using Microsoft.EntityFrameworkCore;

namespace DenemeCalisma1.Data
{
    public class SecondDbContext : DbContext
    {
        public SecondDbContext(DbContextOptions<SecondDbContext> options) : base(options) { }

        public DbSet<Kullanici> Kullanicilar { get; set; }
    }
}
