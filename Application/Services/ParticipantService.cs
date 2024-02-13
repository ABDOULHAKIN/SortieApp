using Domain.Entities;
using Infrastructure.Repositories;
using Application.Dto;
using AutoMapper;


namespace Application.Services
{
    public class ParticipantService : IParticipantService
    {
        public IParticipantRepository _rparticipantRpository { get; set; }
        private IMapper _mapper { get; }

        public ParticipantService(IParticipantRepository rParticipantRpository, IMapper mapper)
        {
            _rparticipantRpository = rParticipantRpository;
            _mapper = mapper;

        }

        public void AddParticipant(ParticipantDto participantDto)
        {
            try
            {
                var nouveauParticipant = _mapper.Map<ParticipantDto, Participant>(participantDto);

                _rparticipantRpository.AddParticipant(nouveauParticipant);
            }
            catch (Exception ex)
            {

            }

        }

        public ParticipantSortie GetParticipant(int id)
        {
            ParticipantSortie result = _mapper.Map<Participant, ParticipantSortie>(_rparticipantRpository.GetParticipantById(id));
            return result;
        }
    }
}
