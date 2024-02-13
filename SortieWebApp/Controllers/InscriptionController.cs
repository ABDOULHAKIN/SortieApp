using Application.Dto;
using Application.Services;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace SortieWebApp.Controller
{
    [Route("api/[controller]")]
    public class InscriptionController : ControllerBase
    {
        public IInscriptionService _inscriptionService { get; set; }
        private IValidator<InscriptionDto> _validator { get; }

        public InscriptionController(IInscriptionService inscriptionService, IValidator<InscriptionDto> validator)
        {
            _inscriptionService = inscriptionService;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> AddInscription(InscriptionDto inscriptionDto)
        {
            ValidationResult result = await _validator.ValidateAsync(inscriptionDto);
            if (!result.IsValid)
            {




                return BadRequest("non");
            }

            try
            {
                _inscriptionService.AddInscription(inscriptionDto);
                return Ok(inscriptionDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetInscription(int id)
        {

            var result = _inscriptionService.GetInscriptionService(id);
            return Ok(result);
        }


    }
}