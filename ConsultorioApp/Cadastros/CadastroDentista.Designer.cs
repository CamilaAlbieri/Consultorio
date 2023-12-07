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
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtTelefone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtCPFD = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.cboEspecialidade = new ReaLTaiizor.Controls.MaterialComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPesquisaDentista = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            this.tabCadastro.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageConsulta.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPageCadastro.Controls.Add(this.cboEspecialidade);
            this.tabPageCadastro.Controls.Add(this.txtCPFD);
            this.tabPageCadastro.Controls.Add(this.txtTelefone);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Controls.SetChildIndex(this.panel1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtTelefone, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtCPFD, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboEspecialidade, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 360);
            // 
            // tabPage2
            // 
            this.tabPageConsulta.Controls.Add(this.panel3);
            this.tabPageConsulta.Controls.SetChildIndex(this.panel2, 0);
            this.tabPageConsulta.Controls.SetChildIndex(this.panel3, 0);
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(15, 19);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(477, 48);
            this.txtNome.TabIndex = 1;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.AllowPromptAsInput = true;
            this.txtTelefone.AnimateReadOnly = false;
            this.txtTelefone.AsciiOnly = false;
            this.txtTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefone.BeepOnError = false;
            this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefone.HidePromptOnLeave = false;
            this.txtTelefone.HideSelection = true;
            this.txtTelefone.Hint = "Telefone";
            this.txtTelefone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtTelefone.LeadingIcon = null;
            this.txtTelefone.Location = new System.Drawing.Point(15, 73);
            this.txtTelefone.Mask = "(99)99999-9999";
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.PrefixSuffixText = null;
            this.txtTelefone.PromptChar = '_';
            this.txtTelefone.ReadOnly = false;
            this.txtTelefone.RejectInputOnFirstFailure = false;
            this.txtTelefone.ResetOnPrompt = true;
            this.txtTelefone.ResetOnSpace = true;
            this.txtTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.ShortcutsEnabled = true;
            this.txtTelefone.Size = new System.Drawing.Size(477, 48);
            this.txtTelefone.SkipLiterals = true;
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.TabStop = false;
            this.txtTelefone.Text = "(  )     -";
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTelefone.TrailingIcon = null;
            this.txtTelefone.UseSystemPasswordChar = false;
            this.txtTelefone.ValidatingType = null;
            // 
            // txtCPFD
            // 
            this.txtCPFD.AllowPromptAsInput = true;
            this.txtCPFD.AnimateReadOnly = false;
            this.txtCPFD.AsciiOnly = false;
            this.txtCPFD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCPFD.BeepOnError = false;
            this.txtCPFD.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCPFD.Depth = 0;
            this.txtCPFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPFD.HidePromptOnLeave = false;
            this.txtCPFD.HideSelection = true;
            this.txtCPFD.Hint = "CPF";
            this.txtCPFD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCPFD.LeadingIcon = null;
            this.txtCPFD.Location = new System.Drawing.Point(15, 127);
            this.txtCPFD.Mask = "999,999,999-99";
            this.txtCPFD.MaxLength = 32767;
            this.txtCPFD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCPFD.Name = "txtCPFD";
            this.txtCPFD.PasswordChar = '\0';
            this.txtCPFD.PrefixSuffixText = null;
            this.txtCPFD.PromptChar = '_';
            this.txtCPFD.ReadOnly = false;
            this.txtCPFD.RejectInputOnFirstFailure = false;
            this.txtCPFD.ResetOnPrompt = true;
            this.txtCPFD.ResetOnSpace = true;
            this.txtCPFD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCPFD.SelectedText = "";
            this.txtCPFD.SelectionLength = 0;
            this.txtCPFD.SelectionStart = 0;
            this.txtCPFD.ShortcutsEnabled = true;
            this.txtCPFD.Size = new System.Drawing.Size(477, 48);
            this.txtCPFD.SkipLiterals = true;
            this.txtCPFD.TabIndex = 3;
            this.txtCPFD.TabStop = false;
            this.txtCPFD.Text = "   .   .   -";
            this.txtCPFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCPFD.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCPFD.TrailingIcon = null;
            this.txtCPFD.UseSystemPasswordChar = false;
            this.txtCPFD.ValidatingType = null;
            // 
            // cboEspecialidade
            // 
            this.cboEspecialidade.AutoResize = false;
            this.cboEspecialidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboEspecialidade.Depth = 0;
            this.cboEspecialidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboEspecialidade.DropDownHeight = 174;
            this.cboEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidade.DropDownWidth = 121;
            this.cboEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboEspecialidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboEspecialidade.FormattingEnabled = true;
            this.cboEspecialidade.Hint = "Especialidade";
            this.cboEspecialidade.IntegralHeight = false;
            this.cboEspecialidade.ItemHeight = 43;
            this.cboEspecialidade.Location = new System.Drawing.Point(15, 181);
            this.cboEspecialidade.MaxDropDownItems = 4;
            this.cboEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboEspecialidade.Name = "cboEspecialidade";
            this.cboEspecialidade.Size = new System.Drawing.Size(477, 49);
            this.cboEspecialidade.StartIndex = 0;
            this.cboEspecialidade.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btmPesquisar);
            this.panel3.Controls.Add(this.cmbPesquisaDentista);
            this.panel3.Location = new System.Drawing.Point(9, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 193);
            this.panel3.TabIndex = 5;
            // 
            // cmbPesquisaDentista
            // 
            this.cmbPesquisaDentista.AutoResize = false;
            this.cmbPesquisaDentista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPesquisaDentista.Depth = 0;
            this.cmbPesquisaDentista.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPesquisaDentista.DropDownHeight = 174;
            this.cmbPesquisaDentista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisaDentista.DropDownWidth = 121;
            this.cmbPesquisaDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPesquisaDentista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPesquisaDentista.FormattingEnabled = true;
            this.cmbPesquisaDentista.Hint = "Dentista";
            this.cmbPesquisaDentista.IntegralHeight = false;
            this.cmbPesquisaDentista.ItemHeight = 43;
            this.cmbPesquisaDentista.Location = new System.Drawing.Point(16, 39);
            this.cmbPesquisaDentista.MaxDropDownItems = 4;
            this.cmbPesquisaDentista.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cmbPesquisaDentista.Name = "cmbPesquisaDentista";
            this.cmbPesquisaDentista.Size = new System.Drawing.Size(461, 49);
            this.cmbPesquisaDentista.StartIndex = 0;
            this.cmbPesquisaDentista.TabIndex = 1;
            // 
            // btmPesquisar
            // 
            this.btmPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btmPesquisar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btmPesquisar.Depth = 0;
            this.btmPesquisar.HighEmphasis = true;
            this.btmPesquisar.Icon = null;
            this.btmPesquisar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btmPesquisar.Location = new System.Drawing.Point(192, 136);
            this.btmPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btmPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btmPesquisar.Name = "btmPesquisar";
            this.btmPesquisar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btmPesquisar.Size = new System.Drawing.Size(100, 36);
            this.btmPesquisar.TabIndex = 15;
            this.btmPesquisar.Text = "Pesquisar";
            this.btmPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btmPesquisar.UseAccentColor = false;
            this.btmPesquisar.UseVisualStyleBackColor = true;
            // 
            // CadastroDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 544);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroDentista";
            this.Text = "CadastroDentista";
            this.tabCadastro.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageConsulta.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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