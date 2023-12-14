

using Consultorio.App.Base;
using Consultorio.App.Utils;
using Consultorio.Domain.Base;
using Consultorio.Domain.Entities;
using Consultorio.Service.Validators;
using ConsultorioApp.Models;

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
            CarregaCombo();
        }

        private void CarregaCombo()
        {
            var especialidades = _especialidadeService.Get<EspecialidadeModel>().ToList();

            cboEspecialidade.ValueMember = "Id";
            cboEspecialidade.DisplayMember = "Nome";
            cboEspecialidade.DataSource = especialidades;
        }

        protected override void Salvar()
        {
            if (IsAlteracao)
            {
                var espExiste = _especialidadeService.Get<Especialidade>().Where(x => x.Nome == txtEspecialidade1.Text).FirstOrDefault();

                if (espExiste == null)
                {
                    Especialidade esp = new Especialidade()
                    {
                        Id = int.Parse(txtId.Text),
                        Nome = txtEspecialidade1.Text
                    };

                    _especialidadeService.Update<Especialidade, Especialidade, EspecialidadeValidator>(esp);

                    Utils.Utils.messageBoxOk("Especialidade atualizada com sucesso!", "Especialidade");
                    LimpaCampos();

                    tabCadastro.SelectedIndex = 1;
                }
                else
                {
                    Utils.Utils.messageExclamation("Não pode inserir uma especialidade com o mesmo nome!", "Especialidade");
                }
            }
            else
            {
                //Salvar a especialidade
                if (!String.IsNullOrEmpty(txtEspecialidade1.Text))
                {

                    var espExiste = _especialidadeService.Get<Especialidade>().Where(x => x.Nome == txtEspecialidade1.Text).FirstOrDefault();

                    if (espExiste == null)
                    {
                        _especialidadeService.Add<Especialidade, Especialidade, EspecialidadeValidator>(new Especialidade()
                        {
                            Nome = txtEspecialidade1.Text
                        });

                        Utils.Utils.messageBoxOk("Especialidade inserida com sucesso!", "Especialidade");
                        LimpaCampos();

                        tabCadastro.SelectedIndex = 1;
                    }
                    else
                    {

                        Utils.Utils.messageExclamation("Não pode inserir uma especialidade com o mesmo nome!", "Especialidade");
                    }

                }





            }

        }

        protected override void Deletar(int id)
        {
            try
            {
                _especialidadeService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Consultório", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            CarregaCombo();
            IsAlteracao = false;
            especialidades = _especialidadeService.Get<Especialidade>().ToList();

            dataGridViewConsulta.DataSource = especialidades;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtEspecialidade1.Text = linha?.Cells["Nome"].Value.ToString();

        }

    }
}
