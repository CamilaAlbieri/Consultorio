using Consultorio.Domain.Base;

namespace Consultorio.Domain.Entities
{
    public class Consulta : BaseEntity<int>
    {

        public Consulta() { }

        public Consulta(int id, Dentista? dentita, Paciente? paciente, float? valor, DateTime? data, string? descricao) : base(id) 
        { 
            Dentista = dentita;
            Paciente = paciente;
            Valor = valor;
            Data = data;
            Descricao = descricao;
        }

        public Dentista? Dentista { get; set; }
        public Paciente? Paciente { get; set; }
        public float? Valor { get; set; }
        public DateTime? Data { get; set; }
        public string? Descricao { get; set;}

    }
}
