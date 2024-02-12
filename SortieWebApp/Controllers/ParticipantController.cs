using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Dto;
using FluentValidation;
using System;
using FluentValidation.Results;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class ParticipantController : ControllerBase
    {
        public IParticipantService _ParticipantService { get; set; }
        private IValidator<ParticipantDto> _validator;

        public ParticipantController(IParticipantService participantService, IValidator<ParticipantDto> validator) {
            _ParticipantService = participantService;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> AddParticipant(ParticipantDto participant)
        {
            try
            {
                ValidationResult result = _validator.Validate(participant);

                if (!result.IsValid) {
                    return BadRequest(result.Errors);
                }

                _ParticipantService.AddParticipant(participant);
                return Ok(participant);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
