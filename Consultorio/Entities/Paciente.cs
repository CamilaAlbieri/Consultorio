using Consultorio.Domain.Base;

namespace Consultorio.Domain.Entities
{
    public class Paciente : BaseEntity<int>
    {

        public Paciente() { }

        public Paciente(int id, string? nome, string? cpf, string ? telefone, string? observacao, Convenio? convenio) : base(id)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Observacao = observacao;
            Convenio = convenio;

        }

        public string? Nome { get; set; }
        public string? CPF { get; set;}
        public string? Telefone { get; set;}
        public string? Observacao { get; set; }
        public Convenio? Convenio { get; set; } 


            
    }
}
