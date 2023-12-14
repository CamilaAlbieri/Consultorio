

using Consultorio.App.Base;
using Consultorio.Domain.Base;
using Consultorio.Domain.Entities;
using Consultorio.Service.Validators;
using ConsultorioApp.Models;
using System.Globalization;

namespace Consultorio.App.Cadastros
{
    public partial class CadastroConsulta : CadastroBase
    {
        private readonly IBaseService<Consulta> _consultaService;
        private readonly IBaseService<Dentista> _dentistaService;
        private readonly IBaseService<Paciente> _pacienteService;

        private List<ConsultaModel>? consultas;
        public CadastroConsulta(IBaseService<Consulta> consultaService, IBaseService<Dentista> dentistaService, IBaseService<Paciente> pacienteService)
        {
            _consultaService = consultaService;
            _dentistaService = dentistaService;
            _pacienteService = pacienteService;
            InitializeComponent();
            CarregaCombo();

        }

        private void CarregaCombo()
        {
            var dentista = _dentistaService.Get<DentistaModel>().ToList();

            var paciente = _pacienteService.Get<PacienteModel>().ToList();

            cboNomeDentista.ValueMember = "Id";
            cboNomeDentista.DisplayMember = "Nome";
            cboNomeDentista.DataSource = dentista;

            cboNomePaciente.ValueMember = "Id";
            cboNomePaciente.DisplayMember = "Nome";
            cboNomePaciente.DataSource = paciente;

            cboPesquisaNomeDentista.ValueMember = "Id";
            cboPesquisaNomeDentista.DisplayMember = "Nome";
            cboPesquisaNomeDentista.DataSource = dentista;

            cboPesquisaNomePaciente.ValueMember = "Id";
            cboPesquisaNomePaciente.DisplayMember = "Nome";
            cboPesquisaNomePaciente.DataSource = paciente;

        }

        private void PreencheObjeto(Consulta consulta)
        {
            if (int.TryParse(cboNomeDentista.SelectedValue.ToString(), out var idDentista))
            {
                var dentista = _dentistaService.GetById<Dentista>(idDentista);
                consulta.Dentista = dentista;
            }

            if (int.TryParse(cboNomePaciente.SelectedValue.ToString(), out var idPaciente))
            {
                var paciente = _pacienteService.GetById<Paciente>(idPaciente);
                consulta.Paciente = paciente;
            }


            consulta.Data = dtpDataConsulta.Value; ;



            if (float.TryParse(txtValorConsulta.Text, out var valorConsulta))
            {
                consulta.Valor = valorConsulta;
            }

            consulta.Descricao = txtDescricao.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {

                        var consulta = _consultaService.GetById<Consulta>(id, new List<String>() { "Dentista", "Paciente" });
                        PreencheObjeto(consulta);
                        consulta = _consultaService.Update<Consulta, Consulta, ConsultaValidator>(consulta);

                        Utils.Utils.messageBoxOk("Consulta atualizado com sucesso!", "Paciente");
                        LimpaCampos();
                    }

                }
                else
                {
                    var consulta = new Consulta();
                    PreencheObjeto(consulta);
                    consulta = _consultaService.Add<Consulta, Consulta, ConsultaValidator>(consulta);

                    Utils.Utils.messageExclamation("Consulta cadastrada com sucesso!", "Consulta");
                    LimpaCampos();
                }

                tabCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void Deletar(int id)
        {
            try
            {
                _consultaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            CarregaCombo();

            var includes = new List<string>() { "Dentista", "Paciente" };


            consultas = _consultaService.Get<ConsultaModel>(includes).ToList();

            dataGridViewConsulta.DataSource = consultas;
            //dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdDentista"]!.Visible = false;
            dataGridViewConsulta.Columns["IdPaciente"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtValorConsulta.Text = linha?.Cells["Valor"].Value.ToString();
            dtpDataConsulta.Text = linha?.Cells["Data"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value == null ? "" : linha?.Cells["Descricao"].Value.ToString();

        }

        private void btmPesquisar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                CarregaGrid();
            }
            else
            {
                var dentista = (DentistaModel)cboPesquisaNomeDentista.SelectedItem;
                var paciente = (PacienteModel)cboPesquisaNomePaciente.SelectedItem;
                var consultas = _consultaService.Get<ConsultaModel>(new List<String>() { "Dentista", "Paciente" }).ToList(); ;


                if (chkDentista.Checked)
                {

                    consultas = consultas
                      .Where(x => x.idDentista == dentista.Id)
                      .ToList();

                }

                if (chkPaciente.Checked)
                {
                    consultas = consultas
                  .Where(x => x.idPaciente == paciente.Id)
                  .ToList();

                }

                if (chkPesquisarData.Checked)
                {
                    var dataInicio = dtpInicio.Value.ToShortDateString();


                    consultas = consultas
                        .Where(x => x.Data.ToString()!.Split(" ")[0] == dataInicio).ToList();

                }


                dataGridViewConsulta.DataSource = consultas;
                //dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewConsulta.Columns["IdDentista"]!.Visible = false;
                dataGridViewConsulta.Columns["IdPaciente"]!.Visible = false;
            }
        }


    }
}
