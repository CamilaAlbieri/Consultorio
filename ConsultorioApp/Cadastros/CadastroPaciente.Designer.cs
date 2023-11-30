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
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboConvenio);
            this.tabPage1.Controls.Add(this.txtObservacao);
            this.tabPage1.Controls.Add(this.txtCPF);
            this.tabPage1.Controls.Add(this.txtTelefone);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.SetChildIndex(this.panel1, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtTelefone, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtCPF, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtObservacao, 0);
            this.tabPage1.Controls.SetChildIndex(this.cboConvenio, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 338);
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
            // CadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 523);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroPaciente";
            this.Text = "CadastroPaciente";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCPF;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtObservacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboConvenio;
    }
}