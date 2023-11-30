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
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Size = new System.Drawing.Size(524, 212);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtEspecialidade);
            this.tabPage1.Size = new System.Drawing.Size(516, 177);
            this.tabPage1.Controls.SetChildIndex(this.panel1, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtEspecialidade, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 108);
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.AnimateReadOnly = false;
            this.txtEspecialidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEspecialidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEspecialidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEspecialidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEspecialidade.Depth = 0;
            this.txtEspecialidade.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEspecialidade.HideSelection = true;
            this.txtEspecialidade.Hint = "Especialidade";
            this.txtEspecialidade.LeadingIcon = null;
            this.txtEspecialidade.Location = new System.Drawing.Point(10, 20);
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
            this.txtEspecialidade.Size = new System.Drawing.Size(486, 48);
            this.txtEspecialidade.TabIndex = 1;
            this.txtEspecialidade.TabStop = false;
            this.txtEspecialidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEspecialidade.TrailingIcon = null;
            this.txtEspecialidade.UseSystemPasswordChar = false;
            // 
            // CadastroEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 286);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroEspecialidade";
            this.Text = "CadastroEspecialidade";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEspecialidade;
    }
}