using Consultorio.Domain.Base;

namespace Consultorio.Domain.Entities
{
    public class Especialidade : BaseEntity<int>
    {
        public Especialidade() { }
        public Especialidade(int id, string? nome) : base(id) 
        {
            Nome = nome;
        }
        public string? Nome { get; set; }
    }
}
