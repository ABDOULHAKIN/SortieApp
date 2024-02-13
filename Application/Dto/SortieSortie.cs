using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class SortieSortie
    {
        public int Id { get; init; }
        public string Nom { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int OrganisateurId {  get; set; }
        public int LieuId {  get; set; }
        public int EtatId {  get; set; }
        public bool IsActive { get; set; } = true;



    }
}
