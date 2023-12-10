namespace Consultorio.App.Cadastros
{
    partial class CadastroConsulta
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
            cboNomePaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            cmbNomeDentista = new ReaLTaiizor.Controls.MaterialComboBox();
            txtValorCnsulta = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataConsulta = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel3 = new Panel();
            btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            txtPesquisaNomePaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            txtPesquisaNomeDentista = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDataFim = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDataInicio = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            tabCadastro.Dock = DockStyle.Fill;
            tabCadastro.Location = new Point(3, 64);
            tabCadastro.Size = new Size(544, 475);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtDataConsulta);
            tabPageCadastro.Controls.Add(txtValorCnsulta);
            tabPageCadastro.Controls.Add(cmbNomeDentista);
            tabPageCadastro.Controls.Add(cboNomePaciente);
            tabPageCadastro.Size = new Size(536, 440);
            tabPageCadastro.Controls.SetChildIndex(panel1, 0);
            tabPageCadastro.Controls.SetChildIndex(cboNomePaciente, 0);
            tabPageCadastro.Controls.SetChildIndex(cmbNomeDentista, 0);
            tabPageCadastro.Controls.SetChildIndex(txtValorCnsulta, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataConsulta, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 357);
            panel1.Size = new Size(510, 63);
            // 
            // panel2
            // 
            panel2.Size = new Size(501, 155);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(panel3);
            tabPageConsulta.Controls.SetChildIndex(panel2, 0);
            tabPageConsulta.Controls.SetChildIndex(panel3, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(288, 4);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(413, 4);
            // 
            // cboNomePaciente
            // 
            cboNomePaciente.AutoResize = false;
            cboNomePaciente.BackColor = Color.FromArgb(255, 255, 255);
            cboNomePaciente.Depth = 0;
            cboNomePaciente.DrawMode = DrawMode.OwnerDrawVariable;
            cboNomePaciente.DropDownHeight = 174;
            cboNomePaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNomePaciente.DropDownWidth = 121;
            cboNomePaciente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboNomePaciente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNomePaciente.FormattingEnabled = true;
            cboNomePaciente.Hint = "Paciente";
            cboNomePaciente.IntegralHeight = false;
            cboNomePaciente.ItemHeight = 43;
            cboNomePaciente.Location = new Point(15, 74);
            cboNomePaciente.MaxDropDownItems = 4;
            cboNomePaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboNomePaciente.Name = "cboNomePaciente";
            cboNomePaciente.Size = new Size(477, 49);
            cboNomePaciente.StartIndex = 0;
            cboNomePaciente.TabIndex = 5;
            // 
            // cmbNomeDentista
            // 
            cmbNomeDentista.AutoResize = false;
            cmbNomeDentista.BackColor = Color.FromArgb(255, 255, 255);
            cmbNomeDentista.Depth = 0;
            cmbNomeDentista.DrawMode = DrawMode.OwnerDrawVariable;
            cmbNomeDentista.DropDownHeight = 174;
            cmbNomeDentista.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNomeDentista.DropDownWidth = 121;
            cmbNomeDentista.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbNomeDentista.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbNomeDentista.FormattingEnabled = true;
            cmbNomeDentista.Hint = "Dentista";
            cmbNomeDentista.IntegralHeight = false;
            cmbNomeDentista.ItemHeight = 43;
            cmbNomeDentista.Location = new Point(15, 19);
            cmbNomeDentista.MaxDropDownItems = 4;
            cmbNomeDentista.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbNomeDentista.Name = "cmbNomeDentista";
            cmbNomeDentista.Size = new Size(427, 49);
            cmbNomeDentista.StartIndex = 0;
            cmbNomeDentista.TabIndex = 6;
            // 
            // txtValorCnsulta
            // 
            txtValorCnsulta.AnimateReadOnly = false;
            txtValorCnsulta.AutoCompleteMode = AutoCompleteMode.None;
            txtValorCnsulta.AutoCompleteSource = AutoCompleteSource.None;
            txtValorCnsulta.BackgroundImageLayout = ImageLayout.None;
            txtValorCnsulta.CharacterCasing = CharacterCasing.Normal;
            txtValorCnsulta.Depth = 0;
            txtValorCnsulta.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValorCnsulta.HideSelection = true;
            txtValorCnsulta.Hint = "Valor Consulta";
            txtValorCnsulta.LeadingIcon = null;
            txtValorCnsulta.Location = new Point(15, 129);
            txtValorCnsulta.MaxLength = 32767;
            txtValorCnsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValorCnsulta.Name = "txtValorCnsulta";
            txtValorCnsulta.PasswordChar = '\0';
            txtValorCnsulta.PrefixSuffixText = null;
            txtValorCnsulta.ReadOnly = false;
            txtValorCnsulta.RightToLeft = RightToLeft.No;
            txtValorCnsulta.SelectedText = "";
            txtValorCnsulta.SelectionLength = 0;
            txtValorCnsulta.SelectionStart = 0;
            txtValorCnsulta.ShortcutsEnabled = true;
            txtValorCnsulta.Size = new Size(347, 48);
            txtValorCnsulta.TabIndex = 7;
            txtValorCnsulta.TabStop = false;
            txtValorCnsulta.Text = "R$";
            txtValorCnsulta.TextAlign = HorizontalAlignment.Left;
            txtValorCnsulta.TrailingIcon = null;
            txtValorCnsulta.UseSystemPasswordChar = false;
            // 
            // txtDataConsulta
            // 
            txtDataConsulta.AllowPromptAsInput = true;
            txtDataConsulta.AnimateReadOnly = false;
            txtDataConsulta.AsciiOnly = false;
            txtDataConsulta.BackgroundImageLayout = ImageLayout.None;
            txtDataConsulta.BeepOnError = false;
            txtDataConsulta.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataConsulta.Depth = 0;
            txtDataConsulta.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataConsulta.HidePromptOnLeave = false;
            txtDataConsulta.HideSelection = true;
            txtDataConsulta.Hint = "Data Consulta";
            txtDataConsulta.InsertKeyMode = InsertKeyMode.Default;
            txtDataConsulta.LeadingIcon = null;
            txtDataConsulta.Location = new Point(372, 129);
            txtDataConsulta.Mask = "99/99/9999";
            txtDataConsulta.MaxLength = 32767;
            txtDataConsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataConsulta.Name = "txtDataConsulta";
            txtDataConsulta.PasswordChar = '\0';
            txtDataConsulta.PrefixSuffixText = null;
            txtDataConsulta.PromptChar = '_';
            txtDataConsulta.ReadOnly = false;
            txtDataConsulta.RejectInputOnFirstFailure = false;
            txtDataConsulta.ResetOnPrompt = true;
            txtDataConsulta.ResetOnSpace = true;
            txtDataConsulta.RightToLeft = RightToLeft.No;
            txtDataConsulta.SelectedText = "";
            txtDataConsulta.SelectionLength = 0;
            txtDataConsulta.SelectionStart = 0;
            txtDataConsulta.ShortcutsEnabled = true;
            txtDataConsulta.Size = new Size(120, 48);
            txtDataConsulta.SkipLiterals = true;
            txtDataConsulta.TabIndex = 8;
            txtDataConsulta.TabStop = false;
            txtDataConsulta.Text = "  /  /";
            txtDataConsulta.TextAlign = HorizontalAlignment.Left;
            txtDataConsulta.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataConsulta.TrailingIcon = null;
            txtDataConsulta.UseSystemPasswordChar = false;
            txtDataConsulta.ValidatingType = null;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.AutoCompleteMode = AutoCompleteMode.None;
            txtDescricao.AutoCompleteSource = AutoCompleteSource.None;
            txtDescricao.BackgroundImageLayout = ImageLayout.None;
            txtDescricao.CharacterCasing = CharacterCasing.Normal;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.HideSelection = true;
            txtDescricao.Hint = "Descrição";
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(15, 183);
            txtDescricao.MaxLength = 32767;
            txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.PrefixSuffixText = null;
            txtDescricao.ReadOnly = false;
            txtDescricao.RightToLeft = RightToLeft.No;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.ShortcutsEnabled = true;
            txtDescricao.Size = new Size(477, 48);
            txtDescricao.TabIndex = 9;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btmPesquisar);
            panel3.Controls.Add(txtPesquisaNomePaciente);
            panel3.Controls.Add(txtPesquisaNomeDentista);
            panel3.Controls.Add(txtDataFim);
            panel3.Controls.Add(txtDataInicio);
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
            btmPesquisar.Location = new Point(193, 138);
            btmPesquisar.Margin = new Padding(4, 6, 4, 6);
            btmPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btmPesquisar.Name = "btmPesquisar";
            btmPesquisar.NoAccentTextColor = Color.Empty;
            btmPesquisar.Size = new Size(100, 36);
            btmPesquisar.TabIndex = 13;
            btmPesquisar.Text = "Pesquisar";
            btmPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btmPesquisar.UseAccentColor = false;
            btmPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaNomePaciente
            // 
            txtPesquisaNomePaciente.AutoResize = false;
            txtPesquisaNomePaciente.BackColor = Color.FromArgb(255, 255, 255);
            txtPesquisaNomePaciente.Depth = 0;
            txtPesquisaNomePaciente.DrawMode = DrawMode.OwnerDrawVariable;
            txtPesquisaNomePaciente.DropDownHeight = 174;
            txtPesquisaNomePaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPesquisaNomePaciente.DropDownWidth = 121;
            txtPesquisaNomePaciente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtPesquisaNomePaciente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtPesquisaNomePaciente.FormattingEnabled = true;
            txtPesquisaNomePaciente.Hint = "Paciente";
            txtPesquisaNomePaciente.IntegralHeight = false;
            txtPesquisaNomePaciente.ItemHeight = 43;
            txtPesquisaNomePaciente.Location = new Point(11, 80);
            txtPesquisaNomePaciente.MaxDropDownItems = 4;
            txtPesquisaNomePaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPesquisaNomePaciente.Name = "txtPesquisaNomePaciente";
            txtPesquisaNomePaciente.Size = new Size(477, 49);
            txtPesquisaNomePaciente.StartIndex = 0;
            txtPesquisaNomePaciente.TabIndex = 12;
            // 
            // txtPesquisaNomeDentista
            // 
            txtPesquisaNomeDentista.AutoResize = false;
            txtPesquisaNomeDentista.BackColor = Color.FromArgb(255, 255, 255);
            txtPesquisaNomeDentista.Depth = 0;
            txtPesquisaNomeDentista.DrawMode = DrawMode.OwnerDrawVariable;
            txtPesquisaNomeDentista.DropDownHeight = 174;
            txtPesquisaNomeDentista.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPesquisaNomeDentista.DropDownWidth = 121;
            txtPesquisaNomeDentista.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtPesquisaNomeDentista.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtPesquisaNomeDentista.FormattingEnabled = true;
            txtPesquisaNomeDentista.Hint = "Dentista";
            txtPesquisaNomeDentista.IntegralHeight = false;
            txtPesquisaNomeDentista.ItemHeight = 43;
            txtPesquisaNomeDentista.Location = new Point(217, 15);
            txtPesquisaNomeDentista.MaxDropDownItems = 4;
            txtPesquisaNomeDentista.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPesquisaNomeDentista.Name = "txtPesquisaNomeDentista";
            txtPesquisaNomeDentista.Size = new Size(272, 49);
            txtPesquisaNomeDentista.StartIndex = 0;
            txtPesquisaNomeDentista.TabIndex = 11;
            // 
            // txtDataFim
            // 
            txtDataFim.AllowPromptAsInput = true;
            txtDataFim.AnimateReadOnly = false;
            txtDataFim.AsciiOnly = false;
            txtDataFim.BackgroundImageLayout = ImageLayout.None;
            txtDataFim.BeepOnError = false;
            txtDataFim.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataFim.Depth = 0;
            txtDataFim.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataFim.HidePromptOnLeave = false;
            txtDataFim.HideSelection = true;
            txtDataFim.Hint = "Data Fim";
            txtDataFim.InsertKeyMode = InsertKeyMode.Default;
            txtDataFim.LeadingIcon = null;
            txtDataFim.Location = new Point(114, 16);
            txtDataFim.Mask = "99/99/9999";
            txtDataFim.MaxLength = 32767;
            txtDataFim.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataFim.Name = "txtDataFim";
            txtDataFim.PasswordChar = '\0';
            txtDataFim.PrefixSuffixText = null;
            txtDataFim.PromptChar = '_';
            txtDataFim.ReadOnly = false;
            txtDataFim.RejectInputOnFirstFailure = false;
            txtDataFim.ResetOnPrompt = true;
            txtDataFim.ResetOnSpace = true;
            txtDataFim.RightToLeft = RightToLeft.No;
            txtDataFim.SelectedText = "";
            txtDataFim.SelectionLength = 0;
            txtDataFim.SelectionStart = 0;
            txtDataFim.ShortcutsEnabled = true;
            txtDataFim.Size = new Size(97, 48);
            txtDataFim.SkipLiterals = true;
            txtDataFim.TabIndex = 10;
            txtDataFim.TabStop = false;
            txtDataFim.Text = "  /  /";
            txtDataFim.TextAlign = HorizontalAlignment.Left;
            txtDataFim.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataFim.TrailingIcon = null;
            txtDataFim.UseSystemPasswordChar = false;
            txtDataFim.ValidatingType = null;
            // 
            // txtDataInicio
            // 
            txtDataInicio.AllowPromptAsInput = true;
            txtDataInicio.AnimateReadOnly = false;
            txtDataInicio.AsciiOnly = false;
            txtDataInicio.BackgroundImageLayout = ImageLayout.None;
            txtDataInicio.BeepOnError = false;
            txtDataInicio.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataInicio.Depth = 0;
            txtDataInicio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataInicio.HidePromptOnLeave = false;
            txtDataInicio.HideSelection = true;
            txtDataInicio.Hint = "Data Início";
            txtDataInicio.InsertKeyMode = InsertKeyMode.Default;
            txtDataInicio.LeadingIcon = null;
            txtDataInicio.Location = new Point(11, 15);
            txtDataInicio.Mask = "99/99/9999";
            txtDataInicio.MaxLength = 32767;
            txtDataInicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataInicio.Name = "txtDataInicio";
            txtDataInicio.PasswordChar = '\0';
            txtDataInicio.PrefixSuffixText = null;
            txtDataInicio.PromptChar = '_';
            txtDataInicio.ReadOnly = false;
            txtDataInicio.RejectInputOnFirstFailure = false;
            txtDataInicio.ResetOnPrompt = true;
            txtDataInicio.ResetOnSpace = true;
            txtDataInicio.RightToLeft = RightToLeft.No;
            txtDataInicio.SelectedText = "";
            txtDataInicio.SelectionLength = 0;
            txtDataInicio.SelectionStart = 0;
            txtDataInicio.ShortcutsEnabled = true;
            txtDataInicio.Size = new Size(97, 48);
            txtDataInicio.SkipLiterals = true;
            txtDataInicio.TabIndex = 9;
            txtDataInicio.TabStop = false;
            txtDataInicio.Text = "  /  /";
            txtDataInicio.TextAlign = HorizontalAlignment.Left;
            txtDataInicio.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataInicio.TrailingIcon = null;
            txtDataInicio.UseSystemPasswordChar = false;
            txtDataInicio.ValidatingType = null;
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
            txtId.TabIndex = 10;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 542);
            Location = new Point(0, 0);
            Name = "CadastroConsulta";
            Text = "CadastroConsulta";
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

        private ReaLTaiizor.Controls.MaterialComboBox cmbNomeDentista;
        private ReaLTaiizor.Controls.MaterialComboBox cboNomePaciente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorCnsulta;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataConsulta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataInicio;
        private ReaLTaiizor.Controls.MaterialComboBox txtPesquisaNomePaciente;
        private ReaLTaiizor.Controls.MaterialComboBox txtPesquisaNomeDentista;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataFim;
        private ReaLTaiizor.Controls.MaterialButton btmPesquisar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}