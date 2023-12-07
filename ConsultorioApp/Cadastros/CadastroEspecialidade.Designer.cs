namespace Consultorio.App.Cadastros
{
    partial class CadastroEspecialidade
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
            this.txtEspecialidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            this.cmbPesquisaEspecialidade = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtEspecialidade1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboEspecialidade = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btnPesquisar = new ReaLTaiizor.Controls.MaterialButton();
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
            this.tabCadastro.Size = new System.Drawing.Size(524, 469);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.txtEspecialidade1);
            this.tabPageCadastro.Size = new System.Drawing.Size(516, 434);
            this.tabPageCadastro.Controls.SetChildIndex(this.panel1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtEspecialidade1, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 158);
            // 
            // tabPageConsulta
            // 
            this.tabPageConsulta.Controls.Add(this.btnPesquisar);
            this.tabPageConsulta.Controls.Add(this.cboEspecialidade);
            this.tabPageConsulta.Size = new System.Drawing.Size(516, 434);
            this.tabPageConsulta.Controls.SetChildIndex(this.panel2, 0);
            this.tabPageConsulta.Controls.SetChildIndex(this.cboEspecialidade, 0);
            this.tabPageConsulta.Controls.SetChildIndex(this.btnPesquisar, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(287, 4);
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.AnimateReadOnly = false;
            this.txtEspecialidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEspecialidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEspecialidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEspecialidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEspecialidade.Depth = 0;
            this.txtEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEspecialidade.HideSelection = true;
            this.txtEspecialidade.LeadingIcon = null;
            this.txtEspecialidade.Location = new System.Drawing.Point(0, 0);
            this.txtEspecialidade.MaxLength = 32767;
            this.txtEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.PasswordChar = '\0';
            this.txtEspecialidade.PrefixSuffixText = null;
            this.txtEspecialidade.ReadOnly = false;
            this.txtEspecialidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEspecialidade.SelectedText = "";
            this.txtEspecialidade.SelectionLength = 0;
            this.txtEspecialidade.SelectionStart = 0;
            this.txtEspecialidade.ShortcutsEnabled = true;
            this.txtEspecialidade.Size = new System.Drawing.Size(250, 48);
            this.txtEspecialidade.TabIndex = 0;
            this.txtEspecialidade.TabStop = false;
            this.txtEspecialidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEspecialidade.TrailingIcon = null;
            this.txtEspecialidade.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btmPesquisar);
            this.panel3.Controls.Add(this.cmbPesquisaEspecialidade);
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
            this.btmPesquisar.Location = new System.Drawing.Point(191, 134);
            this.btmPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btmPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btmPesquisar.Name = "btmPesquisar";
            this.btmPesquisar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btmPesquisar.Size = new System.Drawing.Size(100, 36);
            this.btmPesquisar.TabIndex = 16;
            this.btmPesquisar.Text = "Pesquisar";
            this.btmPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btmPesquisar.UseAccentColor = false;
            this.btmPesquisar.UseVisualStyleBackColor = true;
            // 
            // cmbPesquisaEspecialidade
            // 
            this.cmbPesquisaEspecialidade.AutoResize = false;
            this.cmbPesquisaEspecialidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPesquisaEspecialidade.Depth = 0;
            this.cmbPesquisaEspecialidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPesquisaEspecialidade.DropDownHeight = 174;
            this.cmbPesquisaEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisaEspecialidade.DropDownWidth = 121;
            this.cmbPesquisaEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPesquisaEspecialidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPesquisaEspecialidade.FormattingEnabled = true;
            this.cmbPesquisaEspecialidade.Hint = "Especialidade";
            this.cmbPesquisaEspecialidade.IntegralHeight = false;
            this.cmbPesquisaEspecialidade.ItemHeight = 43;
            this.cmbPesquisaEspecialidade.Location = new System.Drawing.Point(20, 41);
            this.cmbPesquisaEspecialidade.MaxDropDownItems = 4;
            this.cmbPesquisaEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cmbPesquisaEspecialidade.Name = "cmbPesquisaEspecialidade";
            this.cmbPesquisaEspecialidade.Size = new System.Drawing.Size(461, 49);
            this.cmbPesquisaEspecialidade.StartIndex = 0;
            this.cmbPesquisaEspecialidade.TabIndex = 2;
            // 
            // txtEspecialidade1
            // 
            this.txtEspecialidade1.AnimateReadOnly = false;
            this.txtEspecialidade1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEspecialidade1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEspecialidade1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEspecialidade1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEspecialidade1.Depth = 0;
            this.txtEspecialidade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEspecialidade1.HideSelection = true;
            this.txtEspecialidade1.Hint = "Especialidade";
            this.txtEspecialidade1.LeadingIcon = null;
            this.txtEspecialidade1.Location = new System.Drawing.Point(7, 44);
            this.txtEspecialidade1.MaxLength = 32767;
            this.txtEspecialidade1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEspecialidade1.Name = "txtEspecialidade1";
            this.txtEspecialidade1.PasswordChar = '\0';
            this.txtEspecialidade1.PrefixSuffixText = null;
            this.txtEspecialidade1.ReadOnly = false;
            this.txtEspecialidade1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEspecialidade1.SelectedText = "";
            this.txtEspecialidade1.SelectionLength = 0;
            this.txtEspecialidade1.SelectionStart = 0;
            this.txtEspecialidade1.ShortcutsEnabled = true;
            this.txtEspecialidade1.Size = new System.Drawing.Size(503, 48);
            this.txtEspecialidade1.TabIndex = 1;
            this.txtEspecialidade1.TabStop = false;
            this.txtEspecialidade1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEspecialidade1.TrailingIcon = null;
            this.txtEspecialidade1.UseSystemPasswordChar = false;
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
            this.cboEspecialidade.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboEspecialidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboEspecialidade.FormattingEnabled = true;
            this.cboEspecialidade.Hint = "Especialidade";
            this.cboEspecialidade.IntegralHeight = false;
            this.cboEspecialidade.ItemHeight = 43;
            this.cboEspecialidade.Location = new System.Drawing.Point(9, 34);
            this.cboEspecialidade.MaxDropDownItems = 4;
            this.cboEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboEspecialidade.Name = "cboEspecialidade";
            this.cboEspecialidade.Size = new System.Drawing.Size(497, 49);
            this.cboEspecialidade.StartIndex = 0;
            this.cboEspecialidade.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPesquisar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPesquisar.Depth = 0;
            this.btnPesquisar.HighEmphasis = true;
            this.btnPesquisar.Icon = null;
            this.btnPesquisar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnPesquisar.Location = new System.Drawing.Point(181, 114);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPesquisar.Size = new System.Drawing.Size(158, 36);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPesquisar.UseAccentColor = false;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // CadastroEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 545);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroEspecialidade";
            this.Text = "CadastroEspecialidade";
            this.tabCadastro.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageConsulta.ResumeLayout(false);
            this.tabPageConsulta.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialComboBox cmbPesquisaEspecialidade;
        private ReaLTaiizor.Controls.MaterialButton btmPesquisar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEspecialidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEspecialidade1;
        private ReaLTaiizor.Controls.MaterialComboBox cboEspecialidade;
        private ReaLTaiizor.Controls.MaterialButton btnPesquisar;
    }
}