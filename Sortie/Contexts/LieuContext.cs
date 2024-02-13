using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contexts
{
    public class LieuContext : DbContext
    {
        public DbSet<Lieu> Lieu { get; set; }

        public LieuContext(DbContextOptions<LieuContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Lieu>()
                .Property(x => x.Id).HasColumnName("id_lieu");
        }
    }
}
