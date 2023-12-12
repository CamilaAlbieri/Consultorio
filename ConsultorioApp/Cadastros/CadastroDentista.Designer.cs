namespace Consultorio.App.Cadastros
{
    partial class CadastroDentista
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTelefone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtCPF = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            panel3 = new Panel();
            chkTodos = new CheckBox();
            btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            cmbEspecialidade = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lstEspecialidades = new ListView();
            colEsp = new ColumnHeader();
            lblesps = new Label();
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
            tabCadastro.Location = new Point(6, 64);
            tabCadastro.Margin = new Padding(3, 2, 3, 2);
            tabCadastro.Size = new Size(524, 408);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(lblesps);
            tabPageCadastro.Controls.Add(lstEspecialidades);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtCPF);
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Margin = new Padding(3, 4, 3, 4);
            tabPageCadastro.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastro.Size = new Size(516, 439);
            tabPageCadastro.Controls.SetChildIndex(panel1, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCPF, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(lstEspecialidades, 0);
            tabPageCadastro.Controls.SetChildIndex(lblesps, 0);
            // 
            // panel1
            // 
            panel1.Location = new Point(4, 360);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(443, 47);
            // 
            // panel2
            // 
            panel2.Location = new Point(6, 301);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Size = new Size(498, 65);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(panel3);
            tabPageConsulta.Margin = new Padding(3, 4, 3, 4);
            tabPageConsulta.Padding = new Padding(3, 4, 3, 4);
            tabPageConsulta.Size = new Size(516, 373);
            tabPageConsulta.Controls.SetChildIndex(panel2, 0);
            tabPageConsulta.Controls.SetChildIndex(panel3, 0);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(214, 10);
            btnNovo.Margin = new Padding(4, 4, 4, 4);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(305, 10);
            btnEditar.Margin = new Padding(4, 4, 4, 4);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(398, 10);
            btnExcluir.Margin = new Padding(4, 4, 4, 4);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(268, 3);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(359, 3);
            btnSalvar.Margin = new Padding(4, 4, 4, 4);
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
            txtNome.Size = new Size(428, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
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
            txtTelefone.TabIndex = 2;
            txtTelefone.TabStop = false;
            txtTelefone.Text = "(  )     -";
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            txtTelefone.ValidatingType = null;
            txtTelefone.Click += txtTelefone_Click;
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
            txtCPF.TabIndex = 3;
            txtCPF.TabStop = false;
            txtCPF.Text = "   .   .   -";
            txtCPF.TextAlign = HorizontalAlignment.Left;
            txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCPF.TrailingIcon = null;
            txtCPF.UseSystemPasswordChar = false;
            txtCPF.ValidatingType = null;
            // 
            // panel3
            // 
            panel3.Controls.Add(chkTodos);
            panel3.Controls.Add(btmPesquisar);
            panel3.Controls.Add(cmbEspecialidade);
            panel3.Location = new Point(9, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(497, 125);
            panel3.TabIndex = 5;
            // 
            // chkTodos
            // 
            chkTodos.AutoSize = true;
            chkTodos.Location = new Point(16, 71);
            chkTodos.Margin = new Padding(3, 2, 3, 2);
            chkTodos.Name = "chkTodos";
            chkTodos.Size = new Size(122, 19);
            chkTodos.TabIndex = 16;
            chkTodos.Text = "Todos os dentistas";
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
            btmPesquisar.Location = new Point(191, 71);
            btmPesquisar.Margin = new Padding(4, 6, 4, 6);
            btmPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btmPesquisar.Name = "btmPesquisar";
            btmPesquisar.NoAccentTextColor = Color.Empty;
            btmPesquisar.Size = new Size(100, 36);
            btmPesquisar.TabIndex = 15;
            btmPesquisar.Text = "Pesquisar";
            btmPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btmPesquisar.UseAccentColor = false;
            btmPesquisar.UseVisualStyleBackColor = true;
            btmPesquisar.Click += btmPesquisar_Click;
            // 
            // cmbEspecialidade
            // 
            cmbEspecialidade.AutoResize = false;
            cmbEspecialidade.BackColor = Color.FromArgb(255, 255, 255);
            cmbEspecialidade.Depth = 0;
            cmbEspecialidade.DrawMode = DrawMode.OwnerDrawVariable;
            cmbEspecialidade.DropDownHeight = 174;
            cmbEspecialidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidade.DropDownWidth = 121;
            cmbEspecialidade.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbEspecialidade.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbEspecialidade.FormattingEnabled = true;
            cmbEspecialidade.Hint = "Especialidade";
            cmbEspecialidade.IntegralHeight = false;
            cmbEspecialidade.ItemHeight = 43;
            cmbEspecialidade.Location = new Point(16, 3);
            cmbEspecialidade.MaxDropDownItems = 4;
            cmbEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbEspecialidade.Name = "cmbEspecialidade";
            cmbEspecialidade.Size = new Size(461, 49);
            cmbEspecialidade.StartIndex = 0;
            cmbEspecialidade.TabIndex = 1;
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
            txtId.TabIndex = 11;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // lstEspecialidades
            // 
            lstEspecialidades.Columns.AddRange(new ColumnHeader[] { colEsp });
            lstEspecialidades.FullRowSelect = true;
            lstEspecialidades.Location = new Point(13, 195);
            lstEspecialidades.Margin = new Padding(3, 2, 3, 2);
            lstEspecialidades.Name = "lstEspecialidades";
            lstEspecialidades.Size = new Size(477, 150);
            lstEspecialidades.TabIndex = 12;
            lstEspecialidades.UseCompatibleStateImageBehavior = false;
            lstEspecialidades.View = View.List;
            // 
            // colEsp
            // 
            colEsp.Text = "Especialidade";
            // 
            // lblesps
            // 
            lblesps.AutoSize = true;
            lblesps.Location = new Point(15, 178);
            lblesps.Name = "lblesps";
            lblesps.Size = new Size(231, 15);
            lblesps.TabIndex = 13;
            lblesps.Text = "Selecione a(s) especialidade(s) do dentista:";
            // 
            // CadastroDentista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 478);
            Location = new Point(0, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroDentista";
            Padding = new Padding(3, 85, 3, 4);
            Text = "CadastroDentista";
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

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCPF;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialComboBox cmbEspecialidade;
        private ReaLTaiizor.Controls.MaterialButton btmPesquisar;
        private ListView lstEspecialidades;
        private ColumnHeader colEsp;
        private Label lblesps;
        private CheckBox chkTodos;
    }
}