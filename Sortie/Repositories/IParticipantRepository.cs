using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IParticipantRepository
    {
        int AddParticipant(Participant participant);
        Participant? GetParticipant(int id);
    }
}
