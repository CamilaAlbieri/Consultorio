

namespace ConsultorioApp.Models
{
    public class ConsultaModel
    {
        public int Id { get; set; }

        public int idDentista { get; set; }

        public int idPaciente {get; set;}
        
        public String? nomeDentista { get; set; }

        public String? nomePaciente { get; set; }

        public float? Valor { get; set; }
        public DateTime? Data { get; set; }
        public String? Descricao { get; set; }
    }


}
