using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;



namespace Consultorio.App.Base
{
    public partial class CadastroBase : MaterialForm
    {

        protected bool IsAlteracao = false;


        public CadastroBase()
        {
            InitializeComponent();
        }


        #region Eventos


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"Consultório", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                LimpaCampos();
                tabCadastro.SelectedIndex = 1;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente deletar?", @"Consultorio", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    int id = (int)dataGridViewConsulta.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Consultorio", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridViewConsulta_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Editar();
        }

        #endregion


        #region CRUD METHODS

        protected void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }

                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        protected virtual void Salvar()
        {

        }



        protected virtual void Novo()
        {
            LimpaCampos();
            tabCadastro.SelectedIndex = 0;
            tabCadastro.Focus();
        }

        protected virtual void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                tabCadastro.SelectedIndex = 0;
                tabCadastro.Focus();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Consultorio", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        protected virtual void Deletar(int id)
        {

        }

        protected virtual void CarregaGrid()
        {

        }

        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }



        #endregion




    }

}

