using Application.Dto;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

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

        public int AddRole(RoleDto roleDto)
        {

            try
            {
                // On fait le mappping 
                var role = _mapper.Map<Role>(roleDto);
                return _rroleRpository.AddRole(role);
            }
            catch (Exception e)
            {
                return -1;
                throw;
            }
        }

        public RoleDto? GetRole(int id)
        {
            var role = _rroleRpository.GetRole(id);
            if (role != null)
            {
                var dtoPourAvoirIdRole = _mapper.Map<RoleDto>(role);
                return dtoPourAvoirIdRole;
            }
            return null;
        }


    }
}
