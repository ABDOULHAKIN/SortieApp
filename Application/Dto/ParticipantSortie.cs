using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class ParticipantSortie
    {
        public int Id { get; init; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }

        public int RoleId { get; set; }
        public bool IsActive { get; set; } = true;



    }
}
