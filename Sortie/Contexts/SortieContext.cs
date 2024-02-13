using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contexts
{
    public class SortieContext : DbContext
    {
        public DbSet<Sortie> Sortie { get; set; }

        public SortieContext(DbContextOptions<SortieContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Sortie>()
                .HasKey(e => e.Id);

            modelbuilder.Entity<Sortie>().Property(e => e.Id).HasColumnName("id_sortie").ValueGeneratedOnAdd();
            modelbuilder.Entity<Sortie>()
                .Property(e => e.OrganisateurId).HasColumnName("id_organisateur");
            modelbuilder.Entity<Sortie>()
                .Property(e => e.EtatId).HasColumnName("id_etat");
            modelbuilder.Entity<Sortie>()
                .Property(e => e.LieuId).HasColumnName("id_lieu");
            modelbuilder.Entity<Sortie>()
               .Property(e => e.DateDebut).HasColumnName("date_debut");
            modelbuilder.Entity<Sortie>()
               .Property(e => e.DateFin).HasColumnName("date_fin");
            modelbuilder.Entity<Sortie>()
               .Property(e => e.IsActive).HasColumnName("is_active");




        }
    }
}
