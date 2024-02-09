using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IParticipantRepository
    {
        void AddParticipant(Participant participant);
    }
}
