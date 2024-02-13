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


        public int AddParticipant(ParticipantDto participantDto)
        {
            try
            {
                // On fait le mappping 
                var participant = _mapper.Map<Participant>(participantDto);
                return _rparticipantRpository.AddParticipant(participant);
            }
            catch (Exception e)
            {
                return -1;
                throw;
            }
        }

        public ParticipantDto GetParticipant(int id)
        {
            var participant = _rparticipantRpository.GetParticipant(id);
            if (participant != null)
            {
                var dtoPourAvoirIdParticpant = _mapper.Map<ParticipantDto>(participant);
                return dtoPourAvoirIdParticpant;
            }
            return null;
        }
    }
}
