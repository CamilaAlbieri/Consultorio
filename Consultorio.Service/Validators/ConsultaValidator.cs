using FluentValidation;
using Consultorio.Domain.Entities;

namespace Consultorio.Service.Validators
{
    public class ConsultaValidator : AbstractValidator<Consulta>
    {
        public ConsultaValidator() 
        {
            RuleFor(c => c.Valor)
                  .NotEmpty().WithMessage("Por favor informe o valor da consulta.")
                  .NotNull().WithMessage("Por favor informe o valor da consulta.");

            RuleFor(c => c.Data)
                  .NotEmpty().WithMessage("Por favor informe o data da consulta.")
                  .NotNull().WithMessage("Por favor informe o data da consulta.");

        }
    }
}
