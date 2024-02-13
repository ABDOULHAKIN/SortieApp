using Application.Services;
using Application.Dto;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using FluentValidation.Results;

namespace SortieWebApp.Controller
{
    [Route("api/[controller]")]
    public class EtatController : ControllerBase
    {
        public IEtatService _etatService { get; set; }
        private IValidator<EtatDto> _validator { get; }

        public EtatController(IEtatService etatService, IValidator<EtatDto> validator)
        {
            _etatService = etatService;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> AddEtat(EtatDto etatDto)
        {

            ValidationResult result = await _validator.ValidateAsync(etatDto);


            if (!result.IsValid)
            {




                return BadRequest("non");
            }
            try
            {
                int idInsert = _etatService.AddEtat(etatDto);
                return Ok(_etatService.GetEtat(idInsert));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetEtat(int id)
        {

            var result = _etatService.GetEtat(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found hehe");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteEtat(int id)
        {



            _etatService.DeleteEtat(id);
            return Ok($"Etat id {id} désactivé");
        }



    }
}