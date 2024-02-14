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
            Sortie sortieDao = _rsortieRpository.GetSortieByID(id).Result;
            SortieSortie result;
            if (sortieDao != null)
            {
                result = _mapper.Map<Sortie, SortieSortie>(sortieDao);
                return result;
            }

            return null;
        }


        public void DeleteSortie(int id)
        {
            _rsortieRpository.PseudoDeleteByID(id);
        }




        public async Task UpdateSortieService(int id, SortieDto sortie)
        {
            var previousOne = _rsortieRpository.GetSortieByID(id).Result;

             if (previousOne != null)
            {
                // Sortie mappedOne = new Sortie();
                //mappedOne.Id = previousOne.Id;
                previousOne.LieuId = sortie.LieuId;
                previousOne.OrganisateurId = sortie.OrganisateurId;
                previousOne.DateDebut = sortie.DateDebut;
                previousOne.DateDebut = sortie.DateFin;
                previousOne.Nom = sortie.Nom;



                await _rsortieRpository.UpdateSortie(previousOne);
                
            }
            
        }
    }
}
