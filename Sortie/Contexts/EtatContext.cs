using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contexts
{
    public class EtatContext : DbContext
    {
        public DbSet<Etat> Etat { get; set;}

        public EtatContext(DbContextOptions<EtatContext> options) : base(options)
        {
        }

    }
}
