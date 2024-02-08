using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface ISortieRepository
    {
        void AddSortie(Sortie sortie);
    }
}
