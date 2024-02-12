using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Dto;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class SortieController : ControllerBase
    {
        public ISortieService _sortieService { get; set; }
        public SortieController(ISortieService sortieService) {
            _sortieService = sortieService;
        }

        [HttpPost]
        public async Task<IActionResult> AddSortie(SortieDto sortie)
        {
            try
            {
                _sortieService.AddSortie(sortie);
                return Ok(sortie);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
