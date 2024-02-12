using Application.Dto;
using Domain.Entities;

namespace Application.Services
{
    public interface IEtatService
    {
        void AddEtat(EtatDto etat);
    }
}
