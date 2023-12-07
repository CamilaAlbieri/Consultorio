using Consultorio.Domain.Base;
using Consultorio.Domain.Entities;
using ConsultorioApp.Models;

namespace Consultorio.App.Base
{
    public partial class CadastroPaciente : CadastroBase
    {
        private readonly IBaseService<Paciente> _pacienteService;
        private readonly IBaseService<Convenio> _convenioService;

        private List<PacienteModel>? pacientes;

        public CadastroPaciente(IBaseService<Paciente> pacienteService, IBaseService<Convenio> convenioService)
        {
            _pacienteService = pacienteService;
            _convenioService = convenioService;
            InitializeComponent();
            CarregaCombo();
        }

        private void CarregaCombo()
        {
            cboConvenio.ValueMember = "Id";
            cboConvenio.DisplayMember= "Name";
            cboConvenio.DataSource = _convenioService.Get<ConvenioModel>().ToList();
        }

        private void PreencheObjeto(Paciente paciente)
        {
            paciente.Nome = txtNome.Text;
            paciente.Telefone = txtTelefone.Text;
            paciente.CPF= txtCPF.Text;
            paciente.Observacao= txtObservacao.Text;

            if(int.TryParse(cboConvenio.SelectedValue.ToString(), out var idGrupo))
            {
                var convenio = _convenioService.GetById<Convenio>(idGrupo);
                paciente.Convenio = convenio;
            }
        }

        /*
        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if())
                    {
                       
                    }
                }
            }
        }*/


    }
}
