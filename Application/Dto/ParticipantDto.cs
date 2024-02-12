

namespace Application.Dto
{
    public class ParticipantDto
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }

        public int RoleId { get; set; }
    }
}
