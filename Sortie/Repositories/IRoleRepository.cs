using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IRoleRepository
    {
        int AddRole(Role role);
        Role? GetRole(int id);

    }
}
