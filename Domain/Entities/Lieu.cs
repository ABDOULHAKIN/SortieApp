﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Lieu
    {
        public int Id { get; set; }
        public string Etablissement { get; set; }
        public string Ville { get; set; }
        public string Adresse { get; set; }
        public string CodePostale { get; set; }
        public string CoordonneesGps { get; set; }

    }
}
