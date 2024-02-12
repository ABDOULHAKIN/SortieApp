using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Dto;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        public IRoleService _roleService { get; set; }
        public RoleController(IRoleService roleService) {
            _roleService = roleService;
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleDto role)
        {
            try
            {
                _roleService.AddRole(role);
                return Ok(role);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
