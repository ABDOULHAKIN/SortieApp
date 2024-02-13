using Domain.Entities;
using Infrastructure.Repositories;
using Application.Dto;
using AutoMapper;

namespace Application.Services
{
    public class RoleService : IRoleService
    {
         public IRoleRepository _rroleRpository {  get; set; }
        private IMapper _mapper { get; }
        public RoleService(IRoleRepository rroleRpository, IMapper mapper)
        {
            _rroleRpository = rroleRpository;
            _mapper = mapper;
        }

        public void AddRole(RoleDto roleDto)
        {
            var nouveauRole = _mapper.Map<RoleDto, Role>(roleDto);

            _rroleRpository.AddRole(nouveauRole);
        }

        public RoleSortie GetRole(int id)
        {
            RoleSortie result = _mapper.Map<Role, RoleSortie>(_rroleRpository.GetRoleById(id));
            return result;
        }
    }
}
