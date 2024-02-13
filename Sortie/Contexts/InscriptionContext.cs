using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class InscriptionContext : DbContext
    {
        public DbSet<Inscription> Inscription { get; set; }

        public InscriptionContext(DbContextOptions<InscriptionContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inscription>()
                .Property(x => x.Id).HasColumnName("id_inscription");

            modelBuilder.Entity<Inscription>()
                .Property(x => x.ParticipantId).HasColumnName("id_participant");
            modelBuilder.Entity<Inscription>()
                .Property(x => x.SortieId).HasColumnName("id_sortie");

        }
    }
}
