

using Application.Dto;

namespace Application.Services
{
    public interface ISortieService
    {
        int AddSortie(SortieDto sortie);
        SortieSortie GetSortie(int id);

        void DeleteSortie(int id);

        Task UpdateSortieService(int id, SortieDto sortie);
    }
}
