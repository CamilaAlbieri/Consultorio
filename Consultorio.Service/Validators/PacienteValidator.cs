using FluentValidation;
using Consultorio.Domain.Entities;

namespace Consultorio.Service.Validators
{
    public class PacienteValidator : AbstractValidator<Paciente>
    {
        public PacienteValidator() 
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("Por favor informe o cpf.")
                .NotNull().WithMessage("Por favor informe o cpf.");

            RuleFor(c => c.Telefone)
                .NotEmpty().WithMessage("Por favor informe o telefone.")
                .NotNull().WithMessage("Por favor informe o telefone.");
        }
    }
}
