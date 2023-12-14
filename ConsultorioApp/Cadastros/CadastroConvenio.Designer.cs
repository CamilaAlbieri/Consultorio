namespace Consultorio.App.Cadastros
{
    partial class CadastroConvenio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtConvenio = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel3 = new Panel();
            btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            cboPesquisaConvenio = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabCadastro
            // 
            tabCadastro.Location = new Point(6, 65);
            tabCadastro.Margin = new Padding(3, 4, 3, 4);
            tabCadastro.Size = new Size(524, 462);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtConvenio);
            tabPageCadastro.Margin = new Padding(3, 4, 3, 4);
            tabPageCadastro.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastro.Size = new Size(516, 427);
            tabPageCadastro.Controls.SetChildIndex(txtConvenio, 0);
            tabPageCadastro.Controls.SetChildIndex(panel1, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // panel1
            // 
            panel1.Location = new Point(7, 165);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(503, 47);
            // 
            // panel2
            // 
            panel2.Location = new Point(6, 367);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Size = new Size(501, 54);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(panel3);
            tabPageConsulta.Margin = new Padding(3, 4, 3, 4);
            tabPageConsulta.Padding = new Padding(3, 4, 3, 4);
            tabPageConsulta.Size = new Size(516, 427);
            tabPageConsulta.Controls.SetChildIndex(panel2, 0);
            tabPageConsulta.Controls.SetChildIndex(panel3, 0);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(197, 10);
            btnNovo.Margin = new Padding(4);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(293, 10);
            btnEditar.Margin = new Padding(4);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(391, 10);
            btnExcluir.Margin = new Padding(4);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(273, 4);
            btnCancelar.Margin = new Padding(5, 8, 5, 8);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(391, 4);
            btnSalvar.Margin = new Padding(4);
            // 
            // txtConvenio
            // 
            txtConvenio.AnimateReadOnly = false;
            txtConvenio.AutoCompleteMode = AutoCompleteMode.None;
            txtConvenio.AutoCompleteSource = AutoCompleteSource.None;
            txtConvenio.BackgroundImageLayout = ImageLayout.None;
            txtConvenio.CharacterCasing = CharacterCasing.Normal;
            txtConvenio.Depth = 0;
            txtConvenio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtConvenio.HideSelection = true;
            txtConvenio.Hint = "Convênio";
            txtConvenio.LeadingIcon = null;
            txtConvenio.Location = new Point(7, 56);
            txtConvenio.MaxLength = 32767;
            txtConvenio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtConvenio.Name = "txtConvenio";
            txtConvenio.PasswordChar = '\0';
            txtConvenio.PrefixSuffixText = null;
            txtConvenio.ReadOnly = false;
            txtConvenio.RightToLeft = RightToLeft.No;
            txtConvenio.SelectedText = "";
            txtConvenio.SelectionLength = 0;
            txtConvenio.SelectionStart = 0;
            txtConvenio.ShortcutsEnabled = true;
            txtConvenio.Size = new Size(440, 48);
            txtConvenio.TabIndex = 1;
            txtConvenio.TabStop = false;
            txtConvenio.TextAlign = HorizontalAlignment.Left;
            txtConvenio.TrailingIcon = null;
            txtConvenio.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btmPesquisar);
            panel3.Controls.Add(cboPesquisaConvenio);
            panel3.Location = new Point(0, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(516, 164);
            panel3.TabIndex = 5;
            // 
            // btmPesquisar
            // 
            btmPesquisar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btmPesquisar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btmPesquisar.Depth = 0;
            btmPesquisar.HighEmphasis = true;
            btmPesquisar.Icon = null;
            btmPesquisar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btmPesquisar.Location = new Point(194, 122);
            btmPesquisar.Margin = new Padding(4, 6, 4, 6);
            btmPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btmPesquisar.Name = "btmPesquisar";
            btmPesquisar.NoAccentTextColor = Color.Empty;
            btmPesquisar.Size = new Size(100, 36);
            btmPesquisar.TabIndex = 14;
            btmPesquisar.Text = "Pesquisar";
            btmPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btmPesquisar.UseAccentColor = false;
            btmPesquisar.UseVisualStyleBackColor = true;
            // 
            // cboPesquisaConvenio
            // 
            cboPesquisaConvenio.AutoResize = false;
            cboPesquisaConvenio.BackColor = Color.FromArgb(255, 255, 255);
            cboPesquisaConvenio.Depth = 0;
            cboPesquisaConvenio.DrawMode = DrawMode.OwnerDrawVariable;
            cboPesquisaConvenio.DropDownHeight = 174;
            cboPesquisaConvenio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPesquisaConvenio.DropDownWidth = 121;
            cboPesquisaConvenio.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPesquisaConvenio.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPesquisaConvenio.FormattingEnabled = true;
            cboPesquisaConvenio.Hint = "Convênio";
            cboPesquisaConvenio.IntegralHeight = false;
            cboPesquisaConvenio.ItemHeight = 43;
            cboPesquisaConvenio.Location = new Point(7, 47);
            cboPesquisaConvenio.MaxDropDownItems = 4;
            cboPesquisaConvenio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPesquisaConvenio.Name = "cboPesquisaConvenio";
            cboPesquisaConvenio.Size = new Size(500, 49);
            cboPesquisaConvenio.StartIndex = 0;
            cboPesquisaConvenio.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Enabled = false;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(452, 56);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(58, 48);
            txtId.TabIndex = 11;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroConvenio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 535);
            Location = new Point(0, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroConvenio";
            Padding = new Padding(3, 85, 3, 4);
            Text = "CadastroConvenio";
            tabCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtConvenio;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialComboBox cboPesquisaConvenio;
        private ReaLTaiizor.Controls.MaterialButton btmPesquisar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}