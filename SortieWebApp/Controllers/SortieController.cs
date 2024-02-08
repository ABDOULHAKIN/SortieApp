using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;

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
        public async Task<IActionResult> AddSortie(int sortieid)
        {
            try
            {
                _sortieService.AddSortie(new Sortie());
                return Ok(new Sortie());
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
