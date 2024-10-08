﻿using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Dto;
using FluentValidation;
using FluentValidation.Results;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class EtatController : ControllerBase
    {
        public IEtatService _etatService { get; set; }
        private IValidator<EtatDto> _validator;

        public EtatController(IEtatService sortieService, IValidator<EtatDto> validator) {
            _etatService = sortieService;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> AddEtat(EtatDto etat)
        {
            try
            {
                ValidationResult result = _validator.Validate(etat);

                if (!result.IsValid)
                {
                    return BadRequest(result.Errors);
                }

                var etatId = _etatService.AddEtat(etat);
                return Ok(etatId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetEtat(int etatId)
        {
            try
            {
                var etat = _etatService.GetEtat(etatId);
                return Ok(etat);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
