using Application.Dto;
using AutoMapper;
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

        public void AddInscription(InscriptionDto inscriptionDto)
        {
            var inscription = _mapper.Map<Inscription>(inscriptionDto);
            _rinscriptionRpository.AddInscription(inscription);
        } 
    }
}
