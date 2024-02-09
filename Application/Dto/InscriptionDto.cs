using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InscriptionDto
    {
        public int Id { get; set; }
        public int ParticipantId { get; set; }
        public int SortieId { get; set; }

    }
}
