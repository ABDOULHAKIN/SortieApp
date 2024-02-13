﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Lieu
    {
        [Key]
        public int Id { get; set; }
        public string Etablissement { get; set; }
        public string Ville { get; set; }
        public string Adresse { get; set; }
        [Column("code_postal")]
        public string CodePostale { get; set; }
        [Column("coordonnees_gps")]
        public string CoordonneesGps { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; } = true;

    }
}
