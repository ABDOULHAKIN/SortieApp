﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Role
    {
        [Column("id_role")]
        public int Id { get; set; }
        public string Libelle { get; set; }
    }
}
