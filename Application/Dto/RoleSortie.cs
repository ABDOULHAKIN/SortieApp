using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class RoleSortie
    {
        public int Id { get; init; }
        public string Libelle { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
