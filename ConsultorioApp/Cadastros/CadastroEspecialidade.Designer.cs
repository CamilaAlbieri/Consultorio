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
            txtEspecialidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel3 = new Panel();
            btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            cmbPesquisaEspecialidade = new ReaLTaiizor.Controls.MaterialComboBox();
            txtEspecialidade1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboEspecialidade = new ReaLTaiizor.Controls.MaterialComboBox();
            btnPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabCadastro
            // 
            tabCadastro.Margin = new Padding(3, 5, 3, 5);
            tabCadastro.Size = new Size(599, 625);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtEspecialidade1);
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(591, 590);
            tabPageCadastro.Controls.SetChildIndex(panel1, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEspecialidade1, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // panel1
            // 
            panel1.Location = new Point(8, 211);
            panel1.Margin = new Padding(3, 5, 3, 5);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btnPesquisar);
            tabPageConsulta.Controls.Add(cboEspecialidade);
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Margin = new Padding(3, 5, 3, 5);
            tabPageConsulta.Padding = new Padding(3, 5, 3, 5);
            tabPageConsulta.Size = new Size(591, 590);
            tabPageConsulta.Controls.SetChildIndex(panel2, 0);
            tabPageConsulta.Controls.SetChildIndex(cboEspecialidade, 0);
            tabPageConsulta.Controls.SetChildIndex(btnPesquisar, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(328, 5);
            btnCancelar.Margin = new Padding(6, 11, 6, 11);
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.AnimateReadOnly = false;
            txtEspecialidade.AutoCompleteMode = AutoCompleteMode.None;
            txtEspecialidade.AutoCompleteSource = AutoCompleteSource.None;
            txtEspecialidade.BackgroundImageLayout = ImageLayout.None;
            txtEspecialidade.CharacterCasing = CharacterCasing.Normal;
            txtEspecialidade.Depth = 0;
            txtEspecialidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEspecialidade.HideSelection = true;
            txtEspecialidade.LeadingIcon = null;
            txtEspecialidade.Location = new Point(0, 0);
            txtEspecialidade.MaxLength = 32767;
            txtEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.PasswordChar = '\0';
            txtEspecialidade.PrefixSuffixText = null;
            txtEspecialidade.ReadOnly = false;
            txtEspecialidade.RightToLeft = RightToLeft.No;
            txtEspecialidade.SelectedText = "";
            txtEspecialidade.SelectionLength = 0;
            txtEspecialidade.SelectionStart = 0;
            txtEspecialidade.ShortcutsEnabled = true;
            txtEspecialidade.Size = new Size(250, 48);
            txtEspecialidade.TabIndex = 0;
            txtEspecialidade.TabStop = false;
            txtEspecialidade.TextAlign = HorizontalAlignment.Left;
            txtEspecialidade.TrailingIcon = null;
            txtEspecialidade.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btmPesquisar);
            panel3.Controls.Add(cmbPesquisaEspecialidade);
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
            btmPesquisar.Location = new Point(191, 134);
            btmPesquisar.Margin = new Padding(4, 6, 4, 6);
            btmPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btmPesquisar.Name = "btmPesquisar";
            btmPesquisar.NoAccentTextColor = Color.Empty;
            btmPesquisar.Size = new Size(100, 36);
            btmPesquisar.TabIndex = 16;
            btmPesquisar.Text = "Pesquisar";
            btmPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btmPesquisar.UseAccentColor = false;
            btmPesquisar.UseVisualStyleBackColor = true;
            // 
            // cmbPesquisaEspecialidade
            // 
            cmbPesquisaEspecialidade.AutoResize = false;
            cmbPesquisaEspecialidade.BackColor = Color.FromArgb(255, 255, 255);
            cmbPesquisaEspecialidade.Depth = 0;
            cmbPesquisaEspecialidade.DrawMode = DrawMode.OwnerDrawVariable;
            cmbPesquisaEspecialidade.DropDownHeight = 174;
            cmbPesquisaEspecialidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPesquisaEspecialidade.DropDownWidth = 121;
            cmbPesquisaEspecialidade.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbPesquisaEspecialidade.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbPesquisaEspecialidade.FormattingEnabled = true;
            cmbPesquisaEspecialidade.Hint = "Especialidade";
            cmbPesquisaEspecialidade.IntegralHeight = false;
            cmbPesquisaEspecialidade.ItemHeight = 43;
            cmbPesquisaEspecialidade.Location = new Point(20, 41);
            cmbPesquisaEspecialidade.MaxDropDownItems = 4;
            cmbPesquisaEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbPesquisaEspecialidade.Name = "cmbPesquisaEspecialidade";
            cmbPesquisaEspecialidade.Size = new Size(461, 49);
            cmbPesquisaEspecialidade.StartIndex = 0;
            cmbPesquisaEspecialidade.TabIndex = 2;
            // 
            // txtEspecialidade1
            // 
            txtEspecialidade1.AnimateReadOnly = false;
            txtEspecialidade1.AutoCompleteMode = AutoCompleteMode.None;
            txtEspecialidade1.AutoCompleteSource = AutoCompleteSource.None;
            txtEspecialidade1.BackgroundImageLayout = ImageLayout.None;
            txtEspecialidade1.CharacterCasing = CharacterCasing.Normal;
            txtEspecialidade1.Depth = 0;
            txtEspecialidade1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEspecialidade1.HideSelection = true;
            txtEspecialidade1.Hint = "Especialidade";
            txtEspecialidade1.LeadingIcon = null;
            txtEspecialidade1.Location = new Point(8, 59);
            txtEspecialidade1.Margin = new Padding(3, 4, 3, 4);
            txtEspecialidade1.MaxLength = 32767;
            txtEspecialidade1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEspecialidade1.Name = "txtEspecialidade1";
            txtEspecialidade1.PasswordChar = '\0';
            txtEspecialidade1.PrefixSuffixText = null;
            txtEspecialidade1.ReadOnly = false;
            txtEspecialidade1.RightToLeft = RightToLeft.No;
            txtEspecialidade1.SelectedText = "";
            txtEspecialidade1.SelectionLength = 0;
            txtEspecialidade1.SelectionStart = 0;
            txtEspecialidade1.ShortcutsEnabled = true;
            txtEspecialidade1.Size = new Size(513, 48);
            txtEspecialidade1.TabIndex = 1;
            txtEspecialidade1.TabStop = false;
            txtEspecialidade1.TextAlign = HorizontalAlignment.Left;
            txtEspecialidade1.TrailingIcon = null;
            txtEspecialidade1.UseSystemPasswordChar = false;
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
            cboEspecialidade.Location = new Point(10, 45);
            cboEspecialidade.Margin = new Padding(3, 4, 3, 4);
            cboEspecialidade.MaxDropDownItems = 4;
            cboEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEspecialidade.Name = "cboEspecialidade";
            cboEspecialidade.Size = new Size(567, 49);
            cboEspecialidade.StartIndex = 0;
            cboEspecialidade.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            btnPesquisar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPesquisar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPesquisar.Depth = 0;
            btnPesquisar.HighEmphasis = true;
            btnPesquisar.Icon = null;
            btnPesquisar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnPesquisar.Location = new Point(207, 152);
            btnPesquisar.Margin = new Padding(5, 8, 5, 8);
            btnPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.NoAccentTextColor = Color.Empty;
            btnPesquisar.Size = new Size(100, 36);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPesquisar.UseAccentColor = false;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Enabled = false;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(528, 59);
            txtId.Margin = new Padding(3, 4, 3, 4);
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
            txtId.Size = new Size(48, 48);
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroEspecialidade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 727);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CadastroEspecialidade";
            Padding = new Padding(3, 113, 3, 5);
            Text = "CadastroEspecialidade";
            tabCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialComboBox cmbPesquisaEspecialidade;
        private ReaLTaiizor.Controls.MaterialButton btmPesquisar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEspecialidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEspecialidade1;
        private ReaLTaiizor.Controls.MaterialComboBox cboEspecialidade;
        private ReaLTaiizor.Controls.MaterialButton btnPesquisar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}