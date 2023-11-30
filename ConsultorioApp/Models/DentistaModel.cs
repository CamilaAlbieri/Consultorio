namespace ConsultorioApp.Models
{
    public class DentistaModel
    {
        public DentistaModel()
        {
            Especialidades = new List<DentistaEspecialidadeModel>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? CPF { get; set; }
        public List<DentistaEspecialidadeModel> Especialidades { get; set; }
    }

    public class DentistaEspecialidadeModel
    {
        public int Id { get; set; }
       
    }
}