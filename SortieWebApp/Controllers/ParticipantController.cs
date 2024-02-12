using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Dto;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class ParticipantController : ControllerBase
    {
        public IParticipantService _ParticipantService { get; set; }
        public ParticipantController(IParticipantService participantService) {
            _ParticipantService = participantService;
        }

        [HttpPost]
        public async Task<IActionResult> AddParticipant(ParticipantDto participant)
        {
            try
            {
                _ParticipantService.AddParticipant(participant);
                return Ok(new Participant());
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
