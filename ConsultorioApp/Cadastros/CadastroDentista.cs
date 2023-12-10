using Consultorio.App.Base;
using Consultorio.Domain.Base;
using Consultorio.Domain.Entities;
using Consultorio.Service.Validators;
using ConsultorioApp.Models;


namespace Consultorio.App.Cadastros
{
    public partial class CadastroDentista : CadastroBase
    {
        private List<DentistaEspecialidadeModel> _dentistaEspecialidade;
        private readonly IBaseService<Dentista> _dentistaService;
        private readonly IBaseService<Especialidade> _especialidadeService;

        private List<DentistaModel>? dentistas;
        public CadastroDentista(IBaseService<Dentista> dentistaService)
        {
            _dentistaService = dentistaService;
            _dentistaEspecialidade = new List<DentistaEspecialidadeModel>();
            InitializeComponent();
            CarregaCombo();
        }

        private void CarregaCombo()
        {
            var especialidades = _especialidadeService.Get<EspecialidadeModel>().ToList();

            cboEspecialidade.ValueMember = "Id";
            cboEspecialidade.DisplayMember = "Nome";
            cboEspecialidade.DataSource = especialidades;
        }

        private void PreencheObjeto(Dentista dentista)
        {
            dentista.Nome = txtNome.Text;
            dentista.Telefone = txtTelefone.Text;
            dentista.CPF = txtCPF.Text;
           
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var dentista = _dentistaService.GetById<Dentista>(id);
                        PreencheObjeto(dentista);
                        dentista = _dentistaService.Update<Dentista, Dentista, DentistaValidator>(dentista);
                    }
                }
                else
                {
                    var dentista = new Dentista();
                    PreencheObjeto(dentista);
                    _dentistaService.Add<Dentista, Dentista, DentistaValidator>(dentista);
                }

                tabCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Consultório", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _dentistaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Consultório", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            dentistas = _dentistaService.Get<DentistaModel>(new[] { "Dentista" }).ToList();
            dataGridViewConsulta.DataSource = dentistas;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdCidade"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtCPF.Text = linha?.Cells["CPF"].Value.ToString();
          
        }

    }
}
