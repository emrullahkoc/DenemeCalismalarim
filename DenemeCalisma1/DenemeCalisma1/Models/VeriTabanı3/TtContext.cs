using DenemeCalisma1.Models.VeriTabani2;
using Microsoft.EntityFrameworkCore;

namespace DenemeCalisma1.Models.VeriTabanı3
{
    public class TtContext :DbContext
    {
        public TtContext(DbContextOptions<TtContext> context) : base(context) { }

        public DbSet<Kullanici> Kullacilar { get; set; }
    }
}
