using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class SortieService : ISortieService
    {
         public ISortieRepository _rsortieRpository {  get; set; }

          public SortieService(ISortieRepository rsortieRpository)
        {
             _rsortieRpository = rsortieRpository;
        }

        public void AddSortie(Sortie sortie)
        {
             _rsortieRpository.AddSortie(sortie);
        }
    }
}
