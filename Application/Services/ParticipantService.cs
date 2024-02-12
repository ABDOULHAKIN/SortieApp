using Application.Dto;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Repositories;


namespace Application.Services
{
    public class ParticipantService : IParticipantService
    {
        public IParticipantRepository _rparticipantRpository { get; set; }

        private IMapper _mapper {  get; set; }

        public ParticipantService(IParticipantRepository rParticipantRpository, IMapper mapper)
        {
            _mapper = mapper;
            _rparticipantRpository = rParticipantRpository;
        }

        public void AddParticipant(ParticipantDto participantDto)
        {
            var participant = _mapper.Map<Participant>(participantDto);
            _rparticipantRpository.AddParticipant(participant);
        }
    }
}
