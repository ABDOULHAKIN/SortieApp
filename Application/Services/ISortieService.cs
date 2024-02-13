

using Application.Dto;

namespace Application.Services
{
    public interface ISortieService
    {
        int AddSortie(SortieDto sortie);
        SortieSortie GetSortie(int id); 
    }
}
