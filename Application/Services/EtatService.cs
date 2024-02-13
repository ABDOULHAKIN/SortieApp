using Domain.Entities;
using Infrastructure.Repositories;
using Application.Dto;
using AutoMapper;

namespace Application.Services
{
    public class EtatService : IEtatService
    {
        private IMapper _mapper { get; }

        public IEtatRepository _retatRpository { get; set; }

        public EtatService(IEtatRepository retatRpository, IMapper mapper)
        {
            _mapper = mapper;
            _retatRpository = retatRpository;

        }

        public int AddEtat(EtatDto etatDto)
        {
            try
            {
                Etat nouvelEtat = _mapper.Map<EtatDto, Etat>(etatDto);
                _retatRpository.AddEtat(nouvelEtat);
                return nouvelEtat.Id_etat;

            }
            catch (Exception ex)
            {
                throw;
            }


        }


        public EtatSortie GetEtat(int id)
        {

            //mapper
            Etat etatDAO = _retatRpository.GetEtatById(id);
            if (etatDAO != null)
            {
                var etatSortie = _mapper.Map<EtatSortie>(etatDAO);
                return etatSortie;

            }
            return null;
        }

        public void DeleteEtat(int id)
        {
            _retatRpository.PseudoDeleteByID(id);
        }
    }
}
