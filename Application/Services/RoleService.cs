using Application.Dto;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class RoleService : IRoleService
    {
         public IRoleRepository _rroleRpository {  get; set; }
        private IMapper _mapper { get; set; }


        public RoleService(IRoleRepository rroleRpository, IMapper mapper)
        {
            _mapper = mapper;
            _rroleRpository = rroleRpository;
        }

        public void AddRole(RoleDto roleDto)
        {
            var role = _mapper.Map<Role>(roleDto);
            _rroleRpository.AddRole(role);
        }

       
    }
}
