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

        public void AddSortie(Sortie sortie)
        {
            try
            {
                _context.Sortie.Add(sortie);
                _context.SaveChanges();
            }
            catch (Exception e) {
                throw;
            }
        }
    }
}
