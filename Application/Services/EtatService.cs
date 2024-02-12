using Application.Dto;
using AutoMapper;
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


        public void AddEtat(EtatDto etatDto)
        {
            try
            {
                // On fait le mappping 
                var etat = _mapper.Map<Etat>(etatDto);
                _retatRpository.AddEtat(etat);
            }
            catch (Exception e) {
                throw;
            }
        }
    }
}
