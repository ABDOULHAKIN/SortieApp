using Application.Dto;
using Domain.Entities;

namespace Application.Services
{
    public interface ILieuService
    {
        int AddLieu(LieuDto lieu);
        LieuDto? GetLieu(int lieuId);
    }
}
