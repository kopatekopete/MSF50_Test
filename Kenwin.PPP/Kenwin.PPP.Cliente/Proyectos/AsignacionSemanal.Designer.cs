namespace Kenwin.PPP.Cliente.Proyectos
{
	partial class AsignacionSemanal
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grillaC1FlexGrid = new Kenwin.PPP.Cliente.Comun.Controles.PPPC1FlexGrid();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.semanaAnteriorButton = new System.Windows.Forms.Button();
			this.paginaSemanasAnteriorButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.semanaSiguienteButton = new System.Windows.Forms.Button();
			this.paginaSemanasSiguienteButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.semanaActualButton = new System.Windows.Forms.Button();
			this.semanaInicioProyectoButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grillaC1FlexGrid)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// grillaC1FlexGrid
			// 
			this.grillaC1FlexGrid.ColumnInfo = "1,1,0,0,0,85,Columns:0{Width:30;}\t";
			this.grillaC1FlexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grillaC1FlexGrid.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
			this.grillaC1FlexGrid.Location = new System.Drawing.Point(0, 35);
			this.grillaC1FlexGrid.Name = "grillaC1FlexGrid";
			this.grillaC1FlexGrid.Rows.Count = 1;
			this.grillaC1FlexGrid.Rows.DefaultSize = 17;
			this.grillaC1FlexGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.grillaC1FlexGrid.Size = new System.Drawing.Size(857, 514);
			this.grillaC1FlexGrid.TabIndex = 0;
			this.grillaC1FlexGrid.StartEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.GrillaC1FlexGrid_StartEdit);
			this.grillaC1FlexGrid.AfterDataRefresh += new System.ComponentModel.ListChangedEventHandler(this.GrillaC1FlexGrid_AfterDataRefresh);
			this.grillaC1FlexGrid.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.GrillaC1FlexGrid_OwnerDrawCell);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 35);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.semanaAnteriorButton);
			this.panel1.Controls.Add(this.paginaSemanasAnteriorButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(182, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(77, 29);
			this.panel1.TabIndex = 0;
			// 
			// semanaAnteriorButton
			// 
			this.semanaAnteriorButton.Location = new System.Drawing.Point(49, 3);
			this.semanaAnteriorButton.Name = "semanaAnteriorButton";
			this.semanaAnteriorButton.Size = new System.Drawing.Size(25, 23);
			this.semanaAnteriorButton.TabIndex = 0;
			this.semanaAnteriorButton.Text = "<";
			this.semanaAnteriorButton.UseVisualStyleBackColor = true;
			this.semanaAnteriorButton.Click += new System.EventHandler(this.SemanaAnteriorButton_Click);
			// 
			// paginaSemanasAnteriorButton
			// 
			this.paginaSemanasAnteriorButton.Location = new System.Drawing.Point(3, 3);
			this.paginaSemanasAnteriorButton.Name = "paginaSemanasAnteriorButton";
			this.paginaSemanasAnteriorButton.Size = new System.Drawing.Size(40, 23);
			this.paginaSemanasAnteriorButton.TabIndex = 0;
			this.paginaSemanasAnteriorButton.Text = "<<";
			this.paginaSemanasAnteriorButton.UseVisualStyleBackColor = true;
			this.paginaSemanasAnteriorButton.Click += new System.EventHandler(this.PaginaSemanasAnteriorButton_Click);
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.semanaSiguienteButton);
			this.panel2.Controls.Add(this.paginaSemanasSiguienteButton);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(773, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(81, 29);
			this.panel2.TabIndex = 1;
			// 
			// semanaSiguienteButton
			// 
			this.semanaSiguienteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.semanaSiguienteButton.Location = new System.Drawing.Point(7, 3);
			this.semanaSiguienteButton.Name = "semanaSiguienteButton";
			this.semanaSiguienteButton.Size = new System.Drawing.Size(25, 23);
			this.semanaSiguienteButton.TabIndex = 0;
			this.semanaSiguienteButton.Text = ">";
			this.semanaSiguienteButton.UseVisualStyleBackColor = true;
			this.semanaSiguienteButton.Click += new System.EventHandler(this.SemanaSiguienteButton_Click);
			// 
			// paginaSemanasSiguienteButton
			// 
			this.paginaSemanasSiguienteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.paginaSemanasSiguienteButton.Location = new System.Drawing.Point(38, 3);
			this.paginaSemanasSiguienteButton.Name = "paginaSemanasSiguienteButton";
			this.paginaSemanasSiguienteButton.Size = new System.Drawing.Size(40, 23);
			this.paginaSemanasSiguienteButton.TabIndex = 0;
			this.paginaSemanasSiguienteButton.Text = ">>";
			this.paginaSemanasSiguienteButton.UseVisualStyleBackColor = true;
			this.paginaSemanasSiguienteButton.Click += new System.EventHandler(this.PaginaSemanasSiguienteButton_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.semanaActualButton, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.semanaInicioProyectoButton, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(265, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(502, 29);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// semanaActualButton
			// 
			this.semanaActualButton.Location = new System.Drawing.Point(254, 3);
			this.semanaActualButton.Name = "semanaActualButton";
			this.semanaActualButton.Size = new System.Drawing.Size(100, 23);
			this.semanaActualButton.TabIndex = 0;
			this.semanaActualButton.Text = "Semana Actual";
			this.semanaActualButton.UseVisualStyleBackColor = true;
			this.semanaActualButton.Click += new System.EventHandler(this.SemanaActualButton_Click);
			// 
			// semanaInicioProyectoButton
			// 
			this.semanaInicioProyectoButton.Enabled = false;
			this.semanaInicioProyectoButton.Location = new System.Drawing.Point(148, 3);
			this.semanaInicioProyectoButton.Name = "semanaInicioProyectoButton";
			this.semanaInicioProyectoButton.Size = new System.Drawing.Size(100, 23);
			this.semanaInicioProyectoButton.TabIndex = 0;
			this.semanaInicioProyectoButton.Text = "Inicio Proyecto";
			this.semanaInicioProyectoButton.UseVisualStyleBackColor = true;
			this.semanaInicioProyectoButton.Click += new System.EventHandler(this.SemanaInicioProyectoButton_Click);
			// 
			// AsignacionSemanal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.grillaC1FlexGrid);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "AsignacionSemanal";
			this.Size = new System.Drawing.Size(857, 549);
			this.Load += new System.EventHandler(this.AsignacionSemanal_Load);
			((System.ComponentModel.ISupportInitialize)(this.grillaC1FlexGrid)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Comun.Controles.PPPC1FlexGrid grillaC1FlexGrid;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button semanaAnteriorButton;
		private System.Windows.Forms.Button paginaSemanasAnteriorButton;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button semanaSiguienteButton;
		private System.Windows.Forms.Button paginaSemanasSiguienteButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button semanaActualButton;
		private System.Windows.Forms.Button semanaInicioProyectoButton;
	}
}
