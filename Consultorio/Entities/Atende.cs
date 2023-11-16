using Consultorio.Domain.Base;

namespace Consultorio.Domain.Entities
{
    public class Atende : BaseEntity<int>
    {

        public Atende() { }

        public Atende(int id, Dentista? dentista, Convenio? convenio)
        {
            Dentista = dentista;
            Convenio = convenio;
        }

        public Dentista? Dentista { get; set; }
        public Convenio? Convenio { get; set; }
    }
}
