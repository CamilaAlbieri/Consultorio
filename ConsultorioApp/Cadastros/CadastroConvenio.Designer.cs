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
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Size = new System.Drawing.Size(524, 198);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtConvenio);
            this.tabPage1.Size = new System.Drawing.Size(516, 163);
            this.tabPage1.Controls.SetChildIndex(this.panel1, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtConvenio, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 86);
            // 
            // txtConvenio
            // 
            this.txtConvenio.AnimateReadOnly = false;
            this.txtConvenio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtConvenio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtConvenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtConvenio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConvenio.Depth = 0;
            this.txtConvenio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // CadastroConvenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 276);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroConvenio";
            this.Text = "CadastroConvenio";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtConvenio;
    }
}