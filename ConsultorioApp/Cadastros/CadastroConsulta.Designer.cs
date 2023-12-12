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
            cboNomeDentista = new ReaLTaiizor.Controls.MaterialComboBox();
            txtValorConsulta = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataConsulta = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel3 = new Panel();
            chkTodos = new CheckBox();
            btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            cboPesquisaNomePaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            cboPesquisaNomeDentista = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDataFim = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDataInicio = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label1 = new Label();
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
            tabCadastro.Size = new Size(544, 471);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(label1);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtDataConsulta);
            tabPageCadastro.Controls.Add(txtValorConsulta);
            tabPageCadastro.Controls.Add(cboNomeDentista);
            tabPageCadastro.Controls.Add(cboNomePaciente);
            tabPageCadastro.Size = new Size(536, 436);
            tabPageCadastro.Controls.SetChildIndex(panel1, 0);
            tabPageCadastro.Controls.SetChildIndex(cboNomePaciente, 0);
            tabPageCadastro.Controls.SetChildIndex(cboNomeDentista, 0);
            tabPageCadastro.Controls.SetChildIndex(txtValorConsulta, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataConsulta, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(label1, 0);
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 357);
            panel1.Size = new Size(510, 63);
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 368);
            panel2.Size = new Size(527, 65);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(panel3);
            tabPageConsulta.Size = new Size(536, 436);
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
            // cboNomeDentista
            // 
            cboNomeDentista.AutoResize = false;
            cboNomeDentista.BackColor = Color.FromArgb(255, 255, 255);
            cboNomeDentista.Depth = 0;
            cboNomeDentista.DrawMode = DrawMode.OwnerDrawVariable;
            cboNomeDentista.DropDownHeight = 174;
            cboNomeDentista.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNomeDentista.DropDownWidth = 121;
            cboNomeDentista.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboNomeDentista.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNomeDentista.FormattingEnabled = true;
            cboNomeDentista.Hint = "Dentista";
            cboNomeDentista.IntegralHeight = false;
            cboNomeDentista.ItemHeight = 43;
            cboNomeDentista.Location = new Point(15, 19);
            cboNomeDentista.MaxDropDownItems = 4;
            cboNomeDentista.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboNomeDentista.Name = "cboNomeDentista";
            cboNomeDentista.Size = new Size(422, 49);
            cboNomeDentista.StartIndex = 0;
            cboNomeDentista.TabIndex = 6;
            // 
            // txtValorConsulta
            // 
            txtValorConsulta.AnimateReadOnly = false;
            txtValorConsulta.AutoCompleteMode = AutoCompleteMode.None;
            txtValorConsulta.AutoCompleteSource = AutoCompleteSource.None;
            txtValorConsulta.BackgroundImageLayout = ImageLayout.None;
            txtValorConsulta.CharacterCasing = CharacterCasing.Normal;
            txtValorConsulta.Depth = 0;
            txtValorConsulta.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValorConsulta.HideSelection = true;
            txtValorConsulta.Hint = "Valor Consulta";
            txtValorConsulta.LeadingIcon = null;
            txtValorConsulta.Location = new Point(56, 129);
            txtValorConsulta.MaxLength = 32767;
            txtValorConsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValorConsulta.Name = "txtValorConsulta";
            txtValorConsulta.PasswordChar = '\0';
            txtValorConsulta.PrefixSuffixText = null;
            txtValorConsulta.ReadOnly = false;
            txtValorConsulta.RightToLeft = RightToLeft.No;
            txtValorConsulta.SelectedText = "";
            txtValorConsulta.SelectionLength = 0;
            txtValorConsulta.SelectionStart = 0;
            txtValorConsulta.ShortcutsEnabled = true;
            txtValorConsulta.Size = new Size(289, 48);
            txtValorConsulta.TabIndex = 7;
            txtValorConsulta.TabStop = false;
            txtValorConsulta.Tag = "";
            txtValorConsulta.TextAlign = HorizontalAlignment.Left;
            txtValorConsulta.TrailingIcon = null;
            txtValorConsulta.UseSystemPasswordChar = false;
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
            txtDataConsulta.Location = new Point(351, 129);
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
            txtDataConsulta.Size = new Size(141, 48);
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
            panel3.Controls.Add(chkTodos);
            panel3.Controls.Add(btmPesquisar);
            panel3.Controls.Add(cboPesquisaNomePaciente);
            panel3.Controls.Add(cboPesquisaNomeDentista);
            panel3.Controls.Add(txtDataFim);
            panel3.Controls.Add(txtDataInicio);
            panel3.Location = new Point(9, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(507, 179);
            panel3.TabIndex = 5;
            // 
            // chkTodos
            // 
            chkTodos.AutoSize = true;
            chkTodos.Location = new Point(11, 148);
            chkTodos.Name = "chkTodos";
            chkTodos.Size = new Size(179, 19);
            chkTodos.TabIndex = 14;
            chkTodos.Text = "Selecionar todas as consultas";
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
            btmPesquisar.Location = new Point(192, 138);
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
            cboPesquisaNomePaciente.Location = new Point(11, 80);
            cboPesquisaNomePaciente.MaxDropDownItems = 4;
            cboPesquisaNomePaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPesquisaNomePaciente.Name = "cboPesquisaNomePaciente";
            cboPesquisaNomePaciente.Size = new Size(477, 49);
            cboPesquisaNomePaciente.StartIndex = 0;
            cboPesquisaNomePaciente.TabIndex = 12;
            // 
            // cboPesquisaNomeDentista
            // 
            cboPesquisaNomeDentista.AutoResize = false;
            cboPesquisaNomeDentista.BackColor = Color.FromArgb(255, 255, 255);
            cboPesquisaNomeDentista.Depth = 0;
            cboPesquisaNomeDentista.DrawMode = DrawMode.OwnerDrawVariable;
            cboPesquisaNomeDentista.DropDownHeight = 174;
            cboPesquisaNomeDentista.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPesquisaNomeDentista.DropDownWidth = 121;
            cboPesquisaNomeDentista.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPesquisaNomeDentista.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPesquisaNomeDentista.FormattingEnabled = true;
            cboPesquisaNomeDentista.Hint = "Dentista";
            cboPesquisaNomeDentista.IntegralHeight = false;
            cboPesquisaNomeDentista.ItemHeight = 43;
            cboPesquisaNomeDentista.Location = new Point(217, 15);
            cboPesquisaNomeDentista.MaxDropDownItems = 4;
            cboPesquisaNomeDentista.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPesquisaNomeDentista.Name = "cboPesquisaNomeDentista";
            cboPesquisaNomeDentista.Size = new Size(272, 49);
            cboPesquisaNomeDentista.StartIndex = 0;
            cboPesquisaNomeDentista.TabIndex = 11;
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
            txtId.Location = new Point(443, 19);
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
            txtId.Size = new Size(47, 48);
            txtId.TabIndex = 10;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(15, 139);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 11;
            label1.Text = "R$";
            // 
            // CadastroConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 538);
            Location = new Point(0, 0);
            Name = "CadastroConsulta";
            Text = "CadastroConsulta";
            tabCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
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

        private ReaLTaiizor.Controls.MaterialComboBox cboNomeDentista;
        private ReaLTaiizor.Controls.MaterialComboBox cboNomePaciente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorConsulta;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataConsulta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataInicio;
        private ReaLTaiizor.Controls.MaterialComboBox cboPesquisaNomePaciente;
        private ReaLTaiizor.Controls.MaterialComboBox cboPesquisaNomeDentista;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataFim;
        private ReaLTaiizor.Controls.MaterialButton btmPesquisar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private Label label1;
        private CheckBox chkTodos;
    }
}