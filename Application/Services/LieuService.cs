using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class LieuService : ILieuService
    {
         public ILieuRepository _rlieuRpository {  get; set; }

          public LieuService(ILieuRepository rlieuRpository)
        {
            _rlieuRpository = rlieuRpository;
        }

        public void AddLieu(Lieu lieu)
        {
            _rlieuRpository.AddLieu(lieu);
        }
    }
}
