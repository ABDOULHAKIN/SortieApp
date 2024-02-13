using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IInscriptionRepository
    {
        void AddInscription(Inscription inscription);
        Inscription GetInscriptionById(int id);
    }
}
