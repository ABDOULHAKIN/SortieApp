using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface ISortieRepository
    {
        void AddSortie(Sortie sortie);
        Task<Sortie?> GetSortieByID(int id);

        void PseudoDeleteByID(int id);

        Task<int> UpdateSortie(Sortie sortie);
    }
}
