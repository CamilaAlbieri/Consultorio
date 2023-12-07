namespace Consultorio.App.Cadastros
{
    partial class CadastroConvenio
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
            this.txtConvenio = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            this.cmbPesquisaConvenio = new ReaLTaiizor.Controls.MaterialComboBox();
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
            this.tabCadastro.Size = new System.Drawing.Size(524, 462);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.txtConvenio);
            this.tabPageCadastro.Size = new System.Drawing.Size(516, 427);
            this.tabPageCadastro.Controls.SetChildIndex(this.panel1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtConvenio, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 358);
            // 
            // tabPageConsulta
            // 
            this.tabPageConsulta.Controls.Add(this.panel3);
            this.tabPageConsulta.Size = new System.Drawing.Size(516, 427);
            this.tabPageConsulta.Controls.SetChildIndex(this.panel2, 0);
            this.tabPageConsulta.Controls.SetChildIndex(this.panel3, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(273, 4);
            // 
            // txtConvenio
            // 
            this.txtConvenio.AnimateReadOnly = false;
            this.txtConvenio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtConvenio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtConvenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtConvenio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConvenio.Depth = 0;
            this.txtConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConvenio.HideSelection = true;
            this.txtConvenio.Hint = "Convênio";
            this.txtConvenio.LeadingIcon = null;
            this.txtConvenio.Location = new System.Drawing.Point(6, 18);
            this.txtConvenio.MaxLength = 32767;
            this.txtConvenio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.PasswordChar = '\0';
            this.txtConvenio.PrefixSuffixText = null;
            this.txtConvenio.ReadOnly = false;
            this.txtConvenio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConvenio.SelectedText = "";
            this.txtConvenio.SelectionLength = 0;
            this.txtConvenio.SelectionStart = 0;
            this.txtConvenio.ShortcutsEnabled = true;
            this.txtConvenio.Size = new System.Drawing.Size(504, 48);
            this.txtConvenio.TabIndex = 1;
            this.txtConvenio.TabStop = false;
            this.txtConvenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConvenio.TrailingIcon = null;
            this.txtConvenio.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btmPesquisar);
            this.panel3.Controls.Add(this.cmbPesquisaConvenio);
            this.panel3.Location = new System.Drawing.Point(9, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 193);
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
            this.btmPesquisar.Location = new System.Drawing.Point(194, 142);
            this.btmPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btmPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btmPesquisar.Name = "btmPesquisar";
            this.btmPesquisar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btmPesquisar.Size = new System.Drawing.Size(100, 36);
            this.btmPesquisar.TabIndex = 14;
            this.btmPesquisar.Text = "Pesquisar";
            this.btmPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btmPesquisar.UseAccentColor = false;
            this.btmPesquisar.UseVisualStyleBackColor = true;
            // 
            // cmbPesquisaConvenio
            // 
            this.cmbPesquisaConvenio.AutoResize = false;
            this.cmbPesquisaConvenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPesquisaConvenio.Depth = 0;
            this.cmbPesquisaConvenio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPesquisaConvenio.DropDownHeight = 174;
            this.cmbPesquisaConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisaConvenio.DropDownWidth = 121;
            this.cmbPesquisaConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPesquisaConvenio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPesquisaConvenio.FormattingEnabled = true;
            this.cmbPesquisaConvenio.Hint = "Convênio";
            this.cmbPesquisaConvenio.IntegralHeight = false;
            this.cmbPesquisaConvenio.ItemHeight = 43;
            this.cmbPesquisaConvenio.Location = new System.Drawing.Point(4, 47);
            this.cmbPesquisaConvenio.MaxDropDownItems = 4;
            this.cmbPesquisaConvenio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cmbPesquisaConvenio.Name = "cmbPesquisaConvenio";
            this.cmbPesquisaConvenio.Size = new System.Drawing.Size(494, 49);
            this.cmbPesquisaConvenio.StartIndex = 0;
            this.cmbPesquisaConvenio.TabIndex = 0;
            // 
            // CadastroConvenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 535);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroConvenio";
            this.Text = "CadastroConvenio";
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

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtConvenio;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialComboBox cmbPesquisaConvenio;
        private ReaLTaiizor.Controls.MaterialButton btmPesquisar;
    }
}