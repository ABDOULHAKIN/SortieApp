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
    }
}
