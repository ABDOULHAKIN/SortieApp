using Application.Dto;
using Application.Services;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SortieWebApp.Controller
{
    [Route("api/[controller]")]
    public class ParticipantController : ControllerBase
    {
        public IParticipantService _participantService { get; set; }
        private IValidator<ParticipantDto> _validator;


        public ParticipantController(IParticipantService participantService, IValidator<ParticipantDto> validator)
        {
            _participantService = participantService;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> AddParticipant(ParticipantDto participantDto)
        {

            ValidationResult result = await _validator.ValidateAsync(participantDto);
            if (!result.IsValid)
            {




                return BadRequest("non");
            }

            try
            {

                
                _participantService.AddParticipant(participantDto);
                return Ok(participantDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpGet]
        public async Task<IActionResult> GetParticipant(int id)
        {
            var result = _participantService.GetParticipant(id) ;
            return Ok(result);
        }
    }
}