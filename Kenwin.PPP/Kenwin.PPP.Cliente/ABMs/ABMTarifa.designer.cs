namespace Kenwin.PPP.Cliente.ABMs
{
    partial class ABMTarifa
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.paisLbl = new System.Windows.Forms.Label();
			this.limpiarPaisButton = new System.Windows.Forms.Button();
			this.EsRateFijoCB = new System.Windows.Forms.CheckBox();
			this.esRateFijoLbl = new System.Windows.Forms.Label();
			this.monedaLbl = new System.Windows.Forms.Label();
			this.actividadLbl = new System.Windows.Forms.Label();
			this.clienteLbl = new System.Windows.Forms.Label();
			this.fKBoxActividad = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.ActividadFKBox();
			this.fKBoxMoneda = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.MonedaFKBox();
			this.fKBoxPais = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.PaisFKBox();
			this.fKBoxCliente = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.ClienteFKBox();
			this.umLbl = new System.Windows.Forms.Label();
			this.fKBoxUM = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.UnidadMedidaFKBox();
			this.cantidadTopeLbl = new System.Windows.Forms.Label();
			this.rateLbl = new System.Windows.Forms.Label();
			this.RateDB = new Vemn.Fwk.Windows.Controls.DecimalBox();
			this.limpiarClienteB = new System.Windows.Forms.Button();
			this.CantidadTopeIB = new C1.Win.C1Input.C1NumericEdit();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this._bs)).BeginInit();
			this.groupDetail.SuspendLayout();
			this.CrudTab.SuspendLayout();
			this.TableTab.SuspendLayout();
			this.DetailTab.SuspendLayout();
			this.panelContainerDetail.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgVemn)).BeginInit();
			this.panelContainerButton.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CantidadTopeIB)).BeginInit();
			this.SuspendLayout();
			// 
			// groupDetail
			// 
			this.groupDetail.Size = new System.Drawing.Size(794, 305);
			// 
			// CrudTab
			// 
			this.CrudTab.Size = new System.Drawing.Size(808, 337);
			// 
			// TableTab
			// 
			this.TableTab.Size = new System.Drawing.Size(800, 311);
			// 
			// DetailTab
			// 
			this.DetailTab.Size = new System.Drawing.Size(800, 311);
			// 
			// panelContainerDetail
			// 
			this.panelContainerDetail.Controls.Add(this.tableLayoutPanel1);
			this.panelContainerDetail.Size = new System.Drawing.Size(788, 246);
			// 
			// title
			// 
			this.title.SubTitle = "Altas Bajas y Modificaciones de Tarifa";
			this.title.Title = "Tarifa";
			// 
			// dgVemn
			// 
			this.dgVemn.AutoGenerateColumns = false;
			this.dgVemn.Rows.Count = 1;
			this.dgVemn.Rows.DefaultSize = 17;
			this.dgVemn.Size = new System.Drawing.Size(794, 280);
			// 
			// panelContainerButton
			// 
			this.panelContainerButton.Location = new System.Drawing.Point(3, 262);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.paisLbl, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.limpiarPaisButton, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.EsRateFijoCB, 1, 9);
			this.tableLayoutPanel1.Controls.Add(this.esRateFijoLbl, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.monedaLbl, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.actividadLbl, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.clienteLbl, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.fKBoxActividad, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.fKBoxMoneda, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.fKBoxPais, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.fKBoxCliente, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.umLbl, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.fKBoxUM, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.cantidadTopeLbl, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.rateLbl, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.RateDB, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.limpiarClienteB, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.CantidadTopeIB, 1, 6);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 13);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 11;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 226);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// paisLbl
			// 
			this.paisLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.paisLbl.AutoSize = true;
			this.paisLbl.Location = new System.Drawing.Point(68, 68);
			this.paisLbl.Name = "paisLbl";
			this.paisLbl.Size = new System.Drawing.Size(29, 13);
			this.paisLbl.TabIndex = 2;
			this.paisLbl.Text = "País";
			// 
			// limpiarPaisButton
			// 
			this.limpiarPaisButton.Image = global::Kenwin.PPP.Cliente.Properties.Resources.Borrar;
			this.limpiarPaisButton.Location = new System.Drawing.Point(260, 63);
			this.limpiarPaisButton.Name = "limpiarPaisButton";
			this.limpiarPaisButton.Size = new System.Drawing.Size(24, 24);
			this.limpiarPaisButton.TabIndex = 10;
			this.toolTip.SetToolTip(this.limpiarPaisButton, "Limpiar Pais (indica Todos los Paises)");
			this.limpiarPaisButton.UseVisualStyleBackColor = true;
			this.limpiarPaisButton.Click += new System.EventHandler(this.LimpiarPaisButton_Click);
			// 
			// EsRateFijoCB
			// 
			this.EsRateFijoCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.EsRateFijoCB.AutoSize = true;
			this.EsRateFijoCB.Location = new System.Drawing.Point(103, 205);
			this.EsRateFijoCB.Name = "EsRateFijoCB";
			this.EsRateFijoCB.Size = new System.Drawing.Size(15, 14);
			this.EsRateFijoCB.TabIndex = 8;
			this.EsRateFijoCB.UseVisualStyleBackColor = true;
			// 
			// esRateFijoLbl
			// 
			this.esRateFijoLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.esRateFijoLbl.AutoSize = true;
			this.esRateFijoLbl.Location = new System.Drawing.Point(48, 205);
			this.esRateFijoLbl.Name = "esRateFijoLbl";
			this.esRateFijoLbl.Size = new System.Drawing.Size(49, 13);
			this.esRateFijoLbl.TabIndex = 9;
			this.esRateFijoLbl.Text = "Rate Fijo";
			// 
			// monedaLbl
			// 
			this.monedaLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.monedaLbl.AutoSize = true;
			this.monedaLbl.Location = new System.Drawing.Point(51, 38);
			this.monedaLbl.Name = "monedaLbl";
			this.monedaLbl.Size = new System.Drawing.Size(46, 13);
			this.monedaLbl.TabIndex = 2;
			this.monedaLbl.Text = "Moneda";
			// 
			// actividadLbl
			// 
			this.actividadLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.actividadLbl.AutoSize = true;
			this.actividadLbl.Location = new System.Drawing.Point(46, 8);
			this.actividadLbl.Name = "actividadLbl";
			this.actividadLbl.Size = new System.Drawing.Size(51, 13);
			this.actividadLbl.TabIndex = 1;
			this.actividadLbl.Text = "Actividad";
			// 
			// clienteLbl
			// 
			this.clienteLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.clienteLbl.AutoSize = true;
			this.clienteLbl.Location = new System.Drawing.Point(58, 98);
			this.clienteLbl.Name = "clienteLbl";
			this.clienteLbl.Size = new System.Drawing.Size(39, 13);
			this.clienteLbl.TabIndex = 3;
			this.clienteLbl.Text = "Cliente";
			// 
			// fKBoxActividad
			// 
			this.fKBoxActividad.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fKBoxActividad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fKBoxActividad.Location = new System.Drawing.Point(103, 3);
			this.fKBoxActividad.MaximumSize = new System.Drawing.Size(500, 24);
			this.fKBoxActividad.MinimumSize = new System.Drawing.Size(50, 24);
			this.fKBoxActividad.Name = "fKBoxActividad";
			this.fKBoxActividad.Size = new System.Drawing.Size(150, 24);
			this.fKBoxActividad.TabIndex = 1;
			this.fKBoxActividad.Validating += new System.ComponentModel.CancelEventHandler(this.FKBoxActividad_Validating);
			// 
			// fKBoxMoneda
			// 
			this.fKBoxMoneda.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fKBoxMoneda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fKBoxMoneda.Location = new System.Drawing.Point(103, 33);
			this.fKBoxMoneda.MaximumSize = new System.Drawing.Size(500, 24);
			this.fKBoxMoneda.MinimumSize = new System.Drawing.Size(50, 24);
			this.fKBoxMoneda.Name = "fKBoxMoneda";
			this.fKBoxMoneda.Size = new System.Drawing.Size(150, 24);
			this.fKBoxMoneda.TabIndex = 2;
			this.fKBoxMoneda.Validating += new System.ComponentModel.CancelEventHandler(this.FKBoxMoneda_Validating);
			// 
			// fKBoxPais
			// 
			this.fKBoxPais.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fKBoxPais.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fKBoxPais.Location = new System.Drawing.Point(103, 63);
			this.fKBoxPais.MaximumSize = new System.Drawing.Size(500, 24);
			this.fKBoxPais.MinimumSize = new System.Drawing.Size(50, 24);
			this.fKBoxPais.Name = "fKBoxPais";
			this.fKBoxPais.Size = new System.Drawing.Size(150, 24);
			this.fKBoxPais.TabIndex = 3;
			// 
			// fKBoxCliente
			// 
			this.fKBoxCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fKBoxCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fKBoxCliente.Location = new System.Drawing.Point(103, 93);
			this.fKBoxCliente.MaximumSize = new System.Drawing.Size(500, 24);
			this.fKBoxCliente.MinimumSize = new System.Drawing.Size(50, 24);
			this.fKBoxCliente.Name = "fKBoxCliente";
			this.fKBoxCliente.Size = new System.Drawing.Size(150, 24);
			this.fKBoxCliente.TabIndex = 4;
			// 
			// umLbl
			// 
			this.umLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.umLbl.AutoSize = true;
			this.umLbl.Location = new System.Drawing.Point(18, 128);
			this.umLbl.Name = "umLbl";
			this.umLbl.Size = new System.Drawing.Size(79, 13);
			this.umLbl.TabIndex = 2;
			this.umLbl.Text = "Unidad Medida";
			// 
			// fKBoxUM
			// 
			this.fKBoxUM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fKBoxUM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fKBoxUM.Location = new System.Drawing.Point(103, 123);
			this.fKBoxUM.MaximumSize = new System.Drawing.Size(500, 24);
			this.fKBoxUM.MinimumSize = new System.Drawing.Size(50, 24);
			this.fKBoxUM.Name = "fKBoxUM";
			this.fKBoxUM.Size = new System.Drawing.Size(150, 24);
			this.fKBoxUM.TabIndex = 5;
			this.fKBoxUM.Validating += new System.ComponentModel.CancelEventHandler(this.FKBoxUM_Validating);
			// 
			// cantidadTopeLbl
			// 
			this.cantidadTopeLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.cantidadTopeLbl.AutoSize = true;
			this.cantidadTopeLbl.Location = new System.Drawing.Point(17, 156);
			this.cantidadTopeLbl.Name = "cantidadTopeLbl";
			this.cantidadTopeLbl.Size = new System.Drawing.Size(80, 13);
			this.cantidadTopeLbl.TabIndex = 2;
			this.cantidadTopeLbl.Text = "Cantidad Hasta";
			// 
			// rateLbl
			// 
			this.rateLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.rateLbl.AutoSize = true;
			this.rateLbl.Location = new System.Drawing.Point(67, 182);
			this.rateLbl.Name = "rateLbl";
			this.rateLbl.Size = new System.Drawing.Size(30, 13);
			this.rateLbl.TabIndex = 4;
			this.rateLbl.Text = "Rate";
			// 
			// RateDB
			// 
			this.RateDB.AllowNull = false;
			this.RateDB.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.RateDB.Location = new System.Drawing.Point(103, 179);
			this.RateDB.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            131072});
			this.RateDB.Name = "RateDB";
			this.RateDB.Size = new System.Drawing.Size(100, 20);
			this.RateDB.TabIndex = 7;
			this.RateDB.Validating += new System.ComponentModel.CancelEventHandler(this.RateDB_Validating);
			// 
			// limpiarClienteB
			// 
			this.limpiarClienteB.Image = global::Kenwin.PPP.Cliente.Properties.Resources.Borrar;
			this.limpiarClienteB.Location = new System.Drawing.Point(260, 93);
			this.limpiarClienteB.Name = "limpiarClienteB";
			this.limpiarClienteB.Size = new System.Drawing.Size(24, 24);
			this.limpiarClienteB.TabIndex = 11;
			this.toolTip.SetToolTip(this.limpiarClienteB, "Limpiar Cliente (indica Todos los Clientes)");
			this.limpiarClienteB.UseVisualStyleBackColor = true;
			this.limpiarClienteB.Click += new System.EventHandler(this.LimpiarClienteB_Click);
			// 
			// CantidadTopeIB
			// 
			this.CantidadTopeIB.AutoSize = false;
			this.CantidadTopeIB.DataType = typeof(int);
			this.CantidadTopeIB.EmptyAsNull = true;
			this.CantidadTopeIB.ErrorInfo.ErrorAction = C1.Win.C1Input.ErrorActionEnum.ResetValue;
			this.CantidadTopeIB.ErrorInfo.ShowErrorMessage = false;
			this.CantidadTopeIB.FormatType = C1.Win.C1Input.FormatTypeEnum.Integer;
			this.CantidadTopeIB.Location = new System.Drawing.Point(103, 153);
			this.CantidadTopeIB.MaxLength = 10;
			this.CantidadTopeIB.Name = "CantidadTopeIB";
			this.CantidadTopeIB.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
			this.CantidadTopeIB.PostValidation.Intervals.AddRange(new C1.Win.C1Input.ValueInterval[] {
            new C1.Win.C1Input.ValueInterval(((long)(0)), ((long)(999999999)), true, true)});
			this.CantidadTopeIB.Size = new System.Drawing.Size(100, 20);
			this.CantidadTopeIB.TabIndex = 6;
			this.CantidadTopeIB.Tag = null;
			this.CantidadTopeIB.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
			// 
			// ABMTarifa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 386);
			this.ControlBox = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.GetDataPageAfterInsert = false;
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Name = "ABMTarifa";
			this.Text = "Tarifa";
			this.Load += new System.EventHandler(this.ABMTarifa_Load);
			((System.ComponentModel.ISupportInitialize)(this._bs)).EndInit();
			this.groupDetail.ResumeLayout(false);
			this.CrudTab.ResumeLayout(false);
			this.TableTab.ResumeLayout(false);
			this.TableTab.PerformLayout();
			this.DetailTab.ResumeLayout(false);
			this.panelContainerDetail.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgVemn)).EndInit();
			this.panelContainerButton.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CantidadTopeIB)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion Windows Form Designer generated code		

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label cantidadTopeLbl;
		private System.Windows.Forms.Label umLbl;
		private System.Windows.Forms.Label paisLbl;
		private System.Windows.Forms.Label monedaLbl;
		private System.Windows.Forms.Label actividadLbl;
		private System.Windows.Forms.Label clienteLbl;
		private Comun.Controles.FKBoxes.ActividadFKBox fKBoxActividad;
		private Comun.Controles.FKBoxes.MonedaFKBox fKBoxMoneda;
		private Comun.Controles.FKBoxes.PaisFKBox fKBoxPais;
		private Comun.Controles.FKBoxes.ClienteFKBox fKBoxCliente;
		private Comun.Controles.FKBoxes.UnidadMedidaFKBox fKBoxUM;
		private System.Windows.Forms.Label rateLbl;
		private System.Windows.Forms.Label esRateFijoLbl;
		private System.Windows.Forms.CheckBox EsRateFijoCB;
		private Vemn.Fwk.Windows.Controls.DecimalBox RateDB;
		private System.Windows.Forms.Button limpiarPaisButton;
		private System.Windows.Forms.Button limpiarClienteB;
		private System.Windows.Forms.ToolTip toolTip;
		private C1.Win.C1Input.C1NumericEdit CantidadTopeIB;
	}
}

