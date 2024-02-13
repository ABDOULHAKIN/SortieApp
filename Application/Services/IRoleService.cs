using Application.Dto;


namespace Application.Services
{
    public interface IRoleService
    {
        int AddRole(RoleDto role);
        RoleDto? GetRole(int id);
    }
}
