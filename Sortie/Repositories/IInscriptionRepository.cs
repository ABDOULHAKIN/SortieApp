using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IInscriptionRepository
    {
        int AddInscription(Inscription inscription);
        Inscription? GetById(int id);
    }
}
