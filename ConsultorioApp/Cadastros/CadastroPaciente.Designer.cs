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
            chkTodos = new CheckBox();
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
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboConvenio);
            tabPageCadastro.Controls.Add(txtObservacao);
            tabPageCadastro.Controls.Add(txtCPF);
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(591, 584);
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
            panel1.Location = new Point(5, 451);
            panel1.Margin = new Padding(3, 5, 3, 5);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(panel3);
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Margin = new Padding(3, 5, 3, 5);
            tabPageConsulta.Padding = new Padding(3, 5, 3, 5);
            tabPageConsulta.Size = new Size(591, 584);
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
            txtCPF.Location = new Point(17, 169);
            txtCPF.Margin = new Padding(3, 4, 3, 4);
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
            txtCPF.Size = new Size(545, 48);
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
            txtTelefone.Location = new Point(17, 97);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
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
            txtTelefone.Size = new Size(545, 48);
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
            txtNome.Location = new Point(17, 25);
            txtNome.Margin = new Padding(3, 4, 3, 4);
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
            txtNome.Size = new Size(488, 48);
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
            txtObservacao.Location = new Point(23, 253);
            txtObservacao.Margin = new Padding(3, 4, 3, 4);
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
            txtObservacao.Size = new Size(539, 48);
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
            cboConvenio.Location = new Point(23, 325);
            cboConvenio.Margin = new Padding(3, 4, 3, 4);
            cboConvenio.MaxDropDownItems = 4;
            cboConvenio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboConvenio.Name = "cboConvenio";
            cboConvenio.Size = new Size(537, 49);
            cboConvenio.StartIndex = 0;
            cboConvenio.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(chkTodos);
            panel3.Controls.Add(btmPesquisar);
            panel3.Controls.Add(cboPesquisaConvenio);
            panel3.Location = new Point(10, 8);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(568, 228);
            panel3.TabIndex = 5;
            // 
            // chkTodos
            // 
            chkTodos.AutoSize = true;
            chkTodos.Location = new Point(18, 112);
            chkTodos.Name = "chkTodos";
            chkTodos.Size = new Size(203, 24);
            chkTodos.TabIndex = 18;
            chkTodos.Text = "Selecionar todos paciente";
            chkTodos.UseVisualStyleBackColor = true;
            // 
            // btmPesquisar
            // 
            btmPesquisar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btmPesquisar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btmPesquisar.Depth = 0;
            btmPesquisar.HighEmphasis = true;
            btmPesquisar.Icon = null;
            btmPesquisar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btmPesquisar.Location = new Point(221, 157);
            btmPesquisar.Margin = new Padding(5, 8, 5, 8);
            btmPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btmPesquisar.Name = "btmPesquisar";
            btmPesquisar.NoAccentTextColor = Color.Empty;
            btmPesquisar.Size = new Size(100, 36);
            btmPesquisar.TabIndex = 17;
            btmPesquisar.Text = "Pesquisar";
            btmPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btmPesquisar.UseAccentColor = false;
            btmPesquisar.UseVisualStyleBackColor = true;
            btmPesquisar.Click += btmPesquisar_Click;
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
            cboPesquisaConvenio.Location = new Point(18, 45);
            cboPesquisaConvenio.Margin = new Padding(3, 4, 3, 4);
            cboPesquisaConvenio.MaxDropDownItems = 4;
            cboPesquisaConvenio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPesquisaConvenio.Name = "cboPesquisaConvenio";
            cboPesquisaConvenio.Size = new Size(530, 49);
            cboPesquisaConvenio.StartIndex = 0;
            cboPesquisaConvenio.TabIndex = 13;
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
            txtId.Location = new Point(512, 25);
            txtId.Margin = new Padding(3, 4, 3, 4);
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
            txtId.Size = new Size(48, 48);
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 697);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CadastroPaciente";
            Padding = new Padding(3, 113, 3, 5);
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
        private ReaLTaiizor.Controls.MaterialComboBox cboPesquisaConvenio;
        private ReaLTaiizor.Controls.MaterialButton btmPesquisar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private CheckBox chkTodos;
    }
}