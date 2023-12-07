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
            this.txtCPF = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtTelefone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtObservacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboConvenio = new ReaLTaiizor.Controls.MaterialComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            this.cboPesquisaConsulta = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboPesquisaNomePaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            this.tabCadastro.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageConsulta.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPageCadastro.Controls.Add(this.cboConvenio);
            this.tabPageCadastro.Controls.Add(this.txtObservacao);
            this.tabPageCadastro.Controls.Add(this.txtCPF);
            this.tabPageCadastro.Controls.Add(this.txtTelefone);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Controls.SetChildIndex(this.panel1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtTelefone, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtCPF, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtObservacao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboConvenio, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 338);
            // 
            // tabPage2
            // 
            this.tabPageConsulta.Controls.Add(this.panel3);
            this.tabPageConsulta.Controls.SetChildIndex(this.panel2, 0);
            this.tabPageConsulta.Controls.SetChildIndex(this.panel3, 0);
            // 
            // txtCPF
            // 
            this.txtCPF.AllowPromptAsInput = true;
            this.txtCPF.AnimateReadOnly = false;
            this.txtCPF.AsciiOnly = false;
            this.txtCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCPF.BeepOnError = false;
            this.txtCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCPF.Depth = 0;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.HidePromptOnLeave = false;
            this.txtCPF.HideSelection = true;
            this.txtCPF.Hint = "CPF";
            this.txtCPF.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCPF.LeadingIcon = null;
            this.txtCPF.Location = new System.Drawing.Point(15, 127);
            this.txtCPF.Mask = "999,999,999-99";
            this.txtCPF.MaxLength = 32767;
            this.txtCPF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.PrefixSuffixText = null;
            this.txtCPF.PromptChar = '_';
            this.txtCPF.ReadOnly = false;
            this.txtCPF.RejectInputOnFirstFailure = false;
            this.txtCPF.ResetOnPrompt = true;
            this.txtCPF.ResetOnSpace = true;
            this.txtCPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.ShortcutsEnabled = true;
            this.txtCPF.Size = new System.Drawing.Size(477, 48);
            this.txtCPF.SkipLiterals = true;
            this.txtCPF.TabIndex = 6;
            this.txtCPF.TabStop = false;
            this.txtCPF.Text = "   .   .   -";
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCPF.TrailingIcon = null;
            this.txtCPF.UseSystemPasswordChar = false;
            this.txtCPF.ValidatingType = null;
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
            this.txtTelefone.TabIndex = 5;
            this.txtTelefone.TabStop = false;
            this.txtTelefone.Text = "(  )     -";
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTelefone.TrailingIcon = null;
            this.txtTelefone.UseSystemPasswordChar = false;
            this.txtTelefone.ValidatingType = null;
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
            this.txtNome.TabIndex = 4;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtObservacao
            // 
            this.txtObservacao.AnimateReadOnly = false;
            this.txtObservacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtObservacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtObservacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtObservacao.Depth = 0;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtObservacao.HideSelection = true;
            this.txtObservacao.Hint = "Observação";
            this.txtObservacao.LeadingIcon = null;
            this.txtObservacao.Location = new System.Drawing.Point(20, 190);
            this.txtObservacao.MaxLength = 32767;
            this.txtObservacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.PasswordChar = '\0';
            this.txtObservacao.PrefixSuffixText = null;
            this.txtObservacao.ReadOnly = false;
            this.txtObservacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtObservacao.SelectedText = "";
            this.txtObservacao.SelectionLength = 0;
            this.txtObservacao.SelectionStart = 0;
            this.txtObservacao.ShortcutsEnabled = true;
            this.txtObservacao.Size = new System.Drawing.Size(472, 48);
            this.txtObservacao.TabIndex = 7;
            this.txtObservacao.TabStop = false;
            this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacao.TrailingIcon = null;
            this.txtObservacao.UseSystemPasswordChar = false;
            // 
            // cboConvenio
            // 
            this.cboConvenio.AutoResize = false;
            this.cboConvenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboConvenio.Depth = 0;
            this.cboConvenio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboConvenio.DropDownHeight = 174;
            this.cboConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConvenio.DropDownWidth = 121;
            this.cboConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboConvenio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Hint = "Convênio";
            this.cboConvenio.IntegralHeight = false;
            this.cboConvenio.ItemHeight = 43;
            this.cboConvenio.Location = new System.Drawing.Point(20, 244);
            this.cboConvenio.MaxDropDownItems = 4;
            this.cboConvenio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(470, 49);
            this.cboConvenio.StartIndex = 0;
            this.cboConvenio.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btmPesquisar);
            this.panel3.Controls.Add(this.cboPesquisaConsulta);
            this.panel3.Controls.Add(this.cboPesquisaNomePaciente);
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
            this.btmPesquisar.Location = new System.Drawing.Point(195, 140);
            this.btmPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btmPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btmPesquisar.Name = "btmPesquisar";
            this.btmPesquisar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btmPesquisar.Size = new System.Drawing.Size(100, 36);
            this.btmPesquisar.TabIndex = 17;
            this.btmPesquisar.Text = "Pesquisar";
            this.btmPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btmPesquisar.UseAccentColor = false;
            this.btmPesquisar.UseVisualStyleBackColor = true;
            // 
            // cboPesquisaConsulta
            // 
            this.cboPesquisaConsulta.AutoResize = false;
            this.cboPesquisaConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboPesquisaConsulta.Depth = 0;
            this.cboPesquisaConsulta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPesquisaConsulta.DropDownHeight = 174;
            this.cboPesquisaConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesquisaConsulta.DropDownWidth = 121;
            this.cboPesquisaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboPesquisaConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboPesquisaConsulta.FormattingEnabled = true;
            this.cboPesquisaConsulta.Hint = "Consulta";
            this.cboPesquisaConsulta.IntegralHeight = false;
            this.cboPesquisaConsulta.ItemHeight = 43;
            this.cboPesquisaConsulta.Location = new System.Drawing.Point(16, 72);
            this.cboPesquisaConsulta.MaxDropDownItems = 4;
            this.cboPesquisaConsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboPesquisaConsulta.Name = "cboPesquisaConsulta";
            this.cboPesquisaConsulta.Size = new System.Drawing.Size(464, 49);
            this.cboPesquisaConsulta.StartIndex = 0;
            this.cboPesquisaConsulta.TabIndex = 14;
            // 
            // cboPesquisaNomePaciente
            // 
            this.cboPesquisaNomePaciente.AutoResize = false;
            this.cboPesquisaNomePaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboPesquisaNomePaciente.Depth = 0;
            this.cboPesquisaNomePaciente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPesquisaNomePaciente.DropDownHeight = 174;
            this.cboPesquisaNomePaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesquisaNomePaciente.DropDownWidth = 121;
            this.cboPesquisaNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboPesquisaNomePaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboPesquisaNomePaciente.FormattingEnabled = true;
            this.cboPesquisaNomePaciente.Hint = "Paciente";
            this.cboPesquisaNomePaciente.IntegralHeight = false;
            this.cboPesquisaNomePaciente.ItemHeight = 43;
            this.cboPesquisaNomePaciente.Location = new System.Drawing.Point(17, 13);
            this.cboPesquisaNomePaciente.MaxDropDownItems = 4;
            this.cboPesquisaNomePaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboPesquisaNomePaciente.Name = "cboPesquisaNomePaciente";
            this.cboPesquisaNomePaciente.Size = new System.Drawing.Size(464, 49);
            this.cboPesquisaNomePaciente.StartIndex = 0;
            this.cboPesquisaNomePaciente.TabIndex = 13;
            // 
            // CadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 523);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroPaciente";
            this.Text = "CadastroPaciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
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

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCPF;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtObservacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboConvenio;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialComboBox cboPesquisaConsulta;
        private ReaLTaiizor.Controls.MaterialComboBox cboPesquisaNomePaciente;
        private ReaLTaiizor.Controls.MaterialButton btmPesquisar;
    }
}