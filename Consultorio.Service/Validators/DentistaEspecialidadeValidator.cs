

using Consultorio.Domain.Entities;
using FluentValidation;

namespace Consultorio.Service.Validators
{
    public class DentistaEspecialidadeValidator : AbstractValidator<DentistaEspecialidade>
    {
        public DentistaEspecialidadeValidator()
        {
            RuleFor(c => c.Dentista)
                    .NotEmpty().WithMessage("Por favor informe o nome.")
                    .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.Especialidade)
                    .NotEmpty().WithMessage("Por favor informe a especialidade.")
                    .NotNull().WithMessage("Por favor informe a especialidade.");

            
        }
    }
}
