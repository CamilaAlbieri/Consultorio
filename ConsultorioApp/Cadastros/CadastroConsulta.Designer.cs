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
            this.cboEspecialidade = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtValorCnsulta = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtData = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDescricao);
            this.tabPage1.Controls.Add(this.txtData);
            this.tabPage1.Controls.Add(this.txtValorCnsulta);
            this.tabPage1.Controls.Add(this.materialComboBox1);
            this.tabPage1.Controls.Add(this.cboEspecialidade);
            this.tabPage1.Controls.SetChildIndex(this.panel1, 0);
            this.tabPage1.Controls.SetChildIndex(this.cboEspecialidade, 0);
            this.tabPage1.Controls.SetChildIndex(this.materialComboBox1, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtValorCnsulta, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtData, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDescricao, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 237);
            this.panel1.Size = new System.Drawing.Size(510, 63);
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
            this.cboEspecialidade.Hint = "Paciente";
            this.cboEspecialidade.IntegralHeight = false;
            this.cboEspecialidade.ItemHeight = 43;
            this.cboEspecialidade.Location = new System.Drawing.Point(15, 74);
            this.cboEspecialidade.MaxDropDownItems = 4;
            this.cboEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboEspecialidade.Name = "cboEspecialidade";
            this.cboEspecialidade.Size = new System.Drawing.Size(477, 49);
            this.cboEspecialidade.StartIndex = 0;
            this.cboEspecialidade.TabIndex = 5;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Dentista";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(15, 19);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(477, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 6;
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
            // txtData
            // 
            this.txtData.AllowPromptAsInput = true;
            this.txtData.AnimateReadOnly = false;
            this.txtData.AsciiOnly = false;
            this.txtData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtData.BeepOnError = false;
            this.txtData.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtData.Depth = 0;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtData.HidePromptOnLeave = false;
            this.txtData.HideSelection = true;
            this.txtData.Hint = "Data Consulta";
            this.txtData.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtData.LeadingIcon = null;
            this.txtData.Location = new System.Drawing.Point(372, 129);
            this.txtData.Mask = "99/99/9999";
            this.txtData.MaxLength = 32767;
            this.txtData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.PrefixSuffixText = null;
            this.txtData.PromptChar = '_';
            this.txtData.ReadOnly = false;
            this.txtData.RejectInputOnFirstFailure = false;
            this.txtData.ResetOnPrompt = true;
            this.txtData.ResetOnSpace = true;
            this.txtData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtData.SelectedText = "";
            this.txtData.SelectionLength = 0;
            this.txtData.SelectionStart = 0;
            this.txtData.ShortcutsEnabled = true;
            this.txtData.Size = new System.Drawing.Size(120, 48);
            this.txtData.SkipLiterals = true;
            this.txtData.TabIndex = 8;
            this.txtData.TabStop = false;
            this.txtData.Text = "  /  /";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtData.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtData.TrailingIcon = null;
            this.txtData.UseSystemPasswordChar = false;
            this.txtData.ValidatingType = null;
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
            // CadastroConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 416);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroConsulta";
            this.Text = "CadastroConsulta";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private ReaLTaiizor.Controls.MaterialComboBox cboEspecialidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorCnsulta;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtData;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
    }
}