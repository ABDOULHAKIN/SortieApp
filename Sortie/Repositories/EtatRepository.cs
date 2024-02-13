using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class EtatRepository : IEtatRepository
    {
        public readonly EtatContext _context;

        // Une injection de dépendances
        public EtatRepository(EtatContext context)
        {
            _context = context;
        }

        public int AddEtat(Etat etat)
        {
            try
            {
                var idEtat = _context.Etat.Add(etat);
                _context.SaveChanges();
                return idEtat.Entity.Id;
            }
            catch (Exception e) {
                return -1;
                throw;
            }
        }

        public Etat? GetById(int id)
        {
            try
            {
                var idEtat = _context.Etat.Find(id);
         
                return idEtat;
            }
            catch (Exception e)
            {
                //return -1;
                throw;
            }
        }
    }
}
