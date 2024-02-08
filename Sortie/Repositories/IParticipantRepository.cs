using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IParticipantRepository
    {
        void AddSortie(Participant participant);
    }
}
