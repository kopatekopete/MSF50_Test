namespace Kenwin.PPP.Cliente.ABMs
{
	partial class Prueba
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
			this.components = new System.ComponentModel.Container();
			this.grilla = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.getDataButton = new System.Windows.Forms.Button();
			this._bs = new System.Windows.Forms.BindingSource(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.asignacionSemanal1 = new Kenwin.PPP.Cliente.Proyectos.AsignacionSemanal();
			((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._bs)).BeginInit();
			this.SuspendLayout();
			// 
			// grilla
			// 
			this.grilla.ColumnInfo = "0,0,0,0,0,85,Columns:";
			this.grilla.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
			this.grilla.Location = new System.Drawing.Point(998, 8);
			this.grilla.Name = "grilla";
			this.grilla.Rows.Count = 1;
			this.grilla.Rows.DefaultSize = 17;
			this.grilla.Size = new System.Drawing.Size(390, 621);
			this.grilla.TabIndex = 0;
			this.grilla.StartEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.grilla_StartEdit);
			this.grilla.AfterDataRefresh += new System.ComponentModel.ListChangedEventHandler(this.grilla_AfterDataRefresh);
			this.grilla.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.grilla_OwnerDrawCell);
			// 
			// getDataButton
			// 
			this.getDataButton.Location = new System.Drawing.Point(1370, 12);
			this.getDataButton.Name = "getDataButton";
			this.getDataButton.Size = new System.Drawing.Size(75, 23);
			this.getDataButton.TabIndex = 1;
			this.getDataButton.Text = "Get Data";
			this.getDataButton.UseVisualStyleBackColor = true;
			this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(917, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// asignacionSemanal1
			// 
			this.asignacionSemanal1.FechaInicio = new System.DateTime(2010, 9, 13, 0, 0, 0, 0);
			this.asignacionSemanal1.Location = new System.Drawing.Point(12, 12);
			this.asignacionSemanal1.Name = "asignacionSemanal1";
			this.asignacionSemanal1.Size = new System.Drawing.Size(899, 625);
			this.asignacionSemanal1.TabIndex = 2;
			// 
			// Prueba
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1181, 645);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.asignacionSemanal1);
			this.Controls.Add(this.getDataButton);
			this.Controls.Add(this.grilla);
			this.Name = "Prueba";
			this.Text = "Prueba";
			((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._bs)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private C1.Win.C1FlexGrid.C1FlexGrid grilla;
		private System.Windows.Forms.Button getDataButton;
		private System.Windows.Forms.BindingSource _bs;
		private Proyectos.AsignacionSemanal asignacionSemanal1;
		private System.Windows.Forms.Button button1;
	}
}