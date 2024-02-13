﻿using Application.Dto;
using Application.Services;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SortieWebApp.Controller;


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
        public async Task<IActionResult> AddSortie(SortieDto sortieDto)
        {
            ValidationResult result = await _validator.ValidateAsync(sortieDto);
            try
            {
                int idInsert = _sortieService.AddSortie(sortieDto);
                return Ok(_sortieService.GetSortie(idInsert));
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpGet]
        public async Task<IActionResult> GetSortie(int id)
        {
            SortieSortie result = _sortieService.GetSortie(id);
            return Ok(result);
        }
    }
}
