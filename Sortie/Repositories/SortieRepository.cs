using Azure;
using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class SortieRepository : ISortieRepository
    {
        public readonly SortieContext _context;

        // Une injection de dépendances
        public SortieRepository(SortieContext context)
        {
            _context = context;
        }

        public int AddSortie(Sortie sortie)
        {
            try
            {
                var idSortie = _context.Sortie.Add(sortie);
                _context.SaveChanges();
                return idSortie.Entity.Id;
                /* _context.Sortie.Add(sortie);
                 _context.SaveChanges();*/
            }
            catch (Exception e) {
                return -1;
                throw;
            }
        }
    }
}
