using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class RoleService : IRoleService
    {
         public IRoleRepository _rroleRpository {  get; set; }

          public RoleService(IRoleRepository rroleRpository)
        {
            _rroleRpository = rroleRpository;
        }

        public void AddRole(Role role)
        {
            _rroleRpository.AddRole(role);
        }

       
    }
}
