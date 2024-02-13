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

        public void AddEtat(Etat etat)
        {

            try
            {
                _context.Etat.Add(etat);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }
        }


        public Etat GetEtatById(int id)
        {
            var result = _context.Etat.FirstOrDefault(e => e.Id_etat == id);
            if (result != null && result.IsActive == true)
            {
                return result;
            }
            return null;
        }

        public void PseudoDeleteByID(int id)
        {
            var toDelete = _context.Etat.FirstOrDefault(e => e.Id_etat == id);
            toDelete.IsActive = false;
            _context.SaveChanges();


        }
    }
}
