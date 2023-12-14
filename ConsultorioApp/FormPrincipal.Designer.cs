namespace ConsultorioApp
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            dentistaToolStripMenuItem = new ToolStripMenuItem();
            pacienteToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            convênioToolStripMenuItem = new ToolStripMenuItem();
            especialidadeToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(2, 60);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(2, 2, 0, 2);
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(1047, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dentistaToolStripMenuItem, pacienteToolStripMenuItem, consultaToolStripMenuItem, convênioToolStripMenuItem, especialidadeToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // dentistaToolStripMenuItem
            // 
            dentistaToolStripMenuItem.Name = "dentistaToolStripMenuItem";
            dentistaToolStripMenuItem.Size = new Size(145, 22);
            dentistaToolStripMenuItem.Text = "Dentista";
            dentistaToolStripMenuItem.Click += dentistaToolStripMenuItem_Click;
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(145, 22);
            pacienteToolStripMenuItem.Text = "Paciente";
            pacienteToolStripMenuItem.Click += pacienteToolStripMenuItem_Click;
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(145, 22);
            consultaToolStripMenuItem.Text = "Consulta";
            consultaToolStripMenuItem.Click += consultaToolStripMenuItem_Click;
            // 
            // convênioToolStripMenuItem
            // 
            convênioToolStripMenuItem.Name = "convênioToolStripMenuItem";
            convênioToolStripMenuItem.Size = new Size(145, 22);
            convênioToolStripMenuItem.Text = "Convênio";
            convênioToolStripMenuItem.Click += convênioToolStripMenuItem_Click;
            // 
            // especialidadeToolStripMenuItem
            // 
            especialidadeToolStripMenuItem.Name = "especialidadeToolStripMenuItem";
            especialidadeToolStripMenuItem.Size = new Size(145, 22);
            especialidadeToolStripMenuItem.Text = "Especialidade";
            especialidadeToolStripMenuItem.Click += especialidadeToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1051, 788);
            Controls.Add(menuStrip1);
            DrawerHamburgerCursor = Cursors.Default;
            Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            MaximumSize = new Size(1646, 964);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(163, 37);
            Name = "FormPrincipal";
            Padding = new Padding(2, 60, 2, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultório";
            TopMost = true;
            TransparencyKey = Color.White;
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem dentistaToolStripMenuItem;
        private ToolStripMenuItem pacienteToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem convênioToolStripMenuItem;
        private ToolStripMenuItem especialidadeToolStripMenuItem;
    }
}