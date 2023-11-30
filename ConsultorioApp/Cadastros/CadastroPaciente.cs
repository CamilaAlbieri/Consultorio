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
        }

        private void PreencheObjeto(Paciente paciente)
        {
            paciente.Nome = txtNome.Text;
            paciente.Telefone = txtTelefone.Text;
            paciente.CPF= txtCPF.Text;
            paciente.Observacao= txtObservacao.Text;
        }


    }
}
