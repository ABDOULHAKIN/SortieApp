using Azure;
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

        public int AddLieu(Lieu lieu)
        {
            try
            {
                var idEtat = _context.Lieu.Add(lieu); ;
                _context.SaveChanges();
                return idEtat.Entity.Id;
            }
            catch (Exception e) {
                throw;
            }
        }

        public Lieu? GetLieu(int id)
        {
            try
            {
                var idInscription = _context.Lieu.Find(id);

                return idInscription;
            }
            catch (Exception e)
            {
                //return -1;
                throw;
            }
        }
    }
}
