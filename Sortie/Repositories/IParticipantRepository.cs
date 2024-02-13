using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IParticipantRepository
    {
        void AddParticipant(Participant participant);
        Participant GetParticipantById(int id);
    }
}
