using Domain.Entities;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

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
            catch (Exception e)
            {
                throw;
            }
        }


        public async Task<Sortie?> GetSortieByID(int id)
        {
            try
            {
                return await _context.Sortie.Where(x => x.Id == id && x.IsActive).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }



        public void PseudoDeleteByID(int id)
        {
            var toDelete = _context.Sortie.FirstOrDefault(e => e.Id == id);
            toDelete.IsActive = false;
            _context.SaveChanges();


        }


        public async Task<int> UpdateSortie(Sortie sortie)
        {
            try
            {
                _context.Sortie.Update(sortie);
                await _context.SaveChangesAsync();
                return sortie.Id;
            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}
