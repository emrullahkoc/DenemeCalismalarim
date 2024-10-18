using DenemeCalisma1.Models.VeriTabani1;
using Microsoft.EntityFrameworkCore;

namespace DenemeCalisma1.Data
{
    public class FirstDbContext : DbContext
    {
        public FirstDbContext(DbContextOptions<FirstDbContext> options) : base(options) { }

        public DbSet<Acente> Acenteler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acente>()
                .HasOne(a => a.Sehir)
                .WithMany()
                .HasForeignKey(a => a.SehirlerID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Acente>()
                .HasOne(a => a.Ilce)
                .WithMany()
                .HasForeignKey(a => a.IlcelerID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ilce>()
                .HasOne(i => i.Sehir)
                .WithMany()
                .HasForeignKey(i => i.SehirlerID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
