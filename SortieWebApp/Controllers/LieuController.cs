using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Dto;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class LieuController : ControllerBase
    {
        public ILieuService _lieuService { get; set; }
        public LieuController(ILieuService lieuService) {
            _lieuService = lieuService;
        }

        [HttpPost]
        public async Task<IActionResult> AddLieu(LieuDto lieu)
        {
            try
            {
                _lieuService.AddLieu(lieu);
                return Ok(lieu);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
