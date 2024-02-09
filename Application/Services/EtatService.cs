using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class EtatService : IEtatService
    {
         public IEtatRepository _retatRpository {  get; set; }

          public EtatService(IEtatRepository retatRpository)
        {
            _retatRpository = retatRpository;
        }

        public void AddEtat(Etat etat)
        {
            _retatRpository.AddEtat(etat);
        }
    }
}
