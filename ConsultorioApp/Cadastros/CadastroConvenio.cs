

using Consultorio.App.Base;
using Consultorio.Domain.Base;
using Consultorio.Domain.Entities;
using Consultorio.Service.Validators;
using ConsultorioApp.Models;
using ReaLTaiizor.Controls;

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
            //CarregaCombo();
        }

        private void CarregaCombo()
        {
            var convenios = _convenioService.Get<ConvenioModel>().ToList();

            cboPesquisaConvenio.ValueMember = "Id";
            cboPesquisaConvenio.DisplayMember = "Nome";
            cboPesquisaConvenio.DataSource = convenios;
        }
        private void PreencheObjeto(Convenio convenio)
        {
            convenio.Nome = txtConvenio.Text;

        }

        protected override void Salvar()
        {
            //Salvar a convenio
            if (!String.IsNullOrEmpty(txtConvenio.Text))
            {
                try
                {
                    var convExiste = _convenioService.Get<Convenio>().Where(x => x.Nome == txtConvenio.Text).FirstOrDefault();

                    if (convExiste == null)
                    {
                        if (IsAlteracao)
                        {
                            if (int.TryParse(txtId.Text, out var id))
                            {
                                var convenio = _convenioService.GetById<Convenio>(id);
                                PreencheObjeto(convenio);
                                _convenioService.Update<Convenio, Convenio, ConvenioValidator>(convenio);
                            }
                        }
                        else
                        {
                            var convenio = new Convenio();
                            PreencheObjeto(convenio);
                            _convenioService.Add<Convenio, Convenio, ConvenioValidator>(convenio);
                        }

                        tabCadastro.SelectedIndex = 1;

                    }
                    else
                    {
                        Utils.Utils.messageExclamation("Não pode inserir um convênio com o mesmo nome!", "Convênio");
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Consultório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        protected override void Deletar(int id)
        {
            try
            {
                _convenioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Consultório", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            CarregaCombo();
            convenios = _convenioService.Get<Convenio>().ToList();
            dataGridViewConsulta.DataSource = convenios;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtConvenio.Text = linha?.Cells["Nome"].Value.ToString();

        }
    }
}
