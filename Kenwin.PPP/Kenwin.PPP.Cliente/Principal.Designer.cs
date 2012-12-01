namespace Kenwin.PPP.Cliente
{
    partial class Principal
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
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vacioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.desdeTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abmClienteTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.abmTarifaTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.abmIdiomaTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.abmPaisTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.abmUnidadNegocioTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.abmRolTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.abmPersonaTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.pruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.administraciónToolStripMenuItem,
            this.toolStripMenuItem2});
			this.mainMenuStrip.Location = new System.Drawing.Point(5, 5);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(1176, 24);
			this.mainMenuStrip.TabIndex = 2;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.buscarToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
			this.toolStripMenuItem1.Text = "Proyectos";
			// 
			// nuevoToolStripMenuItem
			// 
			this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacioToolStripMenuItem,
            this.desdeTemplateToolStripMenuItem});
			this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.nuevoToolStripMenuItem.Text = "Nuevo";
			// 
			// vacioToolStripMenuItem
			// 
			this.vacioToolStripMenuItem.Name = "vacioToolStripMenuItem";
			this.vacioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.vacioToolStripMenuItem.Text = "Vacío";
			this.vacioToolStripMenuItem.Click += new System.EventHandler(this.VacioToolStripMenuItem_Click);
			// 
			// desdeTemplateToolStripMenuItem
			// 
			this.desdeTemplateToolStripMenuItem.Enabled = false;
			this.desdeTemplateToolStripMenuItem.Name = "desdeTemplateToolStripMenuItem";
			this.desdeTemplateToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.desdeTemplateToolStripMenuItem.Text = "Desde Template";
			this.desdeTemplateToolStripMenuItem.Click += new System.EventHandler(this.DesdeTemplateToolStripMenuItem_Click);
			// 
			// buscarToolStripMenuItem
			// 
			this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
			this.buscarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.buscarToolStripMenuItem.Text = "Buscar";
			this.buscarToolStripMenuItem.Click += new System.EventHandler(this.BuscarToolStripMenuItem_Click);
			// 
			// administraciónToolStripMenuItem
			// 
			this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abmClienteTSMI,
            this.abmTarifaTSMI,
            this.abmIdiomaTSMI,
            this.abmPaisTSMI,
            this.abmUnidadNegocioTSMI,
            this.abmRolTSMI,
            this.abmPersonaTSMI,
            this.toolStripMenuItem3,
            this.pruebaToolStripMenuItem});
			this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
			this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
			this.administraciónToolStripMenuItem.Text = "Administración";
			// 
			// abmClienteTSMI
			// 
			this.abmClienteTSMI.Name = "abmClienteTSMI";
			this.abmClienteTSMI.Size = new System.Drawing.Size(205, 22);
			this.abmClienteTSMI.Text = "ABM Cliente";
			this.abmClienteTSMI.Click += new System.EventHandler(this.AbmClienteTSMI_Click);
			// 
			// abmTarifaTSMI
			// 
			this.abmTarifaTSMI.Name = "abmTarifaTSMI";
			this.abmTarifaTSMI.Size = new System.Drawing.Size(205, 22);
			this.abmTarifaTSMI.Text = "ABM Tarifa";
			this.abmTarifaTSMI.Click += new System.EventHandler(this.AbmTarifaTSMI_Click);
			// 
			// abmIdiomaTSMI
			// 
			this.abmIdiomaTSMI.Name = "abmIdiomaTSMI";
			this.abmIdiomaTSMI.Size = new System.Drawing.Size(205, 22);
			this.abmIdiomaTSMI.Text = "ABM Idioma";
			this.abmIdiomaTSMI.Click += new System.EventHandler(this.AbmIdiomaTSMI_Click);
			// 
			// abmPaisTSMI
			// 
			this.abmPaisTSMI.Name = "abmPaisTSMI";
			this.abmPaisTSMI.Size = new System.Drawing.Size(205, 22);
			this.abmPaisTSMI.Text = "ABM País";
			this.abmPaisTSMI.Click += new System.EventHandler(this.AbmPaisTSMI_Click);
			// 
			// abmUnidadNegocioTSMI
			// 
			this.abmUnidadNegocioTSMI.Name = "abmUnidadNegocioTSMI";
			this.abmUnidadNegocioTSMI.Size = new System.Drawing.Size(205, 22);
			this.abmUnidadNegocioTSMI.Text = "ABM Unidad de Negocio";
			this.abmUnidadNegocioTSMI.Click += new System.EventHandler(this.AbmUnidadNegocioTSMI);
			// 
			// abmRolTSMI
			// 
			this.abmRolTSMI.Name = "abmRolTSMI";
			this.abmRolTSMI.Size = new System.Drawing.Size(205, 22);
			this.abmRolTSMI.Text = "ABM Rol";
			this.abmRolTSMI.Click += new System.EventHandler(this.AbmRolTSMI_Click);
			// 
			// abmPersonaTSMI
			// 
			this.abmPersonaTSMI.Name = "abmPersonaTSMI";
			this.abmPersonaTSMI.Size = new System.Drawing.Size(205, 22);
			this.abmPersonaTSMI.Text = "ABM Persona";
			this.abmPersonaTSMI.Click += new System.EventHandler(this.AbmPersonaTSMI_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(202, 6);
			// 
			// pruebaToolStripMenuItem
			// 
			this.pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
			this.pruebaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.pruebaToolStripMenuItem.Text = "Prueba";
			this.pruebaToolStripMenuItem.Click += new System.EventHandler(this.pruebaToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(67, 20);
			this.toolStripMenuItem2.Text = "Ventanas";
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1186, 750);
			this.Controls.Add(this.mainMenuStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "Principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kenwin PPP v1.08.100908";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vacioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem desdeTemplateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abmClienteTSMI;
		private System.Windows.Forms.ToolStripMenuItem abmTarifaTSMI;
		private System.Windows.Forms.ToolStripMenuItem abmIdiomaTSMI;
		private System.Windows.Forms.ToolStripMenuItem abmPaisTSMI;
		private System.Windows.Forms.ToolStripMenuItem abmUnidadNegocioTSMI;
		private System.Windows.Forms.ToolStripMenuItem abmRolTSMI;
		private System.Windows.Forms.ToolStripMenuItem abmPersonaTSMI;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem pruebaToolStripMenuItem;

    }
}

