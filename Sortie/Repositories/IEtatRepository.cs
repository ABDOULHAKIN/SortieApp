using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IEtatRepository
    {
        void AddEtat(Etat etat);
        Etat GetEtatById(int id);

        void PseudoDeleteByID(int id);
    }
}
