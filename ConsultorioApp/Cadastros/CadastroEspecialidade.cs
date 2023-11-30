

using Consultorio.App.Base;
using Consultorio.Domain.Base;
using Consultorio.Domain.Entities;

namespace Consultorio.App.Cadastros
{
    public partial class CadastroEspecialidade : CadastroBase
    {
        private readonly IBaseService<Especialidade> _especialidadeService;

        private List<Especialidade>? especialidades;

        public CadastroEspecialidade(IBaseService<Especialidade> especialidadeService)
        {
           _especialidadeService = especialidadeService;
            InitializeComponent();
        }




    }
}
