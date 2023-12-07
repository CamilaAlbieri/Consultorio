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
            this.cboNomePaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cmbNomeDentista = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtValorCnsulta = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtDataConsulta = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            this.txtPesquisaNomePaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtPesquisaNomeDentista = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtDataFim = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtDataInicio = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.tabCadastro.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageConsulta.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCadastro
            // 
            this.tabCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCadastro.Location = new System.Drawing.Point(3, 64);
            this.tabCadastro.Size = new System.Drawing.Size(544, 475);
            // 
            // tabPage1
            // 
            this.tabPageCadastro.Controls.Add(this.txtDescricao);
            this.tabPageCadastro.Controls.Add(this.txtDataConsulta);
            this.tabPageCadastro.Controls.Add(this.txtValorCnsulta);
            this.tabPageCadastro.Controls.Add(this.cmbNomeDentista);
            this.tabPageCadastro.Controls.Add(this.cboNomePaciente);
            this.tabPageCadastro.Size = new System.Drawing.Size(536, 440);
            this.tabPageCadastro.Controls.SetChildIndex(this.panel1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboNomePaciente, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cmbNomeDentista, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtValorCnsulta, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtDataConsulta, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtDescricao, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 357);
            this.panel1.Size = new System.Drawing.Size(510, 63);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(501, 155);
            // 
            // tabPage2
            // 
            this.tabPageConsulta.Controls.Add(this.panel3);
            this.tabPageConsulta.Controls.SetChildIndex(this.panel2, 0);
            this.tabPageConsulta.Controls.SetChildIndex(this.panel3, 0);
            // 
            // materialButton1
            // 
            this.btnCancelar.Location = new System.Drawing.Point(288, 4);
            // 
            // materialButton2
            // 
            this.btnSalvar.Location = new System.Drawing.Point(413, 4);
            // 
            // cboNomePaciente
            // 
            this.cboNomePaciente.AutoResize = false;
            this.cboNomePaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboNomePaciente.Depth = 0;
            this.cboNomePaciente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboNomePaciente.DropDownHeight = 174;
            this.cboNomePaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNomePaciente.DropDownWidth = 121;
            this.cboNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboNomePaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboNomePaciente.FormattingEnabled = true;
            this.cboNomePaciente.Hint = "Paciente";
            this.cboNomePaciente.IntegralHeight = false;
            this.cboNomePaciente.ItemHeight = 43;
            this.cboNomePaciente.Location = new System.Drawing.Point(15, 74);
            this.cboNomePaciente.MaxDropDownItems = 4;
            this.cboNomePaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboNomePaciente.Name = "cboNomePaciente";
            this.cboNomePaciente.Size = new System.Drawing.Size(477, 49);
            this.cboNomePaciente.StartIndex = 0;
            this.cboNomePaciente.TabIndex = 5;
            // 
            // cmbNomeDentista
            // 
            this.cmbNomeDentista.AutoResize = false;
            this.cmbNomeDentista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbNomeDentista.Depth = 0;
            this.cmbNomeDentista.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbNomeDentista.DropDownHeight = 174;
            this.cmbNomeDentista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeDentista.DropDownWidth = 121;
            this.cmbNomeDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbNomeDentista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbNomeDentista.FormattingEnabled = true;
            this.cmbNomeDentista.Hint = "Dentista";
            this.cmbNomeDentista.IntegralHeight = false;
            this.cmbNomeDentista.ItemHeight = 43;
            this.cmbNomeDentista.Location = new System.Drawing.Point(15, 19);
            this.cmbNomeDentista.MaxDropDownItems = 4;
            this.cmbNomeDentista.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cmbNomeDentista.Name = "cmbNomeDentista";
            this.cmbNomeDentista.Size = new System.Drawing.Size(477, 49);
            this.cmbNomeDentista.StartIndex = 0;
            this.cmbNomeDentista.TabIndex = 6;
            // 
            // txtValorCnsulta
            // 
            this.txtValorCnsulta.AnimateReadOnly = false;
            this.txtValorCnsulta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtValorCnsulta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtValorCnsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtValorCnsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtValorCnsulta.Depth = 0;
            this.txtValorCnsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorCnsulta.HideSelection = true;
            this.txtValorCnsulta.Hint = "Valor Consulta";
            this.txtValorCnsulta.LeadingIcon = null;
            this.txtValorCnsulta.Location = new System.Drawing.Point(15, 129);
            this.txtValorCnsulta.MaxLength = 32767;
            this.txtValorCnsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtValorCnsulta.Name = "txtValorCnsulta";
            this.txtValorCnsulta.PasswordChar = '\0';
            this.txtValorCnsulta.PrefixSuffixText = null;
            this.txtValorCnsulta.ReadOnly = false;
            this.txtValorCnsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValorCnsulta.SelectedText = "";
            this.txtValorCnsulta.SelectionLength = 0;
            this.txtValorCnsulta.SelectionStart = 0;
            this.txtValorCnsulta.ShortcutsEnabled = true;
            this.txtValorCnsulta.Size = new System.Drawing.Size(347, 48);
            this.txtValorCnsulta.TabIndex = 7;
            this.txtValorCnsulta.TabStop = false;
            this.txtValorCnsulta.Text = "R$";
            this.txtValorCnsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValorCnsulta.TrailingIcon = null;
            this.txtValorCnsulta.UseSystemPasswordChar = false;
            // 
            // txtDataConsulta
            // 
            this.txtDataConsulta.AllowPromptAsInput = true;
            this.txtDataConsulta.AnimateReadOnly = false;
            this.txtDataConsulta.AsciiOnly = false;
            this.txtDataConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDataConsulta.BeepOnError = false;
            this.txtDataConsulta.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataConsulta.Depth = 0;
            this.txtDataConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataConsulta.HidePromptOnLeave = false;
            this.txtDataConsulta.HideSelection = true;
            this.txtDataConsulta.Hint = "Data Consulta";
            this.txtDataConsulta.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDataConsulta.LeadingIcon = null;
            this.txtDataConsulta.Location = new System.Drawing.Point(372, 129);
            this.txtDataConsulta.Mask = "99/99/9999";
            this.txtDataConsulta.MaxLength = 32767;
            this.txtDataConsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDataConsulta.Name = "txtDataConsulta";
            this.txtDataConsulta.PasswordChar = '\0';
            this.txtDataConsulta.PrefixSuffixText = null;
            this.txtDataConsulta.PromptChar = '_';
            this.txtDataConsulta.ReadOnly = false;
            this.txtDataConsulta.RejectInputOnFirstFailure = false;
            this.txtDataConsulta.ResetOnPrompt = true;
            this.txtDataConsulta.ResetOnSpace = true;
            this.txtDataConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataConsulta.SelectedText = "";
            this.txtDataConsulta.SelectionLength = 0;
            this.txtDataConsulta.SelectionStart = 0;
            this.txtDataConsulta.ShortcutsEnabled = true;
            this.txtDataConsulta.Size = new System.Drawing.Size(120, 48);
            this.txtDataConsulta.SkipLiterals = true;
            this.txtDataConsulta.TabIndex = 8;
            this.txtDataConsulta.TabStop = false;
            this.txtDataConsulta.Text = "  /  /";
            this.txtDataConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataConsulta.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataConsulta.TrailingIcon = null;
            this.txtDataConsulta.UseSystemPasswordChar = false;
            this.txtDataConsulta.ValidatingType = null;
            // 
            // txtDescricao
            // 
            this.txtDescricao.AnimateReadOnly = false;
            this.txtDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescricao.Depth = 0;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescricao.HideSelection = true;
            this.txtDescricao.Hint = "Descrição";
            this.txtDescricao.LeadingIcon = null;
            this.txtDescricao.Location = new System.Drawing.Point(15, 183);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.PrefixSuffixText = null;
            this.txtDescricao.ReadOnly = false;
            this.txtDescricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(477, 48);
            this.txtDescricao.TabIndex = 9;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.TrailingIcon = null;
            this.txtDescricao.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btmPesquisar);
            this.panel3.Controls.Add(this.txtPesquisaNomePaciente);
            this.panel3.Controls.Add(this.txtPesquisaNomeDentista);
            this.panel3.Controls.Add(this.txtDataFim);
            this.panel3.Controls.Add(this.txtDataInicio);
            this.panel3.Location = new System.Drawing.Point(9, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 193);
            this.panel3.TabIndex = 5;
            // 
            // btmPesquisar
            // 
            this.btmPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btmPesquisar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btmPesquisar.Depth = 0;
            this.btmPesquisar.HighEmphasis = true;
            this.btmPesquisar.Icon = null;
            this.btmPesquisar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btmPesquisar.Location = new System.Drawing.Point(193, 138);
            this.btmPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btmPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btmPesquisar.Name = "btmPesquisar";
            this.btmPesquisar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btmPesquisar.Size = new System.Drawing.Size(100, 36);
            this.btmPesquisar.TabIndex = 13;
            this.btmPesquisar.Text = "Pesquisar";
            this.btmPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btmPesquisar.UseAccentColor = false;
            this.btmPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaNomePaciente
            // 
            this.txtPesquisaNomePaciente.AutoResize = false;
            this.txtPesquisaNomePaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPesquisaNomePaciente.Depth = 0;
            this.txtPesquisaNomePaciente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtPesquisaNomePaciente.DropDownHeight = 174;
            this.txtPesquisaNomePaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPesquisaNomePaciente.DropDownWidth = 121;
            this.txtPesquisaNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesquisaNomePaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPesquisaNomePaciente.FormattingEnabled = true;
            this.txtPesquisaNomePaciente.Hint = "Paciente";
            this.txtPesquisaNomePaciente.IntegralHeight = false;
            this.txtPesquisaNomePaciente.ItemHeight = 43;
            this.txtPesquisaNomePaciente.Location = new System.Drawing.Point(11, 80);
            this.txtPesquisaNomePaciente.MaxDropDownItems = 4;
            this.txtPesquisaNomePaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPesquisaNomePaciente.Name = "txtPesquisaNomePaciente";
            this.txtPesquisaNomePaciente.Size = new System.Drawing.Size(477, 49);
            this.txtPesquisaNomePaciente.StartIndex = 0;
            this.txtPesquisaNomePaciente.TabIndex = 12;
            // 
            // txtPesquisaNomeDentista
            // 
            this.txtPesquisaNomeDentista.AutoResize = false;
            this.txtPesquisaNomeDentista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPesquisaNomeDentista.Depth = 0;
            this.txtPesquisaNomeDentista.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtPesquisaNomeDentista.DropDownHeight = 174;
            this.txtPesquisaNomeDentista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPesquisaNomeDentista.DropDownWidth = 121;
            this.txtPesquisaNomeDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesquisaNomeDentista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPesquisaNomeDentista.FormattingEnabled = true;
            this.txtPesquisaNomeDentista.Hint = "Dentista";
            this.txtPesquisaNomeDentista.IntegralHeight = false;
            this.txtPesquisaNomeDentista.ItemHeight = 43;
            this.txtPesquisaNomeDentista.Location = new System.Drawing.Point(217, 15);
            this.txtPesquisaNomeDentista.MaxDropDownItems = 4;
            this.txtPesquisaNomeDentista.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPesquisaNomeDentista.Name = "txtPesquisaNomeDentista";
            this.txtPesquisaNomeDentista.Size = new System.Drawing.Size(272, 49);
            this.txtPesquisaNomeDentista.StartIndex = 0;
            this.txtPesquisaNomeDentista.TabIndex = 11;
            // 
            // txtDataFim
            // 
            this.txtDataFim.AllowPromptAsInput = true;
            this.txtDataFim.AnimateReadOnly = false;
            this.txtDataFim.AsciiOnly = false;
            this.txtDataFim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDataFim.BeepOnError = false;
            this.txtDataFim.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataFim.Depth = 0;
            this.txtDataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataFim.HidePromptOnLeave = false;
            this.txtDataFim.HideSelection = true;
            this.txtDataFim.Hint = "Data Fim";
            this.txtDataFim.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDataFim.LeadingIcon = null;
            this.txtDataFim.Location = new System.Drawing.Point(114, 16);
            this.txtDataFim.Mask = "99/99/9999";
            this.txtDataFim.MaxLength = 32767;
            this.txtDataFim.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.PasswordChar = '\0';
            this.txtDataFim.PrefixSuffixText = null;
            this.txtDataFim.PromptChar = '_';
            this.txtDataFim.ReadOnly = false;
            this.txtDataFim.RejectInputOnFirstFailure = false;
            this.txtDataFim.ResetOnPrompt = true;
            this.txtDataFim.ResetOnSpace = true;
            this.txtDataFim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataFim.SelectedText = "";
            this.txtDataFim.SelectionLength = 0;
            this.txtDataFim.SelectionStart = 0;
            this.txtDataFim.ShortcutsEnabled = true;
            this.txtDataFim.Size = new System.Drawing.Size(97, 48);
            this.txtDataFim.SkipLiterals = true;
            this.txtDataFim.TabIndex = 10;
            this.txtDataFim.TabStop = false;
            this.txtDataFim.Text = "  /  /";
            this.txtDataFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataFim.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataFim.TrailingIcon = null;
            this.txtDataFim.UseSystemPasswordChar = false;
            this.txtDataFim.ValidatingType = null;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.AllowPromptAsInput = true;
            this.txtDataInicio.AnimateReadOnly = false;
            this.txtDataInicio.AsciiOnly = false;
            this.txtDataInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDataInicio.BeepOnError = false;
            this.txtDataInicio.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataInicio.Depth = 0;
            this.txtDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataInicio.HidePromptOnLeave = false;
            this.txtDataInicio.HideSelection = true;
            this.txtDataInicio.Hint = "Data Início";
            this.txtDataInicio.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDataInicio.LeadingIcon = null;
            this.txtDataInicio.Location = new System.Drawing.Point(11, 15);
            this.txtDataInicio.Mask = "99/99/9999";
            this.txtDataInicio.MaxLength = 32767;
            this.txtDataInicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.PasswordChar = '\0';
            this.txtDataInicio.PrefixSuffixText = null;
            this.txtDataInicio.PromptChar = '_';
            this.txtDataInicio.ReadOnly = false;
            this.txtDataInicio.RejectInputOnFirstFailure = false;
            this.txtDataInicio.ResetOnPrompt = true;
            this.txtDataInicio.ResetOnSpace = true;
            this.txtDataInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataInicio.SelectedText = "";
            this.txtDataInicio.SelectionLength = 0;
            this.txtDataInicio.SelectionStart = 0;
            this.txtDataInicio.ShortcutsEnabled = true;
            this.txtDataInicio.Size = new System.Drawing.Size(97, 48);
            this.txtDataInicio.SkipLiterals = true;
            this.txtDataInicio.TabIndex = 9;
            this.txtDataInicio.TabStop = false;
            this.txtDataInicio.Text = "  /  /";
            this.txtDataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataInicio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataInicio.TrailingIcon = null;
            this.txtDataInicio.UseSystemPasswordChar = false;
            this.txtDataInicio.ValidatingType = null;
            // 
            // CadastroConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 542);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroConsulta";
            this.Text = "CadastroConsulta";
            this.tabCadastro.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageConsulta.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
    }
}