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

        public int AddSortie(SortieDto sortieDto)
        {
            try
            {
                // On fait le mappping 
                var sortie = _mapper.Map<Sortie>(sortieDto);
                return _rsortieRpository.AddSortie(sortie);
            }
            catch (Exception e)
            {
                return -1;
                throw;
            }
        }

        public SortieDto? GetSortie(int id)
        {
            var sortie = _rsortieRpository.GetSortie(id);
            if (sortie != null)
            {
              /*var dtoPourAvoirSortieDto = _mapper.Map<SortieDto>(sortie);
                return dtoPourAvoirSortieDto;*/
                try
                {
                    return _mapper.Map<SortieDto>(sortie);
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return null;
        }

        public void Update(updateSortieDto updatedSortie)
        {
            var sortie = _rsortieRpository.GetSortie(updatedSortie.Id);
            if (sortie != null) {
                sortie.LieuId = updatedSortie.LieuId;
                sortie.Nom = updatedSortie.Nom;
                sortie.OrganisateurId = updatedSortie.OrganisateurId;
                sortie.DateDebut = updatedSortie.DateDebut;
                sortie.DateFin = updatedSortie.DateFin;
                sortie.EtatId = updatedSortie.EtatId;

                _rsortieRpository.UpdateSortie(sortie);
            }
            
            /*if (sortie != null)
            {
                *//*var dtoPourAvoirSortieDto = _mapper.Map<SortieDto>(sortie);
                  return dtoPourAvoirSortieDto;*//*
                try
                {
                    return _mapper.Map<SortieDto>(sortie);
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return null;
*/        }

        // Supprimer une sortie

        public void DeleteSortie(int id)
        {
            var sortie = _rsortieRpository.GetSortie(id);
            if (sortie != null)
            {
                try
                {
                    _rsortieRpository.DeleteSortie(id);
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            //return null;
        }
    }
}
