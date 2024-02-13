using Application.Dto;

namespace Application.Services
{
    public interface ILieuService
    {
        int AddLieu(LieuDto lieu);
        LieuSortie GetLieu(int id);
    }
}
