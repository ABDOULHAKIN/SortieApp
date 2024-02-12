using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IEtatRepository
    {
        int AddEtat(Etat etat);
    }
}
