using Domain.Entities;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ParticipantService : IParticipantService
    {
        public ISortieRepository _rsortieRpository { get; set; }

        public ParticipantService(ISortieRepository rsortieRpository)
        {
            _rsortieRpository = rsortieRpository;
        }

        public void AddSortie(Sortie sortie)
        {
            _rsortieRpository.AddSortie(sortie);
        }
    }
}
