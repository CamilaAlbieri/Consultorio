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
            txtCPFD = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboEspecialidade = new ReaLTaiizor.Controls.MaterialComboBox();
            panel3 = new Panel();
            btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            cmbPesquisaDentista = new ReaLTaiizor.Controls.MaterialComboBox();
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
            tabPageCadastro.Controls.Add(cboEspecialidade);
            tabPageCadastro.Controls.Add(txtCPFD);
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.SetChildIndex(panel1, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCPFD, 0);
            tabPageCadastro.Controls.SetChildIndex(cboEspecialidade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // panel1
            // 
            panel1.Location = new Point(4, 360);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(panel3);
            tabPageConsulta.Controls.SetChildIndex(panel2, 0);
            tabPageConsulta.Controls.SetChildIndex(panel3, 0);
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
            // 
            // txtCPFD
            // 
            txtCPFD.AllowPromptAsInput = true;
            txtCPFD.AnimateReadOnly = false;
            txtCPFD.AsciiOnly = false;
            txtCPFD.BackgroundImageLayout = ImageLayout.None;
            txtCPFD.BeepOnError = false;
            txtCPFD.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCPFD.Depth = 0;
            txtCPFD.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCPFD.HidePromptOnLeave = false;
            txtCPFD.HideSelection = true;
            txtCPFD.Hint = "CPF";
            txtCPFD.InsertKeyMode = InsertKeyMode.Default;
            txtCPFD.LeadingIcon = null;
            txtCPFD.Location = new Point(15, 127);
            txtCPFD.Mask = "999,999,999-99";
            txtCPFD.MaxLength = 32767;
            txtCPFD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCPFD.Name = "txtCPFD";
            txtCPFD.PasswordChar = '\0';
            txtCPFD.PrefixSuffixText = null;
            txtCPFD.PromptChar = '_';
            txtCPFD.ReadOnly = false;
            txtCPFD.RejectInputOnFirstFailure = false;
            txtCPFD.ResetOnPrompt = true;
            txtCPFD.ResetOnSpace = true;
            txtCPFD.RightToLeft = RightToLeft.No;
            txtCPFD.SelectedText = "";
            txtCPFD.SelectionLength = 0;
            txtCPFD.SelectionStart = 0;
            txtCPFD.ShortcutsEnabled = true;
            txtCPFD.Size = new Size(477, 48);
            txtCPFD.SkipLiterals = true;
            txtCPFD.TabIndex = 3;
            txtCPFD.TabStop = false;
            txtCPFD.Text = "   .   .   -";
            txtCPFD.TextAlign = HorizontalAlignment.Left;
            txtCPFD.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCPFD.TrailingIcon = null;
            txtCPFD.UseSystemPasswordChar = false;
            txtCPFD.ValidatingType = null;
            // 
            // cboEspecialidade
            // 
            cboEspecialidade.AutoResize = false;
            cboEspecialidade.BackColor = Color.FromArgb(255, 255, 255);
            cboEspecialidade.Depth = 0;
            cboEspecialidade.DrawMode = DrawMode.OwnerDrawVariable;
            cboEspecialidade.DropDownHeight = 174;
            cboEspecialidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidade.DropDownWidth = 121;
            cboEspecialidade.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEspecialidade.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEspecialidade.FormattingEnabled = true;
            cboEspecialidade.Hint = "Especialidade";
            cboEspecialidade.IntegralHeight = false;
            cboEspecialidade.ItemHeight = 43;
            cboEspecialidade.Location = new Point(15, 181);
            cboEspecialidade.MaxDropDownItems = 4;
            cboEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEspecialidade.Name = "cboEspecialidade";
            cboEspecialidade.Size = new Size(477, 49);
            cboEspecialidade.StartIndex = 0;
            cboEspecialidade.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(btmPesquisar);
            panel3.Controls.Add(cmbPesquisaDentista);
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
            btmPesquisar.Location = new Point(192, 136);
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
            // 
            // cmbPesquisaDentista
            // 
            cmbPesquisaDentista.AutoResize = false;
            cmbPesquisaDentista.BackColor = Color.FromArgb(255, 255, 255);
            cmbPesquisaDentista.Depth = 0;
            cmbPesquisaDentista.DrawMode = DrawMode.OwnerDrawVariable;
            cmbPesquisaDentista.DropDownHeight = 174;
            cmbPesquisaDentista.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPesquisaDentista.DropDownWidth = 121;
            cmbPesquisaDentista.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbPesquisaDentista.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbPesquisaDentista.FormattingEnabled = true;
            cmbPesquisaDentista.Hint = "Dentista";
            cmbPesquisaDentista.IntegralHeight = false;
            cmbPesquisaDentista.ItemHeight = 43;
            cmbPesquisaDentista.Location = new Point(16, 39);
            cmbPesquisaDentista.MaxDropDownItems = 4;
            cmbPesquisaDentista.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbPesquisaDentista.Name = "cmbPesquisaDentista";
            cmbPesquisaDentista.Size = new Size(461, 49);
            cmbPesquisaDentista.StartIndex = 0;
            cmbPesquisaDentista.TabIndex = 1;
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
            // CadastroDentista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 544);
            Location = new Point(0, 0);
            Name = "CadastroDentista";
            Text = "CadastroDentista";
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

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCPF;
        private ReaLTaiizor.Controls.MaterialComboBox cboEspecialidade;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCPFD;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialComboBox cmbPesquisaDentista;
        private ReaLTaiizor.Controls.MaterialButton btmPesquisar;
    }
}