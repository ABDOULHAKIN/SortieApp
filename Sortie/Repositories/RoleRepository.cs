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

        public void AddRole(Role role)
        {
            try
            {
                _context.Role.Add(role);
                _context.SaveChanges();
            }
            catch (Exception e) {
                throw;
            }
        }
    }
}
