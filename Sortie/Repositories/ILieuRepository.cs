using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface ILieuRepository
    {
        int AddLieu(Lieu lieu);
        Lieu? GetLieu(int id);
    }
}
