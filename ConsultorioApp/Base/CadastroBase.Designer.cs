namespace Consultorio.App.Base
{
    partial class CadastroBase
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBase));
            tabCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            panel1 = new Panel();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            tabPageConsulta = new TabPage();
            dataGridViewConsulta = new DataGridView();
            panel2 = new Panel();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            ImageList = new ImageList(components);
            tabCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            panel1.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(tabPageCadastro);
            tabCadastro.Controls.Add(tabPageConsulta);
            tabCadastro.Depth = 0;
            tabCadastro.ImageList = ImageList;
            tabCadastro.Location = new Point(6, 67);
            tabCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabCadastro.Multiline = true;
            tabCadastro.Name = "tabCadastro";
            tabCadastro.SelectedIndex = 0;
            tabCadastro.Size = new Size(524, 481);
            tabCadastro.TabIndex = 1;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(panel1);
            tabPageCadastro.ImageKey = "iconeDentista.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(516, 429);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnCancelar);
            panel1.Location = new Point(6, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 63);
            panel1.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(410, 4);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(306, 4);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.BackColor = Color.Transparent;
            tabPageConsulta.BackgroundImageLayout = ImageLayout.Stretch;
            tabPageConsulta.Controls.Add(dataGridViewConsulta);
            tabPageConsulta.Controls.Add(panel2);
            tabPageConsulta.ImageKey = "iconeProcurar.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(516, 446);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Pesquisa";
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Location = new Point(7, 183);
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.RowTemplate.Height = 25;
            dataGridViewConsulta.Size = new Size(503, 179);
            dataGridViewConsulta.TabIndex = 5;
            dataGridViewConsulta.CellMouseDoubleClick += dataGridViewConsulta_CellMouseDoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNovo);
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(btnEditar);
            panel2.Location = new Point(9, 368);
            panel2.Name = "panel2";
            panel2.Size = new Size(501, 55);
            panel2.TabIndex = 4;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.BackColor = Color.Transparent;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default;
            btnNovo.Location = new Point(266, 13);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(417, 13);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(338, 13);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // ImageList
            // 
            ImageList.ColorDepth = ColorDepth.Depth32Bit;
            ImageList.ImageStream = (ImageListStreamer)resources.GetObject("ImageList.ImageStream");
            ImageList.TransparentColor = Color.Transparent;
            ImageList.Images.SetKeyName(0, "iconeProcurar.png");
            ImageList.Images.SetKeyName(1, "iconeDentista.png");
            ImageList.Images.SetKeyName(2, "iconeCadeira.png");
            ImageList.Images.SetKeyName(3, "");
            ImageList.Images.SetKeyName(4, "iconeNovo.png");
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 563);
            Controls.Add(tabCadastro);
            DrawerTabControl = tabCadastro;
            Name = "CadastroBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroBase";
            TransparencyKey = Color.Teal;
            tabCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected ReaLTaiizor.Controls.MaterialTabControl tabCadastro;
        private ImageList ImageList;
        protected TabPage tabPageCadastro;
        protected Panel panel1;
        protected Panel panel2;
        protected TabPage tabPageConsulta;
        protected ReaLTaiizor.Controls.MaterialButton btnNovo;
        protected DataGridView dataGridViewConsulta;
        protected ReaLTaiizor.Controls.MaterialButton btnEditar;
        protected ReaLTaiizor.Controls.MaterialButton btnExcluir;
        protected ReaLTaiizor.Controls.MaterialButton btnCancelar;
        protected ReaLTaiizor.Controls.MaterialButton btnSalvar;
    }
}