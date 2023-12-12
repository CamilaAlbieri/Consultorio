

namespace ConsultorioApp.Models
{
    public class PacienteModel
    {
        public int Id { get; set; }
        public String? Nome { get; set; }
        public String? CPF { get; set; }
        public String? Telefone { get; set; }
        public String? Observacao { get; set; }
        public int idConvenio { get; set; }
        public String? nomeConvenio { get; set; }

    }
}
