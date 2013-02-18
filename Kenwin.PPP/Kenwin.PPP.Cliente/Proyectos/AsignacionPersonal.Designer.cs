namespace Kenwin.PPP.Cliente.Proyectos
{
	partial class AsignacionPersonal
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.asignarButton = new System.Windows.Forms.Button();
			this.borrarButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grillaC1FlexGrid)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grillaC1FlexGrid
			// 
			this.grillaC1FlexGrid.AutoGenerateColumns = false;
			this.grillaC1FlexGrid.AutoResize = false;
			this.grillaC1FlexGrid.ColumnInfo = "1,1,0,0,0,85,Columns:0{Width:20;}\t";
			this.grillaC1FlexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grillaC1FlexGrid.Location = new System.Drawing.Point(0, 0);
			this.grillaC1FlexGrid.Name = "grillaC1FlexGrid";
			this.grillaC1FlexGrid.Rows.Count = 1;
			this.grillaC1FlexGrid.Rows.DefaultSize = 17;
			this.grillaC1FlexGrid.Size = new System.Drawing.Size(602, 429);
			this.grillaC1FlexGrid.TabIndex = 0;
			this.grillaC1FlexGrid.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.GrillaC1FlexGrid_AfterEdit);
			this.grillaC1FlexGrid.ValidateEdit += new C1.Win.C1FlexGrid.ValidateEditEventHandler(this.GrillaC1FlexGrid_ValidateEdit);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.asignarButton);
			this.flowLayoutPanel1.Controls.Add(this.borrarButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(602, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(101, 429);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// asignarButton
			// 
			this.asignarButton.Location = new System.Drawing.Point(13, 13);
			this.asignarButton.Name = "asignarButton";
			this.asignarButton.Size = new System.Drawing.Size(75, 23);
			this.asignarButton.TabIndex = 0;
			this.asignarButton.Text = "Asignar";
			this.asignarButton.UseVisualStyleBackColor = true;
			this.asignarButton.Click += new System.EventHandler(this.AsignarButton_Click);
			// 
			// borrarButton
			// 
			this.borrarButton.Location = new System.Drawing.Point(13, 42);
			this.borrarButton.Name = "borrarButton";
			this.borrarButton.Size = new System.Drawing.Size(75, 23);
			this.borrarButton.TabIndex = 1;
			this.borrarButton.Text = "Borrar";
			this.borrarButton.UseVisualStyleBackColor = true;
			this.borrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
			// 
			// AsignacionPersonal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grillaC1FlexGrid);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "AsignacionPersonal";
			this.Size = new System.Drawing.Size(703, 429);
			this.Load += new System.EventHandler(this.AsignacionPersonal_Load);
			((System.ComponentModel.ISupportInitialize)(this.grillaC1FlexGrid)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Kenwin.PPP.Cliente.Comun.Controles.PPPC1FlexGrid grillaC1FlexGrid;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button asignarButton;
		private System.Windows.Forms.Button borrarButton;
	}
}
