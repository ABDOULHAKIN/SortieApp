using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Dto;
using FluentValidation;
using FluentValidation.Results;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class LieuController : ControllerBase
    {
        public ILieuService _lieuService { get; set; }

        private IValidator<LieuDto> _validator;

        public LieuController(ILieuService lieuService, IValidator<LieuDto> validator) {
            _lieuService = lieuService;
            _validator = validator; 
        }

        [HttpPost]
        public async Task<IActionResult> AddLieu(LieuDto lieu)
        {
            try
            {
                ValidationResult result = _validator.Validate(lieu);

                if (!result.IsValid)
                {
                    return BadRequest(result.Errors);
                }

                _lieuService.AddLieu(lieu);
                return Ok(lieu);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
