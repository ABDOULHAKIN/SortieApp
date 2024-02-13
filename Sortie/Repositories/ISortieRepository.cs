using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface ISortieRepository
    {
        int AddSortie(Sortie sortie);
        Sortie? GetSortie(int id);
        void UpdateSortie(Sortie sortie);
        void DeleteSortie(Sortie sortie);
    }
}
