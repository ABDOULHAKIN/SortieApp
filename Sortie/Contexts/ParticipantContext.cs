using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contexts
{
    public class ParticipantContext : DbContext
    {
        public DbSet<Participant> Participant { get; set; }

        public ParticipantContext(DbContextOptions<ParticipantContext> options) : base(options)
        {




        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            modelbuilder.Entity<Participant>()
                .Property(e => e.Id).HasColumnName("id_participant");
            modelbuilder.Entity<Participant>()
                .Property(e => e.RoleId).HasColumnName("id_role");



        }
    }

}
