using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class InscriptionRepository : IInscriptionRepository
    {
        public readonly InscriptionContext _context;

        // Une injection de dépendances
        public InscriptionRepository(InscriptionContext context)
        {
            _context = context;
        }

        public void AddInscription(Inscription inscription)
        {
            try
            {
                _context.Inscription.Add(inscription);
                _context.SaveChanges();
            }
            catch (Exception e) {
                throw;
            }
        }

        public Inscription GetInscriptionById(int id)
        {
            Inscription result = _context.Inscription.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
