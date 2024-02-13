using Application.Dto;


namespace Application.Services
{
    public interface IInscriptionService
    {
        int AddInscription(InscriptionDto inscription);
        InscriptionDto GetInscription(int inscriptionId);
    }      
}
