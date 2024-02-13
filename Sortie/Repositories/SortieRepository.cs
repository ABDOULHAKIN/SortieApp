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

        public Sortie GetSortieByID(int id)
        {
            Sortie result = _context.Sortie.FirstOrDefault(x => x.Id == id);
            return result;
        }



        public void PseudoDeleteByID(int id)
        {
            var toDelete = _context.Sortie.FirstOrDefault(e => e.Id == id);
            toDelete.IsActive = false;
            _context.SaveChanges();


        }
    }
}
