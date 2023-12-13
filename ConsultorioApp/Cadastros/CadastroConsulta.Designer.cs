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
            cboNomePaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            cboNomeDentista = new ReaLTaiizor.Controls.MaterialComboBox();
            txtValorConsulta = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel3 = new Panel();
            chkPesquisarData = new CheckBox();
            label2 = new Label();
            dtpInicio = new DateTimePicker();
            chkTodos = new CheckBox();
            btmPesquisar = new ReaLTaiizor.Controls.MaterialButton();
            cboPesquisaNomePaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            cboPesquisaNomeDentista = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label1 = new Label();
            dtpDataConsulta = new DateTimePicker();
            label4 = new Label();
            chkDentista = new CheckBox();
            chkPaciente = new CheckBox();
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
            tabCadastro.Dock = DockStyle.Fill;
            tabCadastro.Location = new Point(3, 64);
            tabCadastro.Size = new Size(544, 471);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(label4);
            tabPageCadastro.Controls.Add(dtpDataConsulta);
            tabPageCadastro.Controls.Add(label1);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtValorConsulta);
            tabPageCadastro.Controls.Add(cboNomeDentista);
            tabPageCadastro.Controls.Add(cboNomePaciente);
            tabPageCadastro.Size = new Size(536, 436);
            tabPageCadastro.Controls.SetChildIndex(panel1, 0);
            tabPageCadastro.Controls.SetChildIndex(cboNomePaciente, 0);
            tabPageCadastro.Controls.SetChildIndex(cboNomeDentista, 0);
            tabPageCadastro.Controls.SetChildIndex(txtValorConsulta, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(label1, 0);
            tabPageCadastro.Controls.SetChildIndex(dtpDataConsulta, 0);
            tabPageCadastro.Controls.SetChildIndex(label4, 0);
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 357);
            panel1.Size = new Size(510, 63);
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 368);
            panel2.Size = new Size(527, 65);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(panel3);
            tabPageConsulta.Size = new Size(536, 436);
            tabPageConsulta.Controls.SetChildIndex(panel2, 0);
            tabPageConsulta.Controls.SetChildIndex(panel3, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(288, 4);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(413, 4);
            // 
            // cboNomePaciente
            // 
            cboNomePaciente.AutoResize = false;
            cboNomePaciente.BackColor = Color.FromArgb(255, 255, 255);
            cboNomePaciente.Depth = 0;
            cboNomePaciente.DrawMode = DrawMode.OwnerDrawVariable;
            cboNomePaciente.DropDownHeight = 174;
            cboNomePaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNomePaciente.DropDownWidth = 121;
            cboNomePaciente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboNomePaciente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNomePaciente.FormattingEnabled = true;
            cboNomePaciente.Hint = "Paciente";
            cboNomePaciente.IntegralHeight = false;
            cboNomePaciente.ItemHeight = 43;
            cboNomePaciente.Location = new Point(15, 84);
            cboNomePaciente.MaxDropDownItems = 4;
            cboNomePaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboNomePaciente.Name = "cboNomePaciente";
            cboNomePaciente.Size = new Size(477, 49);
            cboNomePaciente.StartIndex = 0;
            cboNomePaciente.TabIndex = 5;
            // 
            // cboNomeDentista
            // 
            cboNomeDentista.AutoResize = false;
            cboNomeDentista.BackColor = Color.FromArgb(255, 255, 255);
            cboNomeDentista.Depth = 0;
            cboNomeDentista.DrawMode = DrawMode.OwnerDrawVariable;
            cboNomeDentista.DropDownHeight = 174;
            cboNomeDentista.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNomeDentista.DropDownWidth = 121;
            cboNomeDentista.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboNomeDentista.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNomeDentista.FormattingEnabled = true;
            cboNomeDentista.Hint = "Dentista";
            cboNomeDentista.IntegralHeight = false;
            cboNomeDentista.ItemHeight = 43;
            cboNomeDentista.Location = new Point(15, 19);
            cboNomeDentista.MaxDropDownItems = 4;
            cboNomeDentista.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboNomeDentista.Name = "cboNomeDentista";
            cboNomeDentista.Size = new Size(422, 49);
            cboNomeDentista.StartIndex = 0;
            cboNomeDentista.TabIndex = 6;
            // 
            // txtValorConsulta
            // 
            txtValorConsulta.AnimateReadOnly = false;
            txtValorConsulta.AutoCompleteMode = AutoCompleteMode.None;
            txtValorConsulta.AutoCompleteSource = AutoCompleteSource.None;
            txtValorConsulta.BackgroundImageLayout = ImageLayout.None;
            txtValorConsulta.CharacterCasing = CharacterCasing.Normal;
            txtValorConsulta.Depth = 0;
            txtValorConsulta.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValorConsulta.HideSelection = true;
            txtValorConsulta.Hint = "Valor Consulta";
            txtValorConsulta.LeadingIcon = null;
            txtValorConsulta.Location = new Point(56, 148);
            txtValorConsulta.MaxLength = 32767;
            txtValorConsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValorConsulta.Name = "txtValorConsulta";
            txtValorConsulta.PasswordChar = '\0';
            txtValorConsulta.PrefixSuffixText = null;
            txtValorConsulta.ReadOnly = false;
            txtValorConsulta.RightToLeft = RightToLeft.No;
            txtValorConsulta.SelectedText = "";
            txtValorConsulta.SelectionLength = 0;
            txtValorConsulta.SelectionStart = 0;
            txtValorConsulta.ShortcutsEnabled = true;
            txtValorConsulta.Size = new Size(309, 48);
            txtValorConsulta.TabIndex = 7;
            txtValorConsulta.TabStop = false;
            txtValorConsulta.Tag = "";
            txtValorConsulta.TextAlign = HorizontalAlignment.Left;
            txtValorConsulta.TrailingIcon = null;
            txtValorConsulta.UseSystemPasswordChar = false;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.AutoCompleteMode = AutoCompleteMode.None;
            txtDescricao.AutoCompleteSource = AutoCompleteSource.None;
            txtDescricao.BackgroundImageLayout = ImageLayout.None;
            txtDescricao.CharacterCasing = CharacterCasing.Normal;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.HideSelection = true;
            txtDescricao.Hint = "Descrição";
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(15, 212);
            txtDescricao.MaxLength = 32767;
            txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.PrefixSuffixText = null;
            txtDescricao.ReadOnly = false;
            txtDescricao.RightToLeft = RightToLeft.No;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.ShortcutsEnabled = true;
            txtDescricao.Size = new Size(477, 48);
            txtDescricao.TabIndex = 9;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(chkPaciente);
            panel3.Controls.Add(chkDentista);
            panel3.Controls.Add(chkPesquisarData);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dtpInicio);
            panel3.Controls.Add(chkTodos);
            panel3.Controls.Add(btmPesquisar);
            panel3.Controls.Add(cboPesquisaNomePaciente);
            panel3.Controls.Add(cboPesquisaNomeDentista);
            panel3.Location = new Point(9, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(507, 179);
            panel3.TabIndex = 5;
            // 
            // chkPesquisarData
            // 
            chkPesquisarData.AutoSize = true;
            chkPesquisarData.Location = new Point(12, 125);
            chkPesquisarData.Name = "chkPesquisarData";
            chkPesquisarData.Size = new Size(123, 19);
            chkPesquisarData.TabIndex = 19;
            chkPesquisarData.Text = "Pesquisar por data";
            chkPesquisarData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(26, 4);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 17;
            label2.Text = "Início";
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarMonthBackground = SystemColors.ScrollBar;
            dtpInicio.CalendarTitleBackColor = SystemColors.Highlight;
            dtpInicio.CalendarTrailingForeColor = SystemColors.ControlDark;
            dtpInicio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(11, 35);
            dtpInicio.MinDate = new DateTime(1903, 1, 1, 0, 0, 0, 0);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(97, 27);
            dtpInicio.TabIndex = 15;
            // 
            // chkTodos
            // 
            chkTodos.AutoSize = true;
            chkTodos.Location = new Point(11, 148);
            chkTodos.Name = "chkTodos";
            chkTodos.Size = new Size(179, 19);
            chkTodos.TabIndex = 14;
            chkTodos.Text = "Selecionar todas as consultas";
            chkTodos.UseVisualStyleBackColor = true;
            // 
            // btmPesquisar
            // 
            btmPesquisar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btmPesquisar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btmPesquisar.Depth = 0;
            btmPesquisar.HighEmphasis = true;
            btmPesquisar.Icon = null;
            btmPesquisar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btmPesquisar.Location = new Point(359, 128);
            btmPesquisar.Margin = new Padding(4, 6, 4, 6);
            btmPesquisar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btmPesquisar.Name = "btmPesquisar";
            btmPesquisar.NoAccentTextColor = Color.Empty;
            btmPesquisar.Size = new Size(100, 36);
            btmPesquisar.TabIndex = 13;
            btmPesquisar.Text = "Pesquisar";
            btmPesquisar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btmPesquisar.UseAccentColor = false;
            btmPesquisar.UseVisualStyleBackColor = true;
            // 
            // cboPesquisaNomePaciente
            // 
            cboPesquisaNomePaciente.AutoResize = false;
            cboPesquisaNomePaciente.BackColor = Color.FromArgb(255, 255, 255);
            cboPesquisaNomePaciente.Depth = 0;
            cboPesquisaNomePaciente.DrawMode = DrawMode.OwnerDrawVariable;
            cboPesquisaNomePaciente.DropDownHeight = 174;
            cboPesquisaNomePaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPesquisaNomePaciente.DropDownWidth = 121;
            cboPesquisaNomePaciente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPesquisaNomePaciente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPesquisaNomePaciente.FormattingEnabled = true;
            cboPesquisaNomePaciente.Hint = "Paciente";
            cboPesquisaNomePaciente.IntegralHeight = false;
            cboPesquisaNomePaciente.ItemHeight = 43;
            cboPesquisaNomePaciente.Location = new Point(12, 70);
            cboPesquisaNomePaciente.MaxDropDownItems = 4;
            cboPesquisaNomePaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPesquisaNomePaciente.Name = "cboPesquisaNomePaciente";
            cboPesquisaNomePaciente.Size = new Size(477, 49);
            cboPesquisaNomePaciente.StartIndex = 0;
            cboPesquisaNomePaciente.TabIndex = 12;
            // 
            // cboPesquisaNomeDentista
            // 
            cboPesquisaNomeDentista.AutoResize = false;
            cboPesquisaNomeDentista.BackColor = Color.FromArgb(255, 255, 255);
            cboPesquisaNomeDentista.Depth = 0;
            cboPesquisaNomeDentista.DrawMode = DrawMode.OwnerDrawVariable;
            cboPesquisaNomeDentista.DropDownHeight = 174;
            cboPesquisaNomeDentista.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPesquisaNomeDentista.DropDownWidth = 121;
            cboPesquisaNomeDentista.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPesquisaNomeDentista.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPesquisaNomeDentista.FormattingEnabled = true;
            cboPesquisaNomeDentista.Hint = "Dentista";
            cboPesquisaNomeDentista.IntegralHeight = false;
            cboPesquisaNomeDentista.ItemHeight = 43;
            cboPesquisaNomeDentista.Location = new Point(114, 15);
            cboPesquisaNomeDentista.MaxDropDownItems = 4;
            cboPesquisaNomeDentista.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPesquisaNomeDentista.Name = "cboPesquisaNomeDentista";
            cboPesquisaNomeDentista.Size = new Size(375, 49);
            cboPesquisaNomeDentista.StartIndex = 0;
            cboPesquisaNomeDentista.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(443, 19);
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
            txtId.Size = new Size(47, 48);
            txtId.TabIndex = 10;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(15, 158);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 11;
            label1.Text = "R$";
            // 
            // dtpDataConsulta
            // 
            dtpDataConsulta.CalendarMonthBackground = SystemColors.ScrollBar;
            dtpDataConsulta.CalendarTitleBackColor = SystemColors.Highlight;
            dtpDataConsulta.CalendarTrailingForeColor = SystemColors.ControlDark;
            dtpDataConsulta.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataConsulta.Format = DateTimePickerFormat.Short;
            dtpDataConsulta.Location = new Point(371, 169);
            dtpDataConsulta.MinDate = new DateTime(1903, 1, 1, 0, 0, 0, 0);
            dtpDataConsulta.Name = "dtpDataConsulta";
            dtpDataConsulta.Size = new Size(121, 27);
            dtpDataConsulta.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(404, 145);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 18;
            label4.Text = "Data ";
            // 
            // chkDentista
            // 
            chkDentista.AutoSize = true;
            chkDentista.Location = new Point(141, 125);
            chkDentista.Name = "chkDentista";
            chkDentista.Size = new Size(142, 19);
            chkDentista.TabIndex = 20;
            chkDentista.Text = "Pesquisar por dentista";
            chkDentista.UseVisualStyleBackColor = true;
            // 
            // chkPaciente
            // 
            chkPaciente.AutoSize = true;
            chkPaciente.Location = new Point(196, 148);
            chkPaciente.Name = "chkPaciente";
            chkPaciente.Size = new Size(145, 19);
            chkPaciente.TabIndex = 21;
            chkPaciente.Text = "Pesquisar por paciente";
            chkPaciente.UseVisualStyleBackColor = true;
            // 
            // CadastroConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 538);
            Location = new Point(0, 0);
            Name = "CadastroConsulta";
            Text = "CadastroConsulta";
            tabCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboNomeDentista;
        private ReaLTaiizor.Controls.MaterialComboBox cboNomePaciente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorConsulta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialComboBox cboPesquisaNomePaciente;
        private ReaLTaiizor.Controls.MaterialComboBox cboPesquisaNomeDentista;
        private ReaLTaiizor.Controls.MaterialButton btmPesquisar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private Label label1;
        private CheckBox chkTodos;
        private DateTimePicker dtpInicio;
        private Label label2;
        private DateTimePicker dtpDataConsulta;
        private Label label4;
        private CheckBox chkPesquisarData;
        private CheckBox chkPaciente;
        private CheckBox chkDentista;
    }
}