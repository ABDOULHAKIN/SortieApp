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
    }
}
