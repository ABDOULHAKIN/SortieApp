using Application.Dto;
using AutoMapper;
using Azure;
using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.IdentityModel.Tokens;

namespace Application.Services
{
    public class EtatService : IEtatService
    {
        public IEtatRepository _retatRpository {  get; set; }
        private IMapper _mapper { get; set; }


        public EtatService(IEtatRepository retatRpository, IMapper mapper)
        {
            _mapper = mapper;
            _retatRpository = retatRpository;
        }


        public int AddEtat(EtatDto etatDto)
        {
            try
            {
                // On fait le mappping 
                var etat = _mapper.Map<Etat>(etatDto);
                return _retatRpository.AddEtat(etat);
            }
            catch (Exception e) 
            {
                return -1;
                throw;
            }
        }

        public EtatDto GetEtat(int id)
        {
            var etat =  _retatRpository.GetById(id);
            if (etat != null) {
                var dto = _mapper.Map<EtatDto>(etat);
                return dto;
            }
            return null;
        }
    }
}
