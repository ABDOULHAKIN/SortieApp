using Domain.Entities;
using Infrastructure.Repositories;
using Application.Dto;
using AutoMapper;


namespace Application.Services
{
    public class InscriptionService : IInscriptionService
    {
        public IInscriptionRepository _rinscriptionRepository { get; set; }
        private IMapper _mapper { get; }

        public InscriptionService(IInscriptionRepository rinscriptionRepository, IMapper mapper)
        {
            _rinscriptionRepository = rinscriptionRepository;
            _mapper = mapper;
        }

        public void AddInscription(InscriptionDto inscription)
        {
            try
            {
                var nouvelleInscription = _mapper.Map<InscriptionDto, Inscription>(inscription);
                _rinscriptionRepository.AddInscription(nouvelleInscription);
            }
            catch (Exception ex)
            {

            }

        }

        public InscriptionSortie GetInscriptionService(int id)
        {
            Inscription inscriptionDao = _rinscriptionRepository.GetInscriptionById(id);
            InscriptionSortie result = _mapper.Map<Inscription, InscriptionSortie>(inscriptionDao);
            return result;
        }
    }
}