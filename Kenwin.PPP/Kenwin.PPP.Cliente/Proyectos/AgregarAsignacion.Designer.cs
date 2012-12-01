namespace Kenwin.PPP.Cliente.Proyectos
{
	partial class AgregarAsignacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAsignacion));
			this.disponiblesListBox = new System.Windows.Forms.ListBox();
			this.asignadosListBox = new System.Windows.Forms.ListBox();
			this.agregarButton = new System.Windows.Forms.Button();
			this.quitarButton = new System.Windows.Forms.Button();
			this.unidadNegocioComboBox = new System.Windows.Forms.ComboBox();
			this.paisComboBox = new System.Windows.Forms.ComboBox();
			this.idiomaComboBox = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.limpiarButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.ClearButton();
			this.buscarButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.SearchButton();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.cerrarButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.CancelButton();
			this.aceptarButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.OkButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// disponiblesListBox
			// 
			this.disponiblesListBox.FormattingEnabled = true;
			this.disponiblesListBox.Location = new System.Drawing.Point(9, 117);
			this.disponiblesListBox.Name = "disponiblesListBox";
			this.disponiblesListBox.Size = new System.Drawing.Size(220, 277);
			this.disponiblesListBox.TabIndex = 0;
			this.disponiblesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DisponiblesListBox_MouseDoubleClick);
			// 
			// asignadosListBox
			// 
			this.asignadosListBox.Location = new System.Drawing.Point(297, 117);
			this.asignadosListBox.Name = "asignadosListBox";
			this.asignadosListBox.Size = new System.Drawing.Size(220, 277);
			this.asignadosListBox.TabIndex = 1;
			this.asignadosListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AsignadosListBox_MouseDoubleClick);
			// 
			// agregarButton
			// 
			this.agregarButton.Location = new System.Drawing.Point(242, 196);
			this.agregarButton.Name = "agregarButton";
			this.agregarButton.Size = new System.Drawing.Size(42, 23);
			this.agregarButton.TabIndex = 2;
			this.agregarButton.Text = "-->";
			this.agregarButton.UseVisualStyleBackColor = true;
			this.agregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
			// 
			// quitarButton
			// 
			this.quitarButton.Location = new System.Drawing.Point(243, 225);
			this.quitarButton.Name = "quitarButton";
			this.quitarButton.Size = new System.Drawing.Size(42, 23);
			this.quitarButton.TabIndex = 2;
			this.quitarButton.Text = "<--";
			this.quitarButton.UseVisualStyleBackColor = true;
			this.quitarButton.Click += new System.EventHandler(this.QuitarButton_Click);
			// 
			// unidadNegocioComboBox
			// 
			this.unidadNegocioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.unidadNegocioComboBox.FormattingEnabled = true;
			this.unidadNegocioComboBox.Location = new System.Drawing.Point(118, 30);
			this.unidadNegocioComboBox.Name = "unidadNegocioComboBox";
			this.unidadNegocioComboBox.Size = new System.Drawing.Size(184, 21);
			this.unidadNegocioComboBox.TabIndex = 3;
			// 
			// paisComboBox
			// 
			this.paisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.paisComboBox.FormattingEnabled = true;
			this.paisComboBox.Location = new System.Drawing.Point(118, 57);
			this.paisComboBox.Name = "paisComboBox";
			this.paisComboBox.Size = new System.Drawing.Size(184, 21);
			this.paisComboBox.TabIndex = 4;
			// 
			// idiomaComboBox
			// 
			this.idiomaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.idiomaComboBox.FormattingEnabled = true;
			this.idiomaComboBox.Location = new System.Drawing.Point(118, 3);
			this.idiomaComboBox.Name = "idiomaComboBox";
			this.idiomaComboBox.Size = new System.Drawing.Size(184, 21);
			this.idiomaComboBox.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Controls.Add(this.limpiarButton);
			this.groupBox1.Controls.Add(this.buscarButton);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(520, 108);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.idiomaComboBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.unidadNegocioComboBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.paisComboBox, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 83);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 27);
			this.label1.TabIndex = 6;
			this.label1.Text = "Idioma:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 27);
			this.label2.TabIndex = 6;
			this.label2.Text = "Unidad de Negocio:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(80, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 27);
			this.label3.TabIndex = 6;
			this.label3.Text = "País:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// limpiarButton
			// 
			this.limpiarButton.ButtonType = Vemn.Fwk.Windows.Controls.VemnButton.ButtonTypeEnum.Custom;
			this.limpiarButton.Image = ((System.Drawing.Image)(resources.GetObject("limpiarButton.Image")));
			this.limpiarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.limpiarButton.Location = new System.Drawing.Point(444, 22);
			this.limpiarButton.Name = "limpiarButton";
			this.limpiarButton.Size = new System.Drawing.Size(70, 30);
			this.limpiarButton.TabIndex = 8;
			this.limpiarButton.Text = "&Limpiar";
			this.limpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.limpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
			// 
			// buscarButton
			// 
			this.buscarButton.ButtonType = Vemn.Fwk.Windows.Controls.VemnButton.ButtonTypeEnum.Custom;
			this.buscarButton.Image = ((System.Drawing.Image)(resources.GetObject("buscarButton.Image")));
			this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buscarButton.Location = new System.Drawing.Point(444, 67);
			this.buscarButton.Name = "buscarButton";
			this.buscarButton.Size = new System.Drawing.Size(70, 30);
			this.buscarButton.TabIndex = 7;
			this.buscarButton.Text = "&Buscar";
			this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.cerrarButton);
			this.flowLayoutPanel1.Controls.Add(this.aceptarButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 414);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(526, 33);
			this.flowLayoutPanel1.TabIndex = 8;
			// 
			// cerrarButton
			// 
			this.cerrarButton.ButtonType = Vemn.Fwk.Windows.Controls.VemnButton.ButtonTypeEnum.Cancel;
			this.cerrarButton.Image = ((System.Drawing.Image)(resources.GetObject("cerrarButton.Image")));
			this.cerrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cerrarButton.Location = new System.Drawing.Point(453, 3);
			this.cerrarButton.Name = "cerrarButton";
			this.cerrarButton.Size = new System.Drawing.Size(70, 30);
			this.cerrarButton.TabIndex = 0;
			this.cerrarButton.Text = "&Cerrar";
			this.cerrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
			// 
			// aceptarButton
			// 
			this.aceptarButton.Image = ((System.Drawing.Image)(resources.GetObject("aceptarButton.Image")));
			this.aceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.aceptarButton.Location = new System.Drawing.Point(377, 3);
			this.aceptarButton.Name = "aceptarButton";
			this.aceptarButton.Size = new System.Drawing.Size(70, 30);
			this.aceptarButton.TabIndex = 1;
			this.aceptarButton.Text = "&Aceptar";
			this.aceptarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.aceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.disponiblesListBox);
			this.panel1.Controls.Add(this.asignadosListBox);
			this.panel1.Controls.Add(this.agregarButton);
			this.panel1.Controls.Add(this.quitarButton);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(10, 10);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(526, 404);
			this.panel1.TabIndex = 9;
			// 
			// AgregarAsignacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 457);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AgregarAsignacion";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Asignar Consultores";
			this.Load += new System.EventHandler(this.AgregarAsignacion_Load);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox disponiblesListBox;
		private System.Windows.Forms.ListBox asignadosListBox;
		private System.Windows.Forms.Button agregarButton;
		private System.Windows.Forms.Button quitarButton;
		private System.Windows.Forms.ComboBox unidadNegocioComboBox;
		private System.Windows.Forms.ComboBox paisComboBox;
		private System.Windows.Forms.ComboBox idiomaComboBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.SearchButton buscarButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.ClearButton limpiarButton;
		private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.OkButton aceptarButton;
		private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.CancelButton cerrarButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}