

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
                } else
                {

                    Utils.Utils.messageExclamation("Não pode inserir uma especialidade com o mesmo nome!", "Especialidade");
                }
            
                


            }

        }

        protected override void CarregaGrid()
        {
            


        }


    }
}
