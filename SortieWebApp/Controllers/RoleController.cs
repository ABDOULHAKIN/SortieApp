using Application.Dto;
using Application.Services;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace SortieWebApp.Controller
{
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        public IRoleService _roleService { get; set; }
        private IValidator<RoleDto> _validator { get; }

        public RoleController(IRoleService roleService, IValidator<RoleDto> validator)
        {
            _roleService = roleService;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleDto roleDto)
        {


            ValidationResult result = await _validator.ValidateAsync(roleDto);
            if (!result.IsValid)
            {
                return BadRequest("non");
            }
            try
            {
                _roleService.AddRole(roleDto);
                return Ok(roleDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetRole(int id)
        {

            RoleSortie result = _roleService.GetRole(id);
           
            return Ok(result);
        }
    }
}