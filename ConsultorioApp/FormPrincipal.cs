using Consultorio.App.Cadastros;
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

        private void  dentistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroDentista>();
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