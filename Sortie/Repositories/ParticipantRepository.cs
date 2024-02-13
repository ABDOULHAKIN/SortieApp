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

        public int AddParticipant(Participant participant)
        {
            try
            {
                var idParticipant = _context.Participant.Add(participant); ;
                _context.SaveChanges();
                return idParticipant.Entity.Id;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Participant? GetParticipant(int id)
        {
            try
            {
                var idParticipant = _context.Participant.Find(id);

                return idParticipant;
            }
            catch (Exception e)
            {
                //return -1;
                throw;
            }
        }
    }
}
