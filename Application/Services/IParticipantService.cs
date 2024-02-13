using Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IParticipantService
    {
        void AddParticipant(ParticipantDto participant);
        ParticipantSortie GetParticipant(int id);
    }
}
