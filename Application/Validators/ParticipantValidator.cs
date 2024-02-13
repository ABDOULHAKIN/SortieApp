using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Validators
{
    public class ParticipantValidator : AbstractValidator<ParticipantDto>
    {
        public ParticipantValidator()
        {
            RuleFor(x => x.Prenom).NotNull();
        }
        

    }
}
