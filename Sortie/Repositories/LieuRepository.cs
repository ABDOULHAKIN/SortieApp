using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class LieuRepository : ILieuRepository
    {
        public readonly LieuContext _context;

        // Une injection de dépendances
        public LieuRepository(LieuContext context)
        {
            _context = context;
        }

        public void AddLieu(Lieu lieu)
        {
            try
            {
                _context.Lieu.Add(lieu);
                _context.SaveChanges();
            }
            catch (Exception e) {
                throw;
            }
        }

        public Lieu GetLieuById(int id)
        {

            Lieu result = _context.Lieu.FirstOrDefault(l => l.Id == id);

            return result;
        }
    }
}
