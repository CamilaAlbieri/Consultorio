using Consultorio.Domain.Base;

namespace Consultorio.Domain.Entities
{
    public class Convenio : BaseEntity<int>
    {

        public Convenio() { }

        public Convenio(int id, string? nome) : base(id)
        {
            Nome = nome;
        }

        public string? Nome { get; set; }
    }
}
