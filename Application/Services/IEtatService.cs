using Application.Dto;

namespace Application.Services
{
    public interface IEtatService
    {
        int AddEtat(EtatDto etat);
        EtatSortie GetEtat(int id);
        void DeleteEtat(int id);
    }
}
