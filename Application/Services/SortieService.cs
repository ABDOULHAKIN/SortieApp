using Application.Dto;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class SortieService : ISortieService
    {
         public ISortieRepository _rsortieRpository {  get; set; }
         private IMapper _mapper {  get; set; }

         public SortieService(ISortieRepository rsortieRpository, IMapper mapper)
        {
            _mapper = mapper; 
             _rsortieRpository = rsortieRpository;
        }

        public void AddSortie(SortieDto sortieDto)
        {
            var sortie = _mapper.Map<Sortie>(sortieDto);
            _rsortieRpository.AddSortie(sortie);
        }
    }
}
