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

        public int AddInscription(Inscription inscription)
        {
            try
            {
                var idInscription = _context.Inscription.Add(inscription);
                _context.SaveChanges();
                return idInscription.Entity.Id;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Inscription? GetById(int id)
        {
            try
            {
                var idInscription = _context.Inscription.Find(id);

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
