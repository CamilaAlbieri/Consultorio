using FluentValidation;
using Consultorio.Domain.Entities;

namespace Consultorio.Service.Validators
{
    public class EspecialidadeValidator : AbstractValidator<Especialidade>
    {
        public EspecialidadeValidator() 
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome da especialidade.")
                .NotNull().WithMessage("Por favor informe o nome da especialidade.");
        }
    }
}
