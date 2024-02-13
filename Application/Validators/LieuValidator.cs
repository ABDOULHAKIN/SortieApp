using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Validators
{
    public class LieuValidator : AbstractValidator<LieuDto>
    {
        public LieuValidator()
        {
            RuleFor(x => x.Adresse).NotNull();
        }
        
        


    }
}
