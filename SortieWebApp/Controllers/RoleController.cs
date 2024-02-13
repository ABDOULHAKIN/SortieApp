using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Dto;
using FluentValidation;
using FluentValidation.Results;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        public IRoleService _roleService { get; set; }

        private IValidator<RoleDto> _validator;

        public RoleController(IRoleService roleService, IValidator<RoleDto> validator) {
            _roleService = roleService;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleDto role)
        {
            try
            {
                ValidationResult result = _validator.Validate(role);

                if (!result.IsValid)
                {
                    return BadRequest(result.Errors);
                }

                _roleService.AddRole(role);
                return Ok(role);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetRole(int roleId)
        {
            try
            {
                var role = _roleService.GetRole(roleId);
                return Ok(role);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
