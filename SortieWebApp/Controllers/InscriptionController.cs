using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Dto;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class InscriptionController : ControllerBase
    {
        public IInscriptionService _inscriptionService { get; set; }
        public InscriptionController(IInscriptionService inscriptionService) {
            _inscriptionService = inscriptionService;
        }

        [HttpPost]
        public async Task<IActionResult> AddInscription(InscriptionDto inscription)
        {
            try
            {
                _inscriptionService.AddInscription(inscription);
                return Ok(inscription);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
