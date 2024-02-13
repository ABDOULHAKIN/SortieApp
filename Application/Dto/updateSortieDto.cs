using System;
using System.Collections.Generic;
using System.Linq;


namespace Application.Dto
{
    public class updateSortieDto
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int OrganisateurId {  get; set; }
        public int LieuId {  get; set; }
        public int EtatId {  get; set; }
    }
}
