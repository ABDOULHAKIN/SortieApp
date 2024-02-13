using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Dto;
using FluentValidation;
using FluentValidation.Results;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class SortieController : ControllerBase
    {
        public ISortieService _sortieService { get; set; }

        private IValidator<SortieDto> _validator;

        public SortieController(ISortieService sortieService, IValidator<SortieDto> validator) {
            _sortieService = sortieService;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> AddSortie(SortieDto sortie)
        {
            try
            {
                ValidationResult result = _validator.Validate(sortie);

                if (!result.IsValid)
                {
                    return BadRequest(result.Errors);
                }

                _sortieService.AddSortie(sortie);
                return Ok(sortie);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetSortie(int sortieId)
        {
            try
            {
                var sortie = _sortieService.GetSortie(sortieId);
                return Ok(sortie);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSortieDto(updateSortieDto sortie)
        {
            try
            {
                _sortieService.Update(sortie);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Supprimer une sortie

        [HttpDelete]
        public async Task<IActionResult> DeleteSortie(int sortieId)
        {
            try
            {
                var sortie = _sortieService.DeleteSortie(sortieId);
                return Ok(sortie);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
