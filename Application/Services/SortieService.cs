using Domain.Entities;
using Infrastructure.Repositories;
using Application.Dto;
using AutoMapper;

namespace Application.Services
{
    public class SortieService : ISortieService
    {
        public ISortieRepository _rsortieRpository { get; set; }
        private IMapper _mapper { get; }
        public SortieService(ISortieRepository rsortieRpository, IMapper mapper)
        {
            _rsortieRpository = rsortieRpository;
            _mapper = mapper;
        }

        public int AddSortie(SortieDto sortieDto)
        {
            try
            {
                var nouvelleSortie = _mapper.Map<Sortie>(sortieDto);
                _rsortieRpository.AddSortie(nouvelleSortie);
                return nouvelleSortie.Id;
            }
            catch (Exception ex)
            {

            }
            return -1;
        }

        public SortieSortie GetSortie(int id)
        {
            Sortie sortieDao = _rsortieRpository.GetSortieByID(id);
            SortieSortie result = _mapper.Map<Sortie, SortieSortie>(sortieDao);
            return result;
        }
    }
}
