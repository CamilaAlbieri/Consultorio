using Consultorio.App.Base;
using Consultorio.App.Cadastros;
using Consultorio.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace ConsultorioApp
{
    public partial class FormPrincipal : MaterialForm

    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void dentistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroDentista>();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroPaciente>();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroConsulta>();
        }

        private void convênioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroConvenio>();
        }

        private void especialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroEspecialidade>();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }


    }
}