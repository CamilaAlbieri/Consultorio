namespace Consultorio.App.Base
{
    partial class CadastroPaciente
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
            txtCPF = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtTelefone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtObservacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboConvenio = new ReaLTaiizor.Controls.MaterialComboBox();
            panel3 = new Panel();
            btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            cboPesquisaConsulta = new ReaLTaiizor.Controls.MaterialComboBox();
            cboPesquisaNomePaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboConvenio);
            tabPageCadastro.Controls.Add(txtObservacao);
            tabPageCadastro.Controls.Add(txtCPF);
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.SetChildIndex(panel1, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCPF, 0);
            tabPageCadastro.Controls.SetChildIndex(txtObservacao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboConvenio, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // panel1
            // 
            panel1.Location = new Point(4, 338);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(panel3);
            tabPageConsulta.Controls.SetChildIndex(panel2, 0);
            tabPageConsulta.Controls.SetChildIndex(panel3, 0);
            // 
            // txtCPF
            // 
            txtCPF.AllowPromptAsInput = true;
            txtCPF.AnimateReadOnly = false;
            txtCPF.AsciiOnly = false;
            txtCPF.BackgroundImageLayout = ImageLayout.None;
            txtCPF.BeepOnError = false;
            txtCPF.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCPF.Depth = 0;
            txtCPF.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCPF.HidePromptOnLeave = false;
            txtCPF.HideSelection = true;
            txtCPF.Hint = "CPF";
            txtCPF.InsertKeyMode = InsertKeyMode.Default;
            txtCPF.LeadingIcon = null;
            txtCPF.Location = new Point(15, 127);
            txtCPF.Mask = "999,999,999-99";
            txtCPF.MaxLength = 32767;
            txtCPF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCPF.Name = "txtCPF";
            txtCPF.PasswordChar = '\0';
            txtCPF.PrefixSuffixText = null;
            txtCPF.PromptChar = '_';
            txtCPF.ReadOnly = false;
            txtCPF.RejectInputOnFirstFailure = false;
            txtCPF.ResetOnPrompt = true;
            txtCPF.ResetOnSpace = true;
            txtCPF.RightToLeft = RightToLeft.No;
            txtCPF.SelectedText = "";
            txtCPF.SelectionLength = 0;
            txtCPF.SelectionStart = 0;
            txtCPF.ShortcutsEnabled = true;
            txtCPF.Size = new Size(477, 48);
            txtCPF.SkipLiterals = true;
            txtCPF.TabIndex = 6;
            txtCPF.TabStop = false;
            txtCPF.Text = "   .   .   -";
            txtCPF.TextAlign = HorizontalAlignment.Left;
            txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCPF.TrailingIcon = null;
            txtCPF.UseSystemPasswordChar = false;
            txtCPF.ValidatingType = null;
            // 
            // txtTelefone
            // 
            txtTelefone.AllowPromptAsInput = true;
            txtTelefone.AnimateReadOnly = false;
            txtTelefone.AsciiOnly = false;
            txtTelefone.BackgroundImageLayout = ImageLayout.None;
            txtTelefone.BeepOnError = false;
            txtTelefone.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.Depth = 0;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefone.HidePromptOnLeave = false;
            txtTelefone.HideSelection = true;
            txtTelefone.Hint = "Telefone";
            txtTelefone.InsertKeyMode = InsertKeyMode.Default;
            txtTelefone.LeadingIcon = null;
            txtTelefone.Location = new Point(15, 73);
            txtTelefone.Mask = "(99)99999-9999";
            txtTelefone.MaxLength = 32767;
            txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.PrefixSuffixText = null;
            txtTelefone.PromptChar = '_';
            txtTelefone.ReadOnly = false;
            txtTelefone.RejectInputOnFirstFailure = false;
            txtTelefone.ResetOnPrompt = true;
            txtTelefone.ResetOnSpace = true;
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.ShortcutsEnabled = true;
            txtTelefone.Size = new Size(477, 48);
            txtTelefone.SkipLiterals = true;
            txtTelefone.TabIndex = 5;
            txtTelefone.TabStop = false;
            txtTelefone.Text = "(  )     -";
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            txtTelefone.ValidatingType = null;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(15, 19);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(427, 48);
            txtNome.TabIndex = 4;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtObservacao
            // 
            txtObservacao.AnimateReadOnly = false;
            txtObservacao.AutoCompleteMode = AutoCompleteMode.None;
            txtObservacao.AutoCompleteSource = AutoCompleteSource.None;
            txtObservacao.BackgroundImageLayout = ImageLayout.None;
            txtObservacao.CharacterCasing = CharacterCasing.Normal;
            txtObservacao.Depth = 0;
            txtObservacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtObservacao.HideSelection = true;
            txtObservacao.Hint = "Observação";
            txtObservacao.LeadingIcon = null;
            txtObservacao.Location = new Point(20, 190);
            txtObservacao.MaxLength = 32767;
            txtObservacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PasswordChar = '\0';
            txtObservacao.PrefixSuffixText = null;
            txtObservacao.ReadOnly = false;
            txtObservacao.RightToLeft = RightToLeft.No;
            txtObservacao.SelectedText = "";
            txtObservacao.SelectionLength = 0;
            txtObservacao.SelectionStart = 0;
            txtObservacao.ShortcutsEnabled = true;
            txtObservacao.Size = new Size(472, 48);
            txtObservacao.TabIndex = 7;
            txtObservacao.TabStop = false;
            txtObservacao.TextAlign = HorizontalAlignment.Left;
            txtObservacao.TrailingIcon = null;
            txtObservacao.UseSystemPasswordChar = false;
            // 
            // cboConvenio
            // 
            cboConvenio.AutoResize = false;
            cboConvenio.BackColor = Color.FromArgb(255, 255, 255);
            cboConvenio.Depth = 0;
            cboConvenio.DrawMode = DrawMode.OwnerDrawVariable;
            cboConvenio.DropDownHeight = 174;
            cboConvenio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConvenio.DropDownWidth = 121;
            cboConvenio.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboConvenio.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboConvenio.FormattingEnabled = true;
            cboConvenio.Hint = "Convênio";
            cboConvenio.IntegralHeight = false;
            cboConvenio.ItemHeight = 43;
            cboConvenio.Location = new Point(20, 244);
            cboConvenio.MaxDropDownItems = 4;
            cboConvenio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboConvenio.Name = "cboConvenio";
            cboConvenio.Size = new Size(470, 49);
            cboConvenio.StartIndex = 0;
            cboConvenio.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(btmPesquisar);
            panel3.Controls.Add(cboPesquisaConsulta);
            panel3.Controls.Add(cboPesquisaNomePaciente);
            panel3.Location = new Point(9, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(497, 193);
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
            btmPesquisar.Location = new Point(195, 140);
            btmPesquisar.Margin = new Padding(4, 6, 4, 6);
            btmPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btmPesquisar.Name = "btmPesquisar";
            btmPesquisar.NoAccentTextColor = Color.Empty;
            btmPesquisar.Size = new Size(100, 36);
            btmPesquisar.TabIndex = 17;
            btmPesquisar.Text = "Pesquisar";
            btmPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btmPesquisar.UseAccentColor = false;
            btmPesquisar.UseVisualStyleBackColor = true;
            // 
            // cboPesquisaConsulta
            // 
            cboPesquisaConsulta.AutoResize = false;
            cboPesquisaConsulta.BackColor = Color.FromArgb(255, 255, 255);
            cboPesquisaConsulta.Depth = 0;
            cboPesquisaConsulta.DrawMode = DrawMode.OwnerDrawVariable;
            cboPesquisaConsulta.DropDownHeight = 174;
            cboPesquisaConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPesquisaConsulta.DropDownWidth = 121;
            cboPesquisaConsulta.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPesquisaConsulta.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPesquisaConsulta.FormattingEnabled = true;
            cboPesquisaConsulta.Hint = "Consulta";
            cboPesquisaConsulta.IntegralHeight = false;
            cboPesquisaConsulta.ItemHeight = 43;
            cboPesquisaConsulta.Location = new Point(16, 72);
            cboPesquisaConsulta.MaxDropDownItems = 4;
            cboPesquisaConsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPesquisaConsulta.Name = "cboPesquisaConsulta";
            cboPesquisaConsulta.Size = new Size(464, 49);
            cboPesquisaConsulta.StartIndex = 0;
            cboPesquisaConsulta.TabIndex = 14;
            // 
            // cboPesquisaNomePaciente
            // 
            cboPesquisaNomePaciente.AutoResize = false;
            cboPesquisaNomePaciente.BackColor = Color.FromArgb(255, 255, 255);
            cboPesquisaNomePaciente.Depth = 0;
            cboPesquisaNomePaciente.DrawMode = DrawMode.OwnerDrawVariable;
            cboPesquisaNomePaciente.DropDownHeight = 174;
            cboPesquisaNomePaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPesquisaNomePaciente.DropDownWidth = 121;
            cboPesquisaNomePaciente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPesquisaNomePaciente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPesquisaNomePaciente.FormattingEnabled = true;
            cboPesquisaNomePaciente.Hint = "Paciente";
            cboPesquisaNomePaciente.IntegralHeight = false;
            cboPesquisaNomePaciente.ItemHeight = 43;
            cboPesquisaNomePaciente.Location = new Point(17, 13);
            cboPesquisaNomePaciente.MaxDropDownItems = 4;
            cboPesquisaNomePaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPesquisaNomePaciente.Name = "cboPesquisaNomePaciente";
            cboPesquisaNomePaciente.Size = new Size(464, 49);
            cboPesquisaNomePaciente.StartIndex = 0;
            cboPesquisaNomePaciente.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(448, 19);
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
            txtId.Size = new Size(42, 48);
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 523);
            Location = new Point(0, 0);
            Name = "CadastroPaciente";
            Text = "CadastroPaciente";
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

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCPF;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtObservacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboConvenio;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialComboBox cboPesquisaConsulta;
        private ReaLTaiizor.Controls.MaterialComboBox cboPesquisaNomePaciente;
        private ReaLTaiizor.Controls.MaterialButton btmPesquisar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}