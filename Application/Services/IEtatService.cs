using Application.Dto;
using Domain.Entities;

namespace Application.Services
{
    public interface IEtatService
    {
        int AddEtat(EtatDto etat);
        EtatDto GetEtat(int etatId);
    }
}
