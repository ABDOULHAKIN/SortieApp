using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class InscriptionSortie
    {
        public int Id { get; init; }
        public int ParticipantId { get; set; }
        public int SortieId { get; set; }
        public Boolean IsActive { get; set; } = true;



    }
}
