using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Dto;
using FluentValidation;
using FluentValidation.Results;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class InscriptionController : ControllerBase
    {
        public IInscriptionService _inscriptionService { get; set; }

        private IValidator<InscriptionDto> _validator;

        public InscriptionController(IInscriptionService inscriptionService, IValidator<InscriptionDto> validator) 
        {
            _inscriptionService = inscriptionService;
            _validator = validator; 
        }

        [HttpPost]
        public async Task<IActionResult> AddInscription(InscriptionDto inscription)
        {

            try
            {
                ValidationResult result = _validator.Validate(inscription);

                if (!result.IsValid)
                {
                    return BadRequest(result.Errors);
                }

                _inscriptionService.AddInscription(inscription);
                return Ok(inscription);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetInscription(int inscriptionId)
        {
            try
            {
                var inscription = _inscriptionService.GetInscription(inscriptionId);
                return Ok(inscription);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
