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
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboEspecialidade);
            this.tabPage1.Controls.Add(this.txtCPFD);
            this.tabPage1.Controls.Add(this.txtTelefone);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.SetChildIndex(this.panel1, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtTelefone, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtCPFD, 0);
            this.tabPage1.Controls.SetChildIndex(this.cboEspecialidade, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 246);
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
            // CadastroDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 416);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroDentista";
            this.Text = "CadastroDentista";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCPF;
        private ReaLTaiizor.Controls.MaterialComboBox cboEspecialidade;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCPFD;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
    }
}