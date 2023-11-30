using Consultorio.App.Base;
using Consultorio.Domain.Base;
using Consultorio.Domain.Entities;
using ConsultorioApp.Models;

namespace Consultorio.App.Cadastros
{
    public partial class CadastroDentista : CadastroBase
    {
        private List<DentistaEspecialidadeModel> _dentistaEspecialidade;
        private readonly IBaseService<Dentista> _dentistaService;
        private readonly IBaseService<Especialidade> _especialidadeService;

        private List<DentistaModel>? dentistas;
        public CadastroDentista(IBaseService<Dentista> dentistaervice, IBaseService<Especialidade> especialidadeService)
        {
            _dentistaService = dentistaervice;
            _dentistaEspecialidade = new List<DentistaEspecialidadeModel>();
            InitializeComponent();
        }

        private void PreencheObjeto(Dentista dentista)
        {
            dentista.Nome = txtNome.Text;
            dentista.Nome = txtTelefone.Text;
            dentista.CPF= txtCPF.Text;

            //Add Especialidade
        }

    }
}
