using Microsoft.EntityFrameworkCore;

namespace DenemeCalisma1.Models.VeriTabani2
{
    public class MtlContext:DbContext
    {
        public MtlContext(DbContextOptions<MtlContext>context):base(context) { }

        public DbSet<Kullanici> Kullacilar { get; set; }
    }
}
