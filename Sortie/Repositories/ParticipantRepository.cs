using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class ParticipantRepository : IParticipantRepository
    {
        public readonly ParticipantContext _context;

        // Une injection de dépendances
        public ParticipantRepository(ParticipantContext context)
        {
            _context = context;
        }

        public void AddSortie(Participant participant)
        {
            try
            {
                _context.Sortie.Add(participant);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
