using Consultorio.Domain.Base;

namespace Consultorio.Domain.Entities
{
    public class Dentista : BaseEntity<int>
    {
        public Dentista() 
        {
            Especialidades = new List<DentistaEspecialidade>();
        }

        public Dentista(int id, string? nome, string? telefone, string? cpf, List<DentistaEspecialidade> especialidades) : base(id)
        {
            Nome = nome;
            Telefone = telefone;
            CPF = cpf;            
            Especialidades = especialidades;
        }

        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? CPF { get; set;}        
        public List<DentistaEspecialidade> Especialidades { get; set; }
    }

    public class DentistaEspecialidade : BaseEntity<int>
    {
        public DentistaEspecialidade() { }

        public DentistaEspecialidade(int id, Dentista? dentista, Especialidade? especialidade) : base(id)
        {
            Dentista = dentista;
            Especialidade = especialidade;
        }

        public Dentista? Dentista { get; set; }
        public Especialidade? Especialidade { get; set; }
    }
}