using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class EtatSortie
    {
        public int Id_etat { get; init;}
        public string Libelle { get; set; }

        public bool IsActive { get; set; }
    }
}
