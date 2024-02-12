using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Dto;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class EtatController : ControllerBase
    {
        public IEtatService _etatService { get; set; }
        public EtatController(IEtatService sortieService) {
            _etatService = sortieService;
        }

        [HttpPost]
        public async Task<IActionResult> AddEtat(EtatDto etat)
        {
            try
            {
                _etatService.AddEtat(etat);
                return Ok(new Etat());
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
