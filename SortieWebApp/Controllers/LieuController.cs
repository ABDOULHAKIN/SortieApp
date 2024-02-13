using Application.Dto;
using Application.Services;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace SortieWebApp.Controller
{
    [Route("api/[controller]")]
    public class LieuController : ControllerBase
    {
        public ILieuService _lieuService { get; set; }
        private IValidator<LieuDto> _validator { get; }

        public LieuController(ILieuService lieuService, IValidator<LieuDto> validator)
        {
            _lieuService = lieuService;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> AddLieu(LieuDto lieuDto)
        {
            ValidationResult result = await _validator.ValidateAsync(lieuDto);

            if (!result.IsValid)
            {

                return BadRequest("non");
            }


            try
            {
             int inserted = _lieuService.AddLieu(lieuDto);
                return Ok(_lieuService.GetLieu(inserted));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpGet]
        public async Task<IActionResult> GetLieu(int id)
        {

            var result = _lieuService.GetLieu(id);


            return Ok(result);
        }
    }

 
}