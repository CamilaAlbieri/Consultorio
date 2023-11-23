namespace ConsultorioApp.Models
{
    public class DentistaModel
    {
        public DentistaModel()
        {
            Especialidades = new List<DentistaEspecialidade>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? CPF { get; set; }
        public List<DentistaEspecialidade> Especialidades { get; set; }
    }

    public class DentistaEspecialidade
    {
        public int Id { get; set; }
       
    }
}