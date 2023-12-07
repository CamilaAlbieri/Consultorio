

using Consultorio.App.Base;
using Consultorio.Domain.Base;
using Consultorio.Domain.Entities;

namespace Consultorio.App.Cadastros
{
    public partial class CadastroConvenio : CadastroBase
    {
        private readonly IBaseService<Convenio> _convenioService;

        private List<Convenio>? convenios;


        public CadastroConvenio(IBaseService<Convenio> convenioService)
        {
            _convenioService = convenioService;
            InitializeComponent();
        }

        private void PreencheObjeto(Convenio convenio)
        {
            convenio.Nome = txtConvenio.Text;
        
        }

        protected override void Salvar()
        {
            
        }



    }
}
