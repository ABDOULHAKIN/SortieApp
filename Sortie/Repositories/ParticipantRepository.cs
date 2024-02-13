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

        public void AddParticipant(Participant participant)
        {
            try
            {
                _context.Participant.Add(participant);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Participant GetParticipantById(int id)
        {
            Participant result = _context.Participant.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
