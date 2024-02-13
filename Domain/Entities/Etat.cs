using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Etat
    {
        [Key]
        [Column("id_etat")]
        public int Id_etat { get; set; }
        public string Libelle { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; } = true;
    }

    



}
