using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface ISortieRepository
    {
        int AddSortie(Sortie sortie);
    }
}
