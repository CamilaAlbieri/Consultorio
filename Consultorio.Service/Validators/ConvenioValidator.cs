using FluentValidation;
using Consultorio.Domain.Entities;

namespace Consultorio.Service.Validators
{
    public class ConvenioValidator : AbstractValidator<Convenio>
    {
        public ConvenioValidator() 
        {
            RuleFor(c => c.Nome)
                  .NotEmpty().WithMessage("Por favor informe o nome do convênio.")
                  .NotNull().WithMessage("Por favor informe o nome do convênio.");
        }
    }
}
