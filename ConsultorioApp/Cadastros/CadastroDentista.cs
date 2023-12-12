using Consultorio.App.Base;
using Consultorio.Domain.Base;
using Consultorio.Domain.Entities;
using Consultorio.Service.Validators;
using ConsultorioApp.Models;
using System.Reflection.PortableExecutable;

namespace Consultorio.App.Cadastros
{
    public partial class CadastroDentista : CadastroBase
    {
        private List<DentistaEspecialidade> _dentistaEspecialidade;
        private List<Especialidade> especialidadesSelecionadas;
        private readonly IBaseService<Dentista> _dentistaService;
        private readonly IBaseService<Especialidade> _especialidadeService;
        private readonly IBaseService<DentistaEspecialidade> _dentistaEspecialidadeService;

        private List<DentistaModel>? dentistas;
        public CadastroDentista(IBaseService<Dentista> dentistaService, IBaseService<Especialidade> especialidadeService,
                IBaseService<DentistaEspecialidade> dentistaEspecialidadeService)
        {
            _dentistaService = dentistaService;
            _especialidadeService = especialidadeService;
            _dentistaEspecialidadeService = dentistaEspecialidadeService;
            especialidadesSelecionadas = new List<Especialidade>();
            _dentistaEspecialidade = new List<DentistaEspecialidade>();
            InitializeComponent();
            CarregaLista();
        }

        private void CarregaCombo()
        {

            var especialidades = _especialidadeService.Get<EspecialidadeModel>().ToList();

            cmbEspecialidade.ValueMember = "Id";
            cmbEspecialidade.DisplayMember = "Nome";
            cmbEspecialidade.DataSource = especialidades;
        }

        private void CarregaLista()
        {
            lstEspecialidades.Items.Clear();

            var especialidades = _especialidadeService.Get<EspecialidadeModel>().ToList();

            foreach (var esp in especialidades)
            {
                lstEspecialidades.Items.Add(esp.Id + "-" + esp.Nome);
            }

            if (IsAlteracao)
            {
                foreach (ListViewItem item in lstEspecialidades.Items)
                {


                    if (int.TryParse(item.Text.Split("-")[0].ToString(), out var id))
                    {
                        var dentEsp = _dentistaEspecialidadeService.Get<DentistaEspecialidade>(new List<String>() { "Especialidade", "Dentista" })
                            .Where(x => x.Especialidade!.Id == id && x.Dentista!.Id == int.Parse(txtId.Text)).FirstOrDefault();

                        if (dentEsp != null)
                        {
                            item.Selected = true;
                            item.Focused = true;
                        }
                    }

                }
            }

        }


        private void PreencheObjeto(Dentista dentista)
        {
            especialidadesSelecionadas.Clear();
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


                        foreach (ListViewItem item in lstEspecialidades.Items)
                        {

                            if (int.TryParse(item.Text.Split("-")[0].ToString(), out var idEsp))
                            {
                                var dentEsp = _dentistaEspecialidadeService.Get<DentistaEspecialidade>(new List<String>() { "Especialidade", "Dentista" })
                                        .Where(x => x.Especialidade!.Id == idEsp && x.Dentista!.Id == id)
                                        .FirstOrDefault();

                                if (dentEsp != null)
                                {

                                    if (!item.Selected)
                                    {
                                        _dentistaEspecialidadeService.Delete(dentEsp!.Id);
                                    }

                                }

                                else
                                {

                                    if (item.Selected)
                                    {
                                        var especialidade = new Especialidade()
                                        {
                                            Id = idEsp,
                                            Nome = item.Text.Split("-")[1].ToString()
                                        };

                                        _dentistaEspecialidadeService.Add<DentistaEspecialidade, DentistaEspecialidade, DentistaEspecialidadeValidator>(new DentistaEspecialidade()
                                        {
                                            Dentista = dentista,
                                            Especialidade = especialidade
                                        });
                                    }
                                }
                            }
                        }

                    }

                    LimpaCampos();
                }
                else
                {
                    var dentista = new Dentista();
                    PreencheObjeto(dentista);
                    dentista = _dentistaService.Add<Dentista, Dentista, DentistaValidator>(dentista);

                    foreach (ListViewItem item in lstEspecialidades.SelectedItems)
                    {

                        if (int.TryParse(item.Text.Split("-")[0].ToString(), out var id))
                        {
                            var especialidade = _especialidadeService.Get<Especialidade>().Where(x => x.Id == id).FirstOrDefault();


                            if (especialidade != null)
                            {
                                var dentEsp = new DentistaEspecialidade()
                                {
                                    Dentista = dentista,
                                    Especialidade = especialidade,
                                };
                                _dentistaEspecialidade.Add(dentEsp);

                                _dentistaEspecialidadeService.Add<DentistaEspecialidade, DentistaEspecialidade, DentistaEspecialidadeValidator>(dentEsp);
                            }
                        }
                    }

                    LimpaCampos();
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
            CarregaCombo();
            dentistas = _dentistaService.Get<DentistaModel>().ToList();
            dataGridViewConsulta.DataSource = dentistas;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridViewConsulta.Columns["idEspecialidade"]!.Visible = false;
            //dataGridViewConsulta.Columns["Id"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtCPF.Text = linha?.Cells["CPF"].Value.ToString();
            CarregaLista();
        }

        private void txtTelefone_Click(object sender, EventArgs e)
        {

        }

        private void btmPesquisar_Click(object sender, EventArgs e)
        {
            //Filtro
            if (chkTodos.Checked)
            {
                CarregaGrid();
            }
            else
            {
                var item = (EspecialidadeModel)cmbEspecialidade.SelectedItem;

                if (item != null)
                {
                    List<DentistaModel> dentistasFiltrados = new List<DentistaModel>();

                    var dentistas = _dentistaEspecialidadeService.Get<DentistaEspecialidade>(new List<String>() { "Dentista", "Especialidade" })
                            .Where(x => x.Especialidade!.Id == item.Id).ToList();

                    foreach (var dent in dentistas)
                    {
                        dentistasFiltrados.Add(_dentistaService.Get<DentistaModel>()
                                .Where(x => x.Id == dent.Dentista!.Id).FirstOrDefault()!);
                    }

                    dataGridViewConsulta.DataSource = dentistasFiltrados;
                    dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }


            }
        }

    }
}
