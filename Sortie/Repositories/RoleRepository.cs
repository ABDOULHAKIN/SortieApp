using Azure;
using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        public readonly RoleContext _context;

        // Une injection de dépendances
        public RoleRepository(RoleContext context)
        {
            _context = context;
        }

        public int AddRole(Role role)
        {
            try
            {
                var idRole = _context.Role.Add(role);
                _context.SaveChanges();
                return idRole.Entity.Id;
            }
            catch (Exception e) {
                throw;
            }
        }

        public Role? GetRole(int id)
        {
            try
            {
                var idRole = _context.Role.Find(id);

                return idRole;
            }
            catch (Exception e)
            {
                //return -1;
                throw;
            }
        }
    }
}
