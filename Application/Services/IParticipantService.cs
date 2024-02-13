using Application.Dto;


namespace Application.Services
{
    public interface IParticipantService
    {
        int AddParticipant(ParticipantDto participant);
        ParticipantDto GetParticipant(int id);

    }
}
