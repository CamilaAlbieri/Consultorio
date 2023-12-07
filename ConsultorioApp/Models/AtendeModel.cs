

namespace ConsultorioApp.Models
{
    public class AtendeModel
    {
        
        public int Id { get; set; }

        public int IdDentista { get; set; }
        public string ?NomeDentista { get; set; }

        public int idConvenio { get; set; }
        public String nomeConvenio { get; set; }

    }
}
