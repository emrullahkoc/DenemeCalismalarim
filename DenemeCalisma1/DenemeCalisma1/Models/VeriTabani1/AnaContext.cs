using Microsoft.EntityFrameworkCore;

namespace DenemeCalisma1.Models.VeriTabani1
{
    public class AnaContext:DbContext
    {
        public AnaContext(DbContextOptions<AnaContext> options) : base(options) { }
        public DbSet<Acente> Acents { get; set; }
    }
}
