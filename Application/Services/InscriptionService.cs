using Application.Dto;
using AutoMapper;
using Azure;
using Domain.Entities;
using Infrastructure.Repositories;


namespace Application.Services
{
    public class InscriptionService : IInscriptionService
    {
        public IInscriptionRepository _rinscriptionRpository { get; set; }
        private IMapper _mapper {  get; set; }

        public InscriptionService(IInscriptionRepository rInscriptionRpository, IMapper mapper)
        {
            _mapper = mapper;
            _rinscriptionRpository = rInscriptionRpository;
        }

        public int AddInscription(InscriptionDto inscriptionDto)
        {
            var inscription = _mapper.Map<Inscription>(inscriptionDto);
          
            return _rinscriptionRpository.AddInscription(inscription);
        }

        public InscriptionDto GetInscription(int id)
        {
            var inscription = _rinscriptionRpository.GetById(id);
            if (inscription != null)
            {
                var dtoPourAvoirIdiInscription = _mapper.Map<InscriptionDto>(inscription);
                return dtoPourAvoirIdiInscription;
            }
            return null;
        }
    }
}
