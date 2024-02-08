using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class InscriptionContext : DbContext
    {
        public DbSet<Inscription> Inscriptions { get; set; }
    }
}
