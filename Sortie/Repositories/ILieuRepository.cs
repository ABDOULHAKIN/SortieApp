using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface ILieuRepository
    {




        void AddLieu(Lieu lieu);
        Lieu GetLieuById(int id);






    }
}
