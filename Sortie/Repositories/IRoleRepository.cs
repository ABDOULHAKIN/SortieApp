using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IRoleRepository
    {
        void AddRole(Role role);
        Role GetRoleById(int id);
    }
}
