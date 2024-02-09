using Domain.Entities;
using Infrastructure.Repositories;


namespace Application.Services
{
    public class ParticipantService : IParticipantService
    {
        public IParticipantRepository _rparticipantRpository { get; set; }

        public ParticipantService(IParticipantRepository rParticipantRpository)
        {
            _rparticipantRpository = rParticipantRpository;
        }

        public void AddParticipant(Participant participant)
        {
            _rparticipantRpository.AddParticipant(participant);
        }
    }
}
