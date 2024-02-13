using Application.Dto;


namespace Application.Services
{
    public interface ISortieService
    {
        int AddSortie(SortieDto sortie);
        SortieDto GetSortie(int id);
        void Update(updateSortieDto updatedSortie);
    }
}
