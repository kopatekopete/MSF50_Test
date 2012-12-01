using System;

namespace Kenwin.PPP.Cliente.Proyectos
{
    partial class Editor
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
			System.Windows.Forms.TabPage actividadesTabPage;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
			System.Windows.Forms.Label estadoVersionActualLabel;
			System.Windows.Forms.Label probabilidadVersionActualLabel;
			System.Windows.Forms.Label fechaInicioProyectoVersionActualLabel;
			System.Windows.Forms.Label fechaVersionV1Label;
			System.Windows.Forms.Label estadoVersionAnteriorLabel;
			System.Windows.Forms.Label label20;
			System.Windows.Forms.Label label21;
			System.Windows.Forms.Label fechaVersionV2Label;
			System.Windows.Forms.TabPage datosGeneralesTabPage;
			this.panel1 = new System.Windows.Forms.Panel();
			this.versionesSplitContainer = new System.Windows.Forms.SplitContainer();
			this.version1C1FlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.menuVersionActualTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.menuVersionActualAbajoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.estadoVersionActualComboBox = new System.Windows.Forms.ComboBox();
			this.fechaInicioProyectoVersionActualC1DateEdit = new C1.Win.C1Input.C1DateEdit();
			this.probabilidadVersion1C1NumericEdit = new C1.Win.C1Input.C1NumericEdit();
			this.menuVersionActualArribaTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.agregarActividadButton = new System.Windows.Forms.Button();
			this.crearVersionV1Button = new System.Windows.Forms.Button();
			this.fechaVersionV1TextBox = new System.Windows.Forms.TextBox();
			this.expandirPanelVersionButton = new System.Windows.Forms.Button();
			this.versionV1Label = new System.Windows.Forms.Label();
			this.sumatoriasVersionActualTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.version2C1FlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.menuVersionAnteriorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.menuVersionAnteriorAbajoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.estadoVersionAnteriorComboBox = new System.Windows.Forms.ComboBox();
			this.probabilidadVersion2TextBox = new System.Windows.Forms.TextBox();
			this.fechaInicioProyectoVersionAnteriorTextBox = new System.Windows.Forms.TextBox();
			this.menuVersionAnteriorArribaTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.contraerPanelVersionButton = new System.Windows.Forms.Button();
			this.crearVersionV2Button = new System.Windows.Forms.Button();
			this.fechaVersionV2TextBox = new System.Windows.Forms.TextBox();
			this.versionAnteriorComboBox = new System.Windows.Forms.ComboBox();
			this.decrementarVersionAnteriorButton = new System.Windows.Forms.Button();
			this.incrementarVersionAnteriorButton = new System.Windows.Forms.Button();
			this.sumatoriasVersionAnteriorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.asignacionGroupBox = new System.Windows.Forms.GroupBox();
			this.asignacionPersonal1 = new Kenwin.PPP.Cliente.Proyectos.AsignacionPersonal();
			this.datosProyectoGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.paisLabel = new System.Windows.Forms.Label();
			this.unidadNegocioLabel = new System.Windows.Forms.Label();
			this.tipoEmpresaLabel = new System.Windows.Forms.Label();
			this.tipoProyectoLabel = new System.Windows.Forms.Label();
			this.contatoComercialLabel = new System.Windows.Forms.Label();
			this.liderClienteLabel = new System.Windows.Forms.Label();
			this.liderClienteTextBox = new System.Windows.Forms.TextBox();
			this.contactoComercialTextBox = new System.Windows.Forms.TextBox();
			this.observacionesTextBox = new System.Windows.Forms.TextBox();
			this.usuarioCreadorLabel = new System.Windows.Forms.Label();
			this.usuarioCreadorTextBox = new System.Windows.Forms.TextBox();
			this.observacionesLabel = new System.Windows.Forms.Label();
			this.paisFKBox = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.PaisFKBox();
			this.unidadNegocioFKBox = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.UnidadNegocioFKBox();
			this.tipoEmpresaFKBox = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.TipoEmpresaFKBox();
			this.tipoProyectoFKBox = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.TipoProyectoFKBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.nombreProyectoTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.monedaLabel = new System.Windows.Forms.Label();
			this.clienteFKBox = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.ClienteFKBox();
			this.monedaFKBox = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.MonedaFKBox();
			this.proyectoOTFKBox = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.ProyectoOTFKBox();
			this.proyectoPadreFKBox = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.ProyectoPadreFKBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.asignacionSemanal1 = new Kenwin.PPP.Cliente.Proyectos.AsignacionSemanal();
			this.panel2 = new System.Windows.Forms.Panel();
			this.crearProyectoButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.OkButton();
			this.guardarButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.OkButton();
			this.cerrarButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.CancelButton();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.eliminarActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			actividadesTabPage = new System.Windows.Forms.TabPage();
			estadoVersionActualLabel = new System.Windows.Forms.Label();
			probabilidadVersionActualLabel = new System.Windows.Forms.Label();
			fechaInicioProyectoVersionActualLabel = new System.Windows.Forms.Label();
			fechaVersionV1Label = new System.Windows.Forms.Label();
			estadoVersionAnteriorLabel = new System.Windows.Forms.Label();
			label20 = new System.Windows.Forms.Label();
			label21 = new System.Windows.Forms.Label();
			fechaVersionV2Label = new System.Windows.Forms.Label();
			datosGeneralesTabPage = new System.Windows.Forms.TabPage();
			actividadesTabPage.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.versionesSplitContainer)).BeginInit();
			this.versionesSplitContainer.Panel1.SuspendLayout();
			this.versionesSplitContainer.Panel2.SuspendLayout();
			this.versionesSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.version1C1FlexGrid)).BeginInit();
			this.menuVersionActualTableLayoutPanel.SuspendLayout();
			this.menuVersionActualAbajoTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fechaInicioProyectoVersionActualC1DateEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.probabilidadVersion1C1NumericEdit)).BeginInit();
			this.menuVersionActualArribaTableLayoutPanel.SuspendLayout();
			this.sumatoriasVersionActualTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.version2C1FlexGrid)).BeginInit();
			this.menuVersionAnteriorTableLayoutPanel.SuspendLayout();
			this.menuVersionAnteriorAbajoTableLayoutPanel.SuspendLayout();
			this.menuVersionAnteriorArribaTableLayoutPanel.SuspendLayout();
			this.sumatoriasVersionAnteriorTableLayoutPanel.SuspendLayout();
			datosGeneralesTabPage.SuspendLayout();
			this.asignacionGroupBox.SuspendLayout();
			this.datosProyectoGroupBox.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// actividadesTabPage
			// 
			actividadesTabPage.Controls.Add(this.panel1);
			actividadesTabPage.Location = new System.Drawing.Point(4, 22);
			actividadesTabPage.Name = "actividadesTabPage";
			actividadesTabPage.Padding = new System.Windows.Forms.Padding(3);
			actividadesTabPage.Size = new System.Drawing.Size(1114, 613);
			actividadesTabPage.TabIndex = 0;
			actividadesTabPage.Text = "Actividades";
			actividadesTabPage.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.versionesSplitContainer);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1108, 607);
			this.panel1.TabIndex = 7;
			// 
			// versionesSplitContainer
			// 
			this.versionesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.versionesSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.versionesSplitContainer.Name = "versionesSplitContainer";
			// 
			// versionesSplitContainer.Panel1
			// 
			this.versionesSplitContainer.Panel1.Controls.Add(this.version1C1FlexGrid);
			this.versionesSplitContainer.Panel1.Controls.Add(this.menuVersionActualTableLayoutPanel);
			this.versionesSplitContainer.Panel1.Controls.Add(this.sumatoriasVersionActualTableLayoutPanel);
			// 
			// versionesSplitContainer.Panel2
			// 
			this.versionesSplitContainer.Panel2.Controls.Add(this.version2C1FlexGrid);
			this.versionesSplitContainer.Panel2.Controls.Add(this.menuVersionAnteriorTableLayoutPanel);
			this.versionesSplitContainer.Panel2.Controls.Add(this.sumatoriasVersionAnteriorTableLayoutPanel);
			this.versionesSplitContainer.Size = new System.Drawing.Size(1108, 607);
			this.versionesSplitContainer.SplitterDistance = 576;
			this.versionesSplitContainer.TabIndex = 1;
			this.versionesSplitContainer.SplitterMoving += new System.Windows.Forms.SplitterCancelEventHandler(this.VersionesSplitContainer_SplitterMoving);
			// 
			// version1C1FlexGrid
			// 
			this.version1C1FlexGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.version1C1FlexGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.version1C1FlexGrid.AutoGenerateColumns = false;
			this.version1C1FlexGrid.AutoResize = false;
			this.version1C1FlexGrid.ColumnInfo = "1,1,0,0,0,85,Columns:0{Width:23;}\t";
			this.version1C1FlexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.version1C1FlexGrid.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
			this.version1C1FlexGrid.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.version1C1FlexGrid.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
			this.version1C1FlexGrid.Location = new System.Drawing.Point(0, 60);
			this.version1C1FlexGrid.Name = "version1C1FlexGrid";
			this.version1C1FlexGrid.Rows.Count = 1;
			this.version1C1FlexGrid.Rows.DefaultSize = 17;
			this.version1C1FlexGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
			this.version1C1FlexGrid.ShowCellLabels = true;
			this.version1C1FlexGrid.Size = new System.Drawing.Size(576, 494);
			this.version1C1FlexGrid.StyleInfo = resources.GetString("version1C1FlexGrid.StyleInfo");
			this.version1C1FlexGrid.TabIndex = 2;
			this.version1C1FlexGrid.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.C1FlexGrid_AfterScroll);
			this.version1C1FlexGrid.StartEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.Version1C1FlexGrid_StartEdit);
			this.version1C1FlexGrid.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.Version1C1FlexGrid_AfterEdit);
			this.version1C1FlexGrid.SetupEditor += new C1.Win.C1FlexGrid.RowColEventHandler(this.Version1C1FlexGrid_SetupEditor);
			this.version1C1FlexGrid.ValidateEdit += new C1.Win.C1FlexGrid.ValidateEditEventHandler(this.Version1C1FlexGrid_ValidateEdit);
			this.version1C1FlexGrid.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.C1FlexGrid_OwnerDrawCell);
			this.version1C1FlexGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Version1C1FlexGrid_KeyUp);
			this.version1C1FlexGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Version1C1FlexGrid_MouseClick);
			// 
			// menuVersionActualTableLayoutPanel
			// 
			this.menuVersionActualTableLayoutPanel.AutoSize = true;
			this.menuVersionActualTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
			this.menuVersionActualTableLayoutPanel.ColumnCount = 1;
			this.menuVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.menuVersionActualTableLayoutPanel.Controls.Add(this.menuVersionActualAbajoTableLayoutPanel, 0, 1);
			this.menuVersionActualTableLayoutPanel.Controls.Add(this.menuVersionActualArribaTableLayoutPanel, 0, 0);
			this.menuVersionActualTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.menuVersionActualTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.menuVersionActualTableLayoutPanel.Name = "menuVersionActualTableLayoutPanel";
			this.menuVersionActualTableLayoutPanel.RowCount = 2;
			this.menuVersionActualTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.menuVersionActualTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.menuVersionActualTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.menuVersionActualTableLayoutPanel.Size = new System.Drawing.Size(576, 60);
			this.menuVersionActualTableLayoutPanel.TabIndex = 3;
			// 
			// menuVersionActualAbajoTableLayoutPanel
			// 
			this.menuVersionActualAbajoTableLayoutPanel.ColumnCount = 9;
			this.menuVersionActualAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionActualAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionActualAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.menuVersionActualAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionActualAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionActualAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
			this.menuVersionActualAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionActualAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionActualAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.menuVersionActualAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.menuVersionActualAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.menuVersionActualAbajoTableLayoutPanel.Controls.Add(estadoVersionActualLabel, 0, 0);
			this.menuVersionActualAbajoTableLayoutPanel.Controls.Add(this.estadoVersionActualComboBox, 1, 0);
			this.menuVersionActualAbajoTableLayoutPanel.Controls.Add(probabilidadVersionActualLabel, 3, 0);
			this.menuVersionActualAbajoTableLayoutPanel.Controls.Add(fechaInicioProyectoVersionActualLabel, 6, 0);
			this.menuVersionActualAbajoTableLayoutPanel.Controls.Add(this.fechaInicioProyectoVersionActualC1DateEdit, 8, 0);
			this.menuVersionActualAbajoTableLayoutPanel.Controls.Add(this.probabilidadVersion1C1NumericEdit, 5, 0);
			this.menuVersionActualAbajoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menuVersionActualAbajoTableLayoutPanel.Location = new System.Drawing.Point(0, 30);
			this.menuVersionActualAbajoTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.menuVersionActualAbajoTableLayoutPanel.Name = "menuVersionActualAbajoTableLayoutPanel";
			this.menuVersionActualAbajoTableLayoutPanel.RowCount = 1;
			this.menuVersionActualAbajoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.menuVersionActualAbajoTableLayoutPanel.Size = new System.Drawing.Size(576, 30);
			this.menuVersionActualAbajoTableLayoutPanel.TabIndex = 1;
			// 
			// estadoVersionActualLabel
			// 
			estadoVersionActualLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			estadoVersionActualLabel.AutoSize = true;
			estadoVersionActualLabel.Location = new System.Drawing.Point(3, 8);
			estadoVersionActualLabel.Name = "estadoVersionActualLabel";
			estadoVersionActualLabel.Size = new System.Drawing.Size(43, 13);
			estadoVersionActualLabel.TabIndex = 0;
			estadoVersionActualLabel.Text = "Estado:";
			// 
			// estadoVersionActualComboBox
			// 
			this.estadoVersionActualComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.estadoVersionActualComboBox.FormattingEnabled = true;
			this.estadoVersionActualComboBox.Location = new System.Drawing.Point(52, 3);
			this.estadoVersionActualComboBox.Name = "estadoVersionActualComboBox";
			this.estadoVersionActualComboBox.Size = new System.Drawing.Size(114, 21);
			this.estadoVersionActualComboBox.TabIndex = 1;
			this.estadoVersionActualComboBox.SelectedIndexChanged += new System.EventHandler(this.EstadoVersionActualComboBox_SelectedIndexChanged);
			// 
			// probabilidadVersionActualLabel
			// 
			probabilidadVersionActualLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			probabilidadVersionActualLabel.AutoSize = true;
			probabilidadVersionActualLabel.Location = new System.Drawing.Point(192, 8);
			probabilidadVersionActualLabel.Name = "probabilidadVersionActualLabel";
			probabilidadVersionActualLabel.Size = new System.Drawing.Size(68, 13);
			probabilidadVersionActualLabel.TabIndex = 2;
			probabilidadVersionActualLabel.Text = "Probabilidad:";
			// 
			// fechaInicioProyectoVersionActualLabel
			// 
			fechaInicioProyectoVersionActualLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			fechaInicioProyectoVersionActualLabel.AutoSize = true;
			fechaInicioProyectoVersionActualLabel.Location = new System.Drawing.Point(345, 8);
			fechaInicioProyectoVersionActualLabel.Name = "fechaInicioProyectoVersionActualLabel";
			fechaInicioProyectoVersionActualLabel.Size = new System.Drawing.Size(80, 13);
			fechaInicioProyectoVersionActualLabel.TabIndex = 4;
			fechaInicioProyectoVersionActualLabel.Text = "Inicio Proyecto:";
			// 
			// fechaInicioProyectoVersionActualC1DateEdit
			// 
			this.fechaInicioProyectoVersionActualC1DateEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fechaInicioProyectoVersionActualC1DateEdit.EmptyAsNull = true;
			this.fechaInicioProyectoVersionActualC1DateEdit.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
			this.fechaInicioProyectoVersionActualC1DateEdit.Location = new System.Drawing.Point(431, 5);
			this.fechaInicioProyectoVersionActualC1DateEdit.Name = "fechaInicioProyectoVersionActualC1DateEdit";
			this.fechaInicioProyectoVersionActualC1DateEdit.Size = new System.Drawing.Size(100, 20);
			this.fechaInicioProyectoVersionActualC1DateEdit.TabIndex = 5;
			this.fechaInicioProyectoVersionActualC1DateEdit.Tag = null;
			this.fechaInicioProyectoVersionActualC1DateEdit.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
			// 
			// probabilidadVersion1C1NumericEdit
			// 
			this.probabilidadVersion1C1NumericEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.probabilidadVersion1C1NumericEdit.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.probabilidadVersion1C1NumericEdit.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText)
						| C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull)
						| C1.Win.C1Input.FormatInfoInheritFlags.TrimStart)
						| C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
			this.probabilidadVersion1C1NumericEdit.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.probabilidadVersion1C1NumericEdit.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText)
						| C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull)
						| C1.Win.C1Input.FormatInfoInheritFlags.TrimStart)
						| C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
			this.probabilidadVersion1C1NumericEdit.EmptyAsNull = true;
			this.probabilidadVersion1C1NumericEdit.ErrorInfo.ErrorAction = C1.Win.C1Input.ErrorActionEnum.ResetValue;
			this.probabilidadVersion1C1NumericEdit.ErrorInfo.ShowErrorMessage = false;
			this.probabilidadVersion1C1NumericEdit.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.probabilidadVersion1C1NumericEdit.InterceptArrowKeys = false;
			this.probabilidadVersion1C1NumericEdit.Location = new System.Drawing.Point(266, 5);
			this.probabilidadVersion1C1NumericEdit.MaxLength = 5;
			this.probabilidadVersion1C1NumericEdit.Name = "probabilidadVersion1C1NumericEdit";
			this.probabilidadVersion1C1NumericEdit.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
			this.probabilidadVersion1C1NumericEdit.PostValidation.AllowDbNull = false;
			this.probabilidadVersion1C1NumericEdit.PostValidation.Validation = C1.Win.C1Input.PostValidationTypeEnum.PostValidatingEvent;
			this.probabilidadVersion1C1NumericEdit.Size = new System.Drawing.Size(73, 20);
			this.probabilidadVersion1C1NumericEdit.TabIndex = 6;
			this.probabilidadVersion1C1NumericEdit.Tag = null;
			this.probabilidadVersion1C1NumericEdit.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
			this.probabilidadVersion1C1NumericEdit.PostValidating += new C1.Win.C1Input.PostValidationEventHandler(this.ProbabilidadVersion1C1NumericEdit_PostValidating);
			// 
			// menuVersionActualArribaTableLayoutPanel
			// 
			this.menuVersionActualArribaTableLayoutPanel.ColumnCount = 8;
			this.menuVersionActualArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionActualArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionActualArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionActualArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionActualArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionActualArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.menuVersionActualArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionActualArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.menuVersionActualArribaTableLayoutPanel.Controls.Add(this.agregarActividadButton, 0, 0);
			this.menuVersionActualArribaTableLayoutPanel.Controls.Add(this.crearVersionV1Button, 1, 0);
			this.menuVersionActualArribaTableLayoutPanel.Controls.Add(fechaVersionV1Label, 3, 0);
			this.menuVersionActualArribaTableLayoutPanel.Controls.Add(this.fechaVersionV1TextBox, 4, 0);
			this.menuVersionActualArribaTableLayoutPanel.Controls.Add(this.expandirPanelVersionButton, 7, 0);
			this.menuVersionActualArribaTableLayoutPanel.Controls.Add(this.versionV1Label, 6, 0);
			this.menuVersionActualArribaTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menuVersionActualArribaTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.menuVersionActualArribaTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.menuVersionActualArribaTableLayoutPanel.Name = "menuVersionActualArribaTableLayoutPanel";
			this.menuVersionActualArribaTableLayoutPanel.RowCount = 1;
			this.menuVersionActualArribaTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.menuVersionActualArribaTableLayoutPanel.Size = new System.Drawing.Size(576, 30);
			this.menuVersionActualArribaTableLayoutPanel.TabIndex = 0;
			// 
			// agregarActividadButton
			// 
			this.agregarActividadButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.agregarActividadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.agregarActividadButton.Image = global::Kenwin.PPP.Cliente.Properties.Resources.AgregarVerde;
			this.agregarActividadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.agregarActividadButton.Location = new System.Drawing.Point(3, 3);
			this.agregarActividadButton.Name = "agregarActividadButton";
			this.agregarActividadButton.Size = new System.Drawing.Size(124, 24);
			this.agregarActividadButton.TabIndex = 0;
			this.agregarActividadButton.Text = "Agregar Actividad";
			this.agregarActividadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.agregarActividadButton.UseVisualStyleBackColor = true;
			this.agregarActividadButton.Click += new System.EventHandler(this.AgregarActividadButton_Click);
			// 
			// crearVersionV1Button
			// 
			this.crearVersionV1Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.crearVersionV1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.crearVersionV1Button.Location = new System.Drawing.Point(133, 3);
			this.crearVersionV1Button.Name = "crearVersionV1Button";
			this.crearVersionV1Button.Size = new System.Drawing.Size(75, 24);
			this.crearVersionV1Button.TabIndex = 1;
			this.crearVersionV1Button.Text = "Versionar";
			this.crearVersionV1Button.UseVisualStyleBackColor = true;
			this.crearVersionV1Button.Click += new System.EventHandler(this.CrearVersionDesdeActualButton_Click);
			// 
			// fechaVersionV1Label
			// 
			fechaVersionV1Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
			fechaVersionV1Label.AutoSize = true;
			fechaVersionV1Label.Location = new System.Drawing.Point(214, 8);
			fechaVersionV1Label.Name = "fechaVersionV1Label";
			fechaVersionV1Label.Size = new System.Drawing.Size(78, 13);
			fechaVersionV1Label.TabIndex = 2;
			fechaVersionV1Label.Text = "Fecha Version:";
			fechaVersionV1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// fechaVersionV1TextBox
			// 
			this.fechaVersionV1TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fechaVersionV1TextBox.Location = new System.Drawing.Point(298, 5);
			this.fechaVersionV1TextBox.Name = "fechaVersionV1TextBox";
			this.fechaVersionV1TextBox.ReadOnly = true;
			this.fechaVersionV1TextBox.Size = new System.Drawing.Size(83, 20);
			this.fechaVersionV1TextBox.TabIndex = 3;
			// 
			// expandirPanelVersionButton
			// 
			this.expandirPanelVersionButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.expandirPanelVersionButton.Image = global::Kenwin.PPP.Cliente.Properties.Resources.FlechaIzquierda;
			this.expandirPanelVersionButton.Location = new System.Drawing.Point(551, 3);
			this.expandirPanelVersionButton.Name = "expandirPanelVersionButton";
			this.expandirPanelVersionButton.Size = new System.Drawing.Size(22, 23);
			this.expandirPanelVersionButton.TabIndex = 4;
			this.expandirPanelVersionButton.UseVisualStyleBackColor = true;
			this.expandirPanelVersionButton.Click += new System.EventHandler(this.ExpandirPanelVersionButton_Click);
			// 
			// versionV1Label
			// 
			this.versionV1Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.versionV1Label.AutoSize = true;
			this.versionV1Label.Location = new System.Drawing.Point(503, 8);
			this.versionV1Label.Name = "versionV1Label";
			this.versionV1Label.Size = new System.Drawing.Size(42, 13);
			this.versionV1Label.TabIndex = 5;
			this.versionV1Label.Text = "Versión";
			this.versionV1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// sumatoriasVersionActualTableLayoutPanel
			// 
			this.sumatoriasVersionActualTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
			this.sumatoriasVersionActualTableLayoutPanel.ColumnCount = 13;
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionActualTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.label5, 1, 0);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.label6, 1, 1);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.label7, 4, 1);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.label8, 4, 0);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.label9, 7, 0);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.label10, 10, 0);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.label11, 10, 1);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.textBox1, 2, 0);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.textBox2, 2, 1);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.textBox3, 5, 0);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.textBox4, 5, 1);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.textBox5, 8, 0);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.textBox6, 11, 0);
			this.sumatoriasVersionActualTableLayoutPanel.Controls.Add(this.textBox7, 11, 1);
			this.sumatoriasVersionActualTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sumatoriasVersionActualTableLayoutPanel.Location = new System.Drawing.Point(0, 554);
			this.sumatoriasVersionActualTableLayoutPanel.Name = "sumatoriasVersionActualTableLayoutPanel";
			this.sumatoriasVersionActualTableLayoutPanel.RowCount = 3;
			this.sumatoriasVersionActualTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.sumatoriasVersionActualTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.sumatoriasVersionActualTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.sumatoriasVersionActualTableLayoutPanel.Size = new System.Drawing.Size(576, 53);
			this.sumatoriasVersionActualTableLayoutPanel.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 25);
			this.label5.TabIndex = 0;
			this.label5.Text = "Horas Totales:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(18, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 25);
			this.label6.TabIndex = 8;
			this.label6.Text = "Días Totales:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(166, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 25);
			this.label7.TabIndex = 10;
			this.label7.Text = "Precio Final:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(166, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 25);
			this.label8.TabIndex = 2;
			this.label8.Text = "Precio Bruto:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(306, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(43, 25);
			this.label9.TabIndex = 4;
			this.label9.Text = "Gastos:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(421, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 25);
			this.label10.TabIndex = 6;
			this.label10.Text = "Total COPC:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(421, 25);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(81, 25);
			this.label11.TabIndex = 12;
			this.label11.Text = "Total no COPC:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox1.Location = new System.Drawing.Point(100, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(50, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox2.Location = new System.Drawing.Point(100, 28);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(50, 20);
			this.textBox2.TabIndex = 9;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox3
			// 
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox3.Location = new System.Drawing.Point(240, 3);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(50, 20);
			this.textBox3.TabIndex = 3;
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox4
			// 
			this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox4.Location = new System.Drawing.Point(240, 28);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(50, 20);
			this.textBox4.TabIndex = 11;
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox5
			// 
			this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox5.Location = new System.Drawing.Point(355, 3);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(50, 20);
			this.textBox5.TabIndex = 5;
			this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox6
			// 
			this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox6.Location = new System.Drawing.Point(508, 3);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(50, 20);
			this.textBox6.TabIndex = 7;
			this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox7
			// 
			this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox7.Location = new System.Drawing.Point(508, 28);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(50, 20);
			this.textBox7.TabIndex = 13;
			this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// version2C1FlexGrid
			// 
			this.version2C1FlexGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.version2C1FlexGrid.AllowEditing = false;
			this.version2C1FlexGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.version2C1FlexGrid.AutoGenerateColumns = false;
			this.version2C1FlexGrid.AutoResize = false;
			this.version2C1FlexGrid.ColumnInfo = "1,1,0,0,0,85,Columns:0{Width:23;}\t";
			this.version2C1FlexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.version2C1FlexGrid.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
			this.version2C1FlexGrid.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.version2C1FlexGrid.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
			this.version2C1FlexGrid.Location = new System.Drawing.Point(0, 60);
			this.version2C1FlexGrid.Name = "version2C1FlexGrid";
			this.version2C1FlexGrid.Rows.Count = 1;
			this.version2C1FlexGrid.Rows.DefaultSize = 17;
			this.version2C1FlexGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
			this.version2C1FlexGrid.ShowCellLabels = true;
			this.version2C1FlexGrid.Size = new System.Drawing.Size(528, 494);
			this.version2C1FlexGrid.TabIndex = 3;
			this.version2C1FlexGrid.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.C1FlexGrid_AfterScroll);
			this.version2C1FlexGrid.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.C1FlexGrid_OwnerDrawCell);
			// 
			// menuVersionAnteriorTableLayoutPanel
			// 
			this.menuVersionAnteriorTableLayoutPanel.AutoSize = true;
			this.menuVersionAnteriorTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
			this.menuVersionAnteriorTableLayoutPanel.ColumnCount = 1;
			this.menuVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.menuVersionAnteriorTableLayoutPanel.Controls.Add(this.menuVersionAnteriorAbajoTableLayoutPanel, 0, 1);
			this.menuVersionAnteriorTableLayoutPanel.Controls.Add(this.menuVersionAnteriorArribaTableLayoutPanel, 0, 0);
			this.menuVersionAnteriorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.menuVersionAnteriorTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.menuVersionAnteriorTableLayoutPanel.Name = "menuVersionAnteriorTableLayoutPanel";
			this.menuVersionAnteriorTableLayoutPanel.RowCount = 2;
			this.menuVersionAnteriorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.menuVersionAnteriorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.menuVersionAnteriorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.menuVersionAnteriorTableLayoutPanel.Size = new System.Drawing.Size(528, 60);
			this.menuVersionAnteriorTableLayoutPanel.TabIndex = 6;
			// 
			// menuVersionAnteriorAbajoTableLayoutPanel
			// 
			this.menuVersionAnteriorAbajoTableLayoutPanel.ColumnCount = 9;
			this.menuVersionAnteriorAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.menuVersionAnteriorAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
			this.menuVersionAnteriorAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.menuVersionAnteriorAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.menuVersionAnteriorAbajoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.menuVersionAnteriorAbajoTableLayoutPanel.Controls.Add(estadoVersionAnteriorLabel, 0, 0);
			this.menuVersionAnteriorAbajoTableLayoutPanel.Controls.Add(this.estadoVersionAnteriorComboBox, 1, 0);
			this.menuVersionAnteriorAbajoTableLayoutPanel.Controls.Add(label20, 3, 0);
			this.menuVersionAnteriorAbajoTableLayoutPanel.Controls.Add(label21, 6, 0);
			this.menuVersionAnteriorAbajoTableLayoutPanel.Controls.Add(this.probabilidadVersion2TextBox, 5, 0);
			this.menuVersionAnteriorAbajoTableLayoutPanel.Controls.Add(this.fechaInicioProyectoVersionAnteriorTextBox, 8, 0);
			this.menuVersionAnteriorAbajoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menuVersionAnteriorAbajoTableLayoutPanel.Location = new System.Drawing.Point(0, 30);
			this.menuVersionAnteriorAbajoTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.menuVersionAnteriorAbajoTableLayoutPanel.Name = "menuVersionAnteriorAbajoTableLayoutPanel";
			this.menuVersionAnteriorAbajoTableLayoutPanel.RowCount = 1;
			this.menuVersionAnteriorAbajoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.menuVersionAnteriorAbajoTableLayoutPanel.Size = new System.Drawing.Size(528, 30);
			this.menuVersionAnteriorAbajoTableLayoutPanel.TabIndex = 1;
			// 
			// estadoVersionAnteriorLabel
			// 
			estadoVersionAnteriorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			estadoVersionAnteriorLabel.AutoSize = true;
			estadoVersionAnteriorLabel.Location = new System.Drawing.Point(3, 8);
			estadoVersionAnteriorLabel.Name = "estadoVersionAnteriorLabel";
			estadoVersionAnteriorLabel.Size = new System.Drawing.Size(43, 13);
			estadoVersionAnteriorLabel.TabIndex = 0;
			estadoVersionAnteriorLabel.Text = "Estado:";
			// 
			// estadoVersionAnteriorComboBox
			// 
			this.estadoVersionAnteriorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.estadoVersionAnteriorComboBox.Enabled = false;
			this.estadoVersionAnteriorComboBox.FormattingEnabled = true;
			this.estadoVersionAnteriorComboBox.Location = new System.Drawing.Point(52, 3);
			this.estadoVersionAnteriorComboBox.Name = "estadoVersionAnteriorComboBox";
			this.estadoVersionAnteriorComboBox.Size = new System.Drawing.Size(114, 21);
			this.estadoVersionAnteriorComboBox.TabIndex = 1;
			// 
			// label20
			// 
			label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label20.AutoSize = true;
			label20.Location = new System.Drawing.Point(192, 8);
			label20.Name = "label20";
			label20.Size = new System.Drawing.Size(68, 13);
			label20.TabIndex = 2;
			label20.Text = "Probabilidad:";
			// 
			// label21
			// 
			label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
			label21.AutoSize = true;
			label21.Location = new System.Drawing.Point(345, 8);
			label21.Name = "label21";
			label21.Size = new System.Drawing.Size(80, 13);
			label21.TabIndex = 4;
			label21.Text = "Inicio Proyecto:";
			// 
			// probabilidadVersion2TextBox
			// 
			this.probabilidadVersion2TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.probabilidadVersion2TextBox.Location = new System.Drawing.Point(266, 5);
			this.probabilidadVersion2TextBox.Name = "probabilidadVersion2TextBox";
			this.probabilidadVersion2TextBox.ReadOnly = true;
			this.probabilidadVersion2TextBox.Size = new System.Drawing.Size(73, 20);
			this.probabilidadVersion2TextBox.TabIndex = 5;
			// 
			// fechaInicioProyectoVersionAnteriorTextBox
			// 
			this.fechaInicioProyectoVersionAnteriorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fechaInicioProyectoVersionAnteriorTextBox.Location = new System.Drawing.Point(431, 5);
			this.fechaInicioProyectoVersionAnteriorTextBox.Name = "fechaInicioProyectoVersionAnteriorTextBox";
			this.fechaInicioProyectoVersionAnteriorTextBox.ReadOnly = true;
			this.fechaInicioProyectoVersionAnteriorTextBox.Size = new System.Drawing.Size(73, 20);
			this.fechaInicioProyectoVersionAnteriorTextBox.TabIndex = 5;
			// 
			// menuVersionAnteriorArribaTableLayoutPanel
			// 
			this.menuVersionAnteriorArribaTableLayoutPanel.ColumnCount = 8;
			this.menuVersionAnteriorArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.menuVersionAnteriorArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorArribaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.menuVersionAnteriorArribaTableLayoutPanel.Controls.Add(this.contraerPanelVersionButton, 0, 0);
			this.menuVersionAnteriorArribaTableLayoutPanel.Controls.Add(this.crearVersionV2Button, 1, 0);
			this.menuVersionAnteriorArribaTableLayoutPanel.Controls.Add(fechaVersionV2Label, 2, 0);
			this.menuVersionAnteriorArribaTableLayoutPanel.Controls.Add(this.fechaVersionV2TextBox, 3, 0);
			this.menuVersionAnteriorArribaTableLayoutPanel.Controls.Add(this.versionAnteriorComboBox, 6, 0);
			this.menuVersionAnteriorArribaTableLayoutPanel.Controls.Add(this.decrementarVersionAnteriorButton, 7, 0);
			this.menuVersionAnteriorArribaTableLayoutPanel.Controls.Add(this.incrementarVersionAnteriorButton, 5, 0);
			this.menuVersionAnteriorArribaTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menuVersionAnteriorArribaTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.menuVersionAnteriorArribaTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.menuVersionAnteriorArribaTableLayoutPanel.Name = "menuVersionAnteriorArribaTableLayoutPanel";
			this.menuVersionAnteriorArribaTableLayoutPanel.RowCount = 1;
			this.menuVersionAnteriorArribaTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.menuVersionAnteriorArribaTableLayoutPanel.Size = new System.Drawing.Size(528, 30);
			this.menuVersionAnteriorArribaTableLayoutPanel.TabIndex = 0;
			// 
			// contraerPanelVersionButton
			// 
			this.contraerPanelVersionButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.contraerPanelVersionButton.Image = global::Kenwin.PPP.Cliente.Properties.Resources.FlechaDerecha;
			this.contraerPanelVersionButton.Location = new System.Drawing.Point(3, 3);
			this.contraerPanelVersionButton.Name = "contraerPanelVersionButton";
			this.contraerPanelVersionButton.Size = new System.Drawing.Size(22, 23);
			this.contraerPanelVersionButton.TabIndex = 0;
			this.contraerPanelVersionButton.UseVisualStyleBackColor = true;
			this.contraerPanelVersionButton.Click += new System.EventHandler(this.ContraerPanelVersionButton_Click);
			// 
			// crearVersionV2Button
			// 
			this.crearVersionV2Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.crearVersionV2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.crearVersionV2Button.Location = new System.Drawing.Point(31, 3);
			this.crearVersionV2Button.Name = "crearVersionV2Button";
			this.crearVersionV2Button.Size = new System.Drawing.Size(94, 24);
			this.crearVersionV2Button.TabIndex = 1;
			this.crearVersionV2Button.Text = "Hacer Actual";
			this.crearVersionV2Button.UseVisualStyleBackColor = true;
			this.crearVersionV2Button.Click += new System.EventHandler(this.CrearVersionV2Button_Click);
			// 
			// fechaVersionV2Label
			// 
			fechaVersionV2Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
			fechaVersionV2Label.AutoSize = true;
			fechaVersionV2Label.Location = new System.Drawing.Point(131, 8);
			fechaVersionV2Label.Name = "fechaVersionV2Label";
			fechaVersionV2Label.Size = new System.Drawing.Size(78, 13);
			fechaVersionV2Label.TabIndex = 2;
			fechaVersionV2Label.Text = "Fecha Version:";
			fechaVersionV2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// fechaVersionV2TextBox
			// 
			this.fechaVersionV2TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fechaVersionV2TextBox.Location = new System.Drawing.Point(215, 5);
			this.fechaVersionV2TextBox.Name = "fechaVersionV2TextBox";
			this.fechaVersionV2TextBox.ReadOnly = true;
			this.fechaVersionV2TextBox.Size = new System.Drawing.Size(100, 20);
			this.fechaVersionV2TextBox.TabIndex = 3;
			// 
			// versionAnteriorComboBox
			// 
			this.versionAnteriorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.versionAnteriorComboBox.FormattingEnabled = true;
			this.versionAnteriorComboBox.Location = new System.Drawing.Point(378, 3);
			this.versionAnteriorComboBox.Name = "versionAnteriorComboBox";
			this.versionAnteriorComboBox.Size = new System.Drawing.Size(108, 21);
			this.versionAnteriorComboBox.TabIndex = 4;
			this.versionAnteriorComboBox.SelectedIndexChanged += new System.EventHandler(this.VersionAnteriorComboBox_SelectedIndexChanged);
			// 
			// decrementarVersionAnteriorButton
			// 
			this.decrementarVersionAnteriorButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.decrementarVersionAnteriorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.decrementarVersionAnteriorButton.Image = global::Kenwin.PPP.Cliente.Properties.Resources.FlechaDerechaAzul;
			this.decrementarVersionAnteriorButton.Location = new System.Drawing.Point(492, 3);
			this.decrementarVersionAnteriorButton.Name = "decrementarVersionAnteriorButton";
			this.decrementarVersionAnteriorButton.Size = new System.Drawing.Size(33, 23);
			this.decrementarVersionAnteriorButton.TabIndex = 5;
			this.decrementarVersionAnteriorButton.UseVisualStyleBackColor = true;
			this.decrementarVersionAnteriorButton.Click += new System.EventHandler(this.DecrementarVersionAnteriorButton_Click);
			// 
			// incrementarVersionAnteriorButton
			// 
			this.incrementarVersionAnteriorButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.incrementarVersionAnteriorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.incrementarVersionAnteriorButton.Image = global::Kenwin.PPP.Cliente.Properties.Resources.FlechaIzquierdaAzul;
			this.incrementarVersionAnteriorButton.Location = new System.Drawing.Point(339, 3);
			this.incrementarVersionAnteriorButton.Name = "incrementarVersionAnteriorButton";
			this.incrementarVersionAnteriorButton.Size = new System.Drawing.Size(33, 23);
			this.incrementarVersionAnteriorButton.TabIndex = 5;
			this.incrementarVersionAnteriorButton.UseVisualStyleBackColor = true;
			this.incrementarVersionAnteriorButton.Click += new System.EventHandler(this.IncrementarVersionAnteriorButton_Click);
			// 
			// sumatoriasVersionAnteriorTableLayoutPanel
			// 
			this.sumatoriasVersionAnteriorTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnCount = 13;
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.sumatoriasVersionAnteriorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.label12, 1, 0);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.label13, 1, 1);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.label14, 4, 1);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.label15, 4, 0);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.label16, 7, 0);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.label17, 10, 0);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.label18, 10, 1);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.textBox8, 2, 0);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.textBox9, 2, 1);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.textBox10, 5, 0);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.textBox11, 5, 1);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.textBox12, 8, 0);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.textBox13, 11, 0);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Controls.Add(this.textBox14, 11, 1);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sumatoriasVersionAnteriorTableLayoutPanel.Location = new System.Drawing.Point(0, 554);
			this.sumatoriasVersionAnteriorTableLayoutPanel.Name = "sumatoriasVersionAnteriorTableLayoutPanel";
			this.sumatoriasVersionAnteriorTableLayoutPanel.RowCount = 3;
			this.sumatoriasVersionAnteriorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.sumatoriasVersionAnteriorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.sumatoriasVersionAnteriorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.sumatoriasVersionAnteriorTableLayoutPanel.Size = new System.Drawing.Size(528, 53);
			this.sumatoriasVersionAnteriorTableLayoutPanel.TabIndex = 5;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(-6, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(76, 25);
			this.label12.TabIndex = 0;
			this.label12.Text = "Horas Totales:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(-6, 25);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(71, 25);
			this.label13.TabIndex = 8;
			this.label13.Text = "Días Totales:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(142, 25);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(65, 25);
			this.label14.TabIndex = 10;
			this.label14.Text = "Precio Final:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(142, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(68, 25);
			this.label15.TabIndex = 2;
			this.label15.Text = "Precio Bruto:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(282, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(43, 25);
			this.label16.TabIndex = 4;
			this.label16.Text = "Gastos:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(397, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(66, 25);
			this.label17.TabIndex = 6;
			this.label17.Text = "Total COPC:";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label18
			// 
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(397, 25);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(81, 25);
			this.label18.TabIndex = 12;
			this.label18.Text = "Total no COPC:";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox8
			// 
			this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox8.Location = new System.Drawing.Point(76, 3);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(50, 20);
			this.textBox8.TabIndex = 1;
			this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox9
			// 
			this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox9.Location = new System.Drawing.Point(76, 28);
			this.textBox9.Name = "textBox9";
			this.textBox9.ReadOnly = true;
			this.textBox9.Size = new System.Drawing.Size(50, 20);
			this.textBox9.TabIndex = 9;
			this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox10
			// 
			this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox10.Location = new System.Drawing.Point(216, 3);
			this.textBox10.Name = "textBox10";
			this.textBox10.ReadOnly = true;
			this.textBox10.Size = new System.Drawing.Size(50, 20);
			this.textBox10.TabIndex = 3;
			this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox11
			// 
			this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox11.Location = new System.Drawing.Point(216, 28);
			this.textBox11.Name = "textBox11";
			this.textBox11.ReadOnly = true;
			this.textBox11.Size = new System.Drawing.Size(50, 20);
			this.textBox11.TabIndex = 11;
			this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox12
			// 
			this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox12.Location = new System.Drawing.Point(331, 3);
			this.textBox12.Name = "textBox12";
			this.textBox12.ReadOnly = true;
			this.textBox12.Size = new System.Drawing.Size(50, 20);
			this.textBox12.TabIndex = 5;
			this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox13
			// 
			this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox13.Location = new System.Drawing.Point(484, 3);
			this.textBox13.Name = "textBox13";
			this.textBox13.ReadOnly = true;
			this.textBox13.Size = new System.Drawing.Size(50, 20);
			this.textBox13.TabIndex = 7;
			this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox14
			// 
			this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox14.Location = new System.Drawing.Point(484, 28);
			this.textBox14.Name = "textBox14";
			this.textBox14.ReadOnly = true;
			this.textBox14.Size = new System.Drawing.Size(50, 20);
			this.textBox14.TabIndex = 13;
			this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// datosGeneralesTabPage
			// 
			datosGeneralesTabPage.BackColor = System.Drawing.SystemColors.Control;
			datosGeneralesTabPage.Controls.Add(this.asignacionGroupBox);
			datosGeneralesTabPage.Controls.Add(this.datosProyectoGroupBox);
			datosGeneralesTabPage.Location = new System.Drawing.Point(4, 22);
			datosGeneralesTabPage.Name = "datosGeneralesTabPage";
			datosGeneralesTabPage.Padding = new System.Windows.Forms.Padding(3);
			datosGeneralesTabPage.Size = new System.Drawing.Size(1114, 613);
			datosGeneralesTabPage.TabIndex = 1;
			datosGeneralesTabPage.Text = "Datos generales";
			// 
			// asignacionGroupBox
			// 
			this.asignacionGroupBox.Controls.Add(this.asignacionPersonal1);
			this.asignacionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.asignacionGroupBox.Location = new System.Drawing.Point(3, 296);
			this.asignacionGroupBox.Name = "asignacionGroupBox";
			this.asignacionGroupBox.Padding = new System.Windows.Forms.Padding(5);
			this.asignacionGroupBox.Size = new System.Drawing.Size(1108, 314);
			this.asignacionGroupBox.TabIndex = 1;
			this.asignacionGroupBox.TabStop = false;
			this.asignacionGroupBox.Text = "Asignación";
			// 
			// asignacionPersonal1
			// 
			this.asignacionPersonal1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.asignacionPersonal1.Location = new System.Drawing.Point(5, 18);
			this.asignacionPersonal1.Name = "asignacionPersonal1";
			this.asignacionPersonal1.Size = new System.Drawing.Size(1098, 291);
			this.asignacionPersonal1.TabIndex = 0;
			this.asignacionPersonal1.CambioEnAsginaciones += new System.EventHandler(this.AsignacionPersonal1_CambioEnAsginaciones);
			// 
			// datosProyectoGroupBox
			// 
			this.datosProyectoGroupBox.Controls.Add(this.tableLayoutPanel4);
			this.datosProyectoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.datosProyectoGroupBox.Location = new System.Drawing.Point(3, 3);
			this.datosProyectoGroupBox.Name = "datosProyectoGroupBox";
			this.datosProyectoGroupBox.Size = new System.Drawing.Size(1108, 293);
			this.datosProyectoGroupBox.TabIndex = 2;
			this.datosProyectoGroupBox.TabStop = false;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Controls.Add(this.paisLabel, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.unidadNegocioLabel, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.tipoEmpresaLabel, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.tipoProyectoLabel, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.contatoComercialLabel, 0, 4);
			this.tableLayoutPanel4.Controls.Add(this.liderClienteLabel, 0, 5);
			this.tableLayoutPanel4.Controls.Add(this.liderClienteTextBox, 1, 5);
			this.tableLayoutPanel4.Controls.Add(this.contactoComercialTextBox, 1, 4);
			this.tableLayoutPanel4.Controls.Add(this.observacionesTextBox, 1, 6);
			this.tableLayoutPanel4.Controls.Add(this.usuarioCreadorLabel, 0, 9);
			this.tableLayoutPanel4.Controls.Add(this.usuarioCreadorTextBox, 1, 9);
			this.tableLayoutPanel4.Controls.Add(this.observacionesLabel, 0, 6);
			this.tableLayoutPanel4.Controls.Add(this.paisFKBox, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.unidadNegocioFKBox, 1, 1);
			this.tableLayoutPanel4.Controls.Add(this.tipoEmpresaFKBox, 1, 2);
			this.tableLayoutPanel4.Controls.Add(this.tipoProyectoFKBox, 1, 3);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 11;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(1102, 274);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// paisLabel
			// 
			this.paisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.paisLabel.AutoSize = true;
			this.paisLabel.Location = new System.Drawing.Point(73, 0);
			this.paisLabel.Name = "paisLabel";
			this.paisLabel.Size = new System.Drawing.Size(32, 30);
			this.paisLabel.TabIndex = 0;
			this.paisLabel.Text = "País:";
			this.paisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// unidadNegocioLabel
			// 
			this.unidadNegocioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.unidadNegocioLabel.AutoSize = true;
			this.unidadNegocioLabel.Location = new System.Drawing.Point(3, 30);
			this.unidadNegocioLabel.Name = "unidadNegocioLabel";
			this.unidadNegocioLabel.Size = new System.Drawing.Size(102, 30);
			this.unidadNegocioLabel.TabIndex = 0;
			this.unidadNegocioLabel.Text = "Unidad de Negocio:";
			this.unidadNegocioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tipoEmpresaLabel
			// 
			this.tipoEmpresaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tipoEmpresaLabel.AutoSize = true;
			this.tipoEmpresaLabel.Location = new System.Drawing.Point(15, 60);
			this.tipoEmpresaLabel.Name = "tipoEmpresaLabel";
			this.tipoEmpresaLabel.Size = new System.Drawing.Size(90, 30);
			this.tipoEmpresaLabel.TabIndex = 0;
			this.tipoEmpresaLabel.Text = "Tipo de Empresa:";
			this.tipoEmpresaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tipoProyectoLabel
			// 
			this.tipoProyectoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tipoProyectoLabel.AutoSize = true;
			this.tipoProyectoLabel.Location = new System.Drawing.Point(14, 90);
			this.tipoProyectoLabel.Name = "tipoProyectoLabel";
			this.tipoProyectoLabel.Size = new System.Drawing.Size(91, 30);
			this.tipoProyectoLabel.TabIndex = 0;
			this.tipoProyectoLabel.Text = "Tipo de Proyecto:";
			this.tipoProyectoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// contatoComercialLabel
			// 
			this.contatoComercialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.contatoComercialLabel.AutoSize = true;
			this.contatoComercialLabel.Location = new System.Drawing.Point(3, 120);
			this.contatoComercialLabel.Name = "contatoComercialLabel";
			this.contatoComercialLabel.Size = new System.Drawing.Size(102, 26);
			this.contatoComercialLabel.TabIndex = 0;
			this.contatoComercialLabel.Text = "Contacto Comercial:";
			this.contatoComercialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// liderClienteLabel
			// 
			this.liderClienteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.liderClienteLabel.AutoSize = true;
			this.liderClienteLabel.Location = new System.Drawing.Point(20, 146);
			this.liderClienteLabel.Name = "liderClienteLabel";
			this.liderClienteLabel.Size = new System.Drawing.Size(85, 26);
			this.liderClienteLabel.TabIndex = 0;
			this.liderClienteLabel.Text = "Líder en Cliente:";
			this.liderClienteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// liderClienteTextBox
			// 
			this.liderClienteTextBox.Location = new System.Drawing.Point(111, 149);
			this.liderClienteTextBox.MaxLength = 50;
			this.liderClienteTextBox.Name = "liderClienteTextBox";
			this.liderClienteTextBox.Size = new System.Drawing.Size(243, 20);
			this.liderClienteTextBox.TabIndex = 5;
			// 
			// contactoComercialTextBox
			// 
			this.contactoComercialTextBox.Location = new System.Drawing.Point(111, 123);
			this.contactoComercialTextBox.MaxLength = 50;
			this.contactoComercialTextBox.Name = "contactoComercialTextBox";
			this.contactoComercialTextBox.Size = new System.Drawing.Size(243, 20);
			this.contactoComercialTextBox.TabIndex = 4;
			// 
			// observacionesTextBox
			// 
			this.observacionesTextBox.Location = new System.Drawing.Point(111, 175);
			this.observacionesTextBox.MaxLength = 50;
			this.observacionesTextBox.Multiline = true;
			this.observacionesTextBox.Name = "observacionesTextBox";
			this.observacionesTextBox.Size = new System.Drawing.Size(243, 36);
			this.observacionesTextBox.TabIndex = 6;
			// 
			// usuarioCreadorLabel
			// 
			this.usuarioCreadorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.usuarioCreadorLabel.AutoSize = true;
			this.usuarioCreadorLabel.Location = new System.Drawing.Point(58, 234);
			this.usuarioCreadorLabel.Name = "usuarioCreadorLabel";
			this.usuarioCreadorLabel.Size = new System.Drawing.Size(47, 26);
			this.usuarioCreadorLabel.TabIndex = 0;
			this.usuarioCreadorLabel.Text = "Creador:";
			this.usuarioCreadorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// usuarioCreadorTextBox
			// 
			this.usuarioCreadorTextBox.Location = new System.Drawing.Point(111, 237);
			this.usuarioCreadorTextBox.Name = "usuarioCreadorTextBox";
			this.usuarioCreadorTextBox.ReadOnly = true;
			this.usuarioCreadorTextBox.Size = new System.Drawing.Size(243, 20);
			this.usuarioCreadorTextBox.TabIndex = 7;
			// 
			// observacionesLabel
			// 
			this.observacionesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.observacionesLabel.AutoSize = true;
			this.observacionesLabel.Location = new System.Drawing.Point(24, 172);
			this.observacionesLabel.Name = "observacionesLabel";
			this.observacionesLabel.Size = new System.Drawing.Size(81, 42);
			this.observacionesLabel.TabIndex = 0;
			this.observacionesLabel.Text = "Observaciones:";
			this.observacionesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// paisFKBox
			// 
			this.paisFKBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.paisFKBox.Location = new System.Drawing.Point(111, 3);
			this.paisFKBox.MaximumSize = new System.Drawing.Size(500, 24);
			this.paisFKBox.MinimumSize = new System.Drawing.Size(50, 24);
			this.paisFKBox.Name = "paisFKBox";
			this.paisFKBox.Size = new System.Drawing.Size(243, 24);
			this.paisFKBox.TabIndex = 0;
			// 
			// unidadNegocioFKBox
			// 
			this.unidadNegocioFKBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.unidadNegocioFKBox.Location = new System.Drawing.Point(111, 33);
			this.unidadNegocioFKBox.MaximumSize = new System.Drawing.Size(500, 24);
			this.unidadNegocioFKBox.MinimumSize = new System.Drawing.Size(50, 24);
			this.unidadNegocioFKBox.Name = "unidadNegocioFKBox";
			this.unidadNegocioFKBox.Size = new System.Drawing.Size(243, 24);
			this.unidadNegocioFKBox.TabIndex = 1;
			// 
			// tipoEmpresaFKBox
			// 
			this.tipoEmpresaFKBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tipoEmpresaFKBox.Location = new System.Drawing.Point(111, 63);
			this.tipoEmpresaFKBox.MaximumSize = new System.Drawing.Size(500, 24);
			this.tipoEmpresaFKBox.MinimumSize = new System.Drawing.Size(50, 24);
			this.tipoEmpresaFKBox.Name = "tipoEmpresaFKBox";
			this.tipoEmpresaFKBox.Size = new System.Drawing.Size(243, 24);
			this.tipoEmpresaFKBox.TabIndex = 2;
			// 
			// tipoProyectoFKBox
			// 
			this.tipoProyectoFKBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tipoProyectoFKBox.Location = new System.Drawing.Point(111, 93);
			this.tipoProyectoFKBox.MaximumSize = new System.Drawing.Size(500, 24);
			this.tipoProyectoFKBox.MinimumSize = new System.Drawing.Size(50, 24);
			this.tipoProyectoFKBox.Name = "tipoProyectoFKBox";
			this.tipoProyectoFKBox.Size = new System.Drawing.Size(243, 24);
			this.tipoProyectoFKBox.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(5, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1122, 49);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Proyecto";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 16;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.nombreProyectoTextBox, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 9, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.monedaLabel, 13, 0);
			this.tableLayoutPanel1.Controls.Add(this.clienteFKBox, 11, 0);
			this.tableLayoutPanel1.Controls.Add(this.monedaFKBox, 15, 0);
			this.tableLayoutPanel1.Controls.Add(this.proyectoOTFKBox, 7, 0);
			this.tableLayoutPanel1.Controls.Add(this.proyectoPadreFKBox, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1116, 30);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// nombreProyectoTextBox
			// 
			this.nombreProyectoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.nombreProyectoTextBox.Location = new System.Drawing.Point(366, 3);
			this.nombreProyectoTextBox.MaxLength = 50;
			this.nombreProyectoTextBox.Name = "nombreProyectoTextBox";
			this.nombreProyectoTextBox.Size = new System.Drawing.Size(100, 20);
			this.nombreProyectoTextBox.TabIndex = 3;
			this.nombreProyectoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NombreProyectoTextBox_Validating);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Proyecto Padre:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(268, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre Proyecto:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(735, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Cliente:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(492, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = "Código OT:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// monedaLabel
			// 
			this.monedaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.monedaLabel.AutoSize = true;
			this.monedaLabel.Location = new System.Drawing.Point(959, 0);
			this.monedaLabel.Name = "monedaLabel";
			this.monedaLabel.Size = new System.Drawing.Size(49, 25);
			this.monedaLabel.TabIndex = 8;
			this.monedaLabel.Text = "Moneda:";
			this.monedaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// clienteFKBox
			// 
			this.clienteFKBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.clienteFKBox.Location = new System.Drawing.Point(783, 3);
			this.clienteFKBox.MaximumSize = new System.Drawing.Size(500, 24);
			this.clienteFKBox.MinimumSize = new System.Drawing.Size(50, 24);
			this.clienteFKBox.Name = "clienteFKBox";
			this.clienteFKBox.Size = new System.Drawing.Size(150, 24);
			this.clienteFKBox.TabIndex = 7;
			// 
			// monedaFKBox
			// 
			this.monedaFKBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.monedaFKBox.Location = new System.Drawing.Point(1014, 3);
			this.monedaFKBox.MaximumSize = new System.Drawing.Size(500, 24);
			this.monedaFKBox.MinimumSize = new System.Drawing.Size(50, 24);
			this.monedaFKBox.Name = "monedaFKBox";
			this.monedaFKBox.Size = new System.Drawing.Size(99, 24);
			this.monedaFKBox.TabIndex = 9;
			// 
			// proyectoOTFKBox
			// 
			this.proyectoOTFKBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.proyectoOTFKBox.Location = new System.Drawing.Point(559, 3);
			this.proyectoOTFKBox.MaximumSize = new System.Drawing.Size(500, 24);
			this.proyectoOTFKBox.MinimumSize = new System.Drawing.Size(50, 24);
			this.proyectoOTFKBox.Name = "proyectoOTFKBox";
			this.proyectoOTFKBox.Size = new System.Drawing.Size(150, 24);
			this.proyectoOTFKBox.TabIndex = 5;
			// 
			// proyectoPadreFKBox
			// 
			this.proyectoPadreFKBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.proyectoPadreFKBox.Location = new System.Drawing.Point(92, 3);
			this.proyectoPadreFKBox.MaximumSize = new System.Drawing.Size(500, 24);
			this.proyectoPadreFKBox.MinimumSize = new System.Drawing.Size(50, 24);
			this.proyectoPadreFKBox.Name = "proyectoPadreFKBox";
			this.proyectoPadreFKBox.Size = new System.Drawing.Size(150, 24);
			this.proyectoPadreFKBox.TabIndex = 1;
			this.proyectoPadreFKBox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.ProyectoPadreFKBox_SelectedItemChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.CausesValidation = false;
			this.tabControl1.Controls.Add(datosGeneralesTabPage);
			this.tabControl1.Controls.Add(actividadesTabPage);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(5, 54);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1122, 639);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.asignacionSemanal1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1114, 613);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Asignaciones";
			// 
			// asignacionSemanal1
			// 
			this.asignacionSemanal1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.asignacionSemanal1.Location = new System.Drawing.Point(3, 3);
			this.asignacionSemanal1.Name = "asignacionSemanal1";
			this.asignacionSemanal1.Size = new System.Drawing.Size(1108, 607);
			this.asignacionSemanal1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.crearProyectoButton);
			this.panel2.Controls.Add(this.guardarButton);
			this.panel2.Controls.Add(this.cerrarButton);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(5, 693);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1122, 41);
			this.panel2.TabIndex = 2;
			// 
			// crearProyectoButton
			// 
			this.crearProyectoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.crearProyectoButton.Image = global::Kenwin.PPP.Cliente.Properties.Resources.Guardar;
			this.crearProyectoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.crearProyectoButton.Location = new System.Drawing.Point(853, 6);
			this.crearProyectoButton.Name = "crearProyectoButton";
			this.crearProyectoButton.Size = new System.Drawing.Size(106, 30);
			this.crearProyectoButton.TabIndex = 2;
			this.crearProyectoButton.Text = "Crear Proyecto";
			this.crearProyectoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip1.SetToolTip(this.crearProyectoButton, "Crear un Proyecto nuevo y copiar datos actuales");
			this.crearProyectoButton.Click += new System.EventHandler(this.CrearProyectoButton_Click);
			// 
			// guardarButton
			// 
			this.guardarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.guardarButton.Image = global::Kenwin.PPP.Cliente.Properties.Resources.Guardar;
			this.guardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.guardarButton.Location = new System.Drawing.Point(969, 6);
			this.guardarButton.Name = "guardarButton";
			this.guardarButton.Size = new System.Drawing.Size(70, 30);
			this.guardarButton.TabIndex = 2;
			this.guardarButton.Text = "&Guardar";
			this.guardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.guardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
			// 
			// cerrarButton
			// 
			this.cerrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cerrarButton.ButtonType = Vemn.Fwk.Windows.Controls.VemnButton.ButtonTypeEnum.Cancel;
			this.cerrarButton.Image = ((System.Drawing.Image)(resources.GetObject("cerrarButton.Image")));
			this.cerrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cerrarButton.Location = new System.Drawing.Point(1045, 6);
			this.cerrarButton.Name = "cerrarButton";
			this.cerrarButton.Size = new System.Drawing.Size(70, 30);
			this.cerrarButton.TabIndex = 0;
			this.cerrarButton.Text = "&Cerrar";
			this.cerrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarActividadToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.Size = new System.Drawing.Size(171, 26);
			// 
			// eliminarActividadToolStripMenuItem
			// 
			this.eliminarActividadToolStripMenuItem.Name = "eliminarActividadToolStripMenuItem";
			this.eliminarActividadToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.eliminarActividadToolStripMenuItem.Text = "Eliminar Actividad";
			this.eliminarActividadToolStripMenuItem.Click += new System.EventHandler(this.EliminarActividadToolStripMenuItem_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1132, 739);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Editor";
			this.ShowIcon = false;
			this.Text = "Proyecto";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
			this.Load += new System.EventHandler(this.Editor_Load);
			actividadesTabPage.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.versionesSplitContainer.Panel1.ResumeLayout(false);
			this.versionesSplitContainer.Panel1.PerformLayout();
			this.versionesSplitContainer.Panel2.ResumeLayout(false);
			this.versionesSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.versionesSplitContainer)).EndInit();
			this.versionesSplitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.version1C1FlexGrid)).EndInit();
			this.menuVersionActualTableLayoutPanel.ResumeLayout(false);
			this.menuVersionActualAbajoTableLayoutPanel.ResumeLayout(false);
			this.menuVersionActualAbajoTableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fechaInicioProyectoVersionActualC1DateEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.probabilidadVersion1C1NumericEdit)).EndInit();
			this.menuVersionActualArribaTableLayoutPanel.ResumeLayout(false);
			this.menuVersionActualArribaTableLayoutPanel.PerformLayout();
			this.sumatoriasVersionActualTableLayoutPanel.ResumeLayout(false);
			this.sumatoriasVersionActualTableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.version2C1FlexGrid)).EndInit();
			this.menuVersionAnteriorTableLayoutPanel.ResumeLayout(false);
			this.menuVersionAnteriorAbajoTableLayoutPanel.ResumeLayout(false);
			this.menuVersionAnteriorAbajoTableLayoutPanel.PerformLayout();
			this.menuVersionAnteriorArribaTableLayoutPanel.ResumeLayout(false);
			this.menuVersionAnteriorArribaTableLayoutPanel.PerformLayout();
			this.sumatoriasVersionAnteriorTableLayoutPanel.ResumeLayout(false);
			this.sumatoriasVersionAnteriorTableLayoutPanel.PerformLayout();
			datosGeneralesTabPage.ResumeLayout(false);
			this.asignacionGroupBox.ResumeLayout(false);
			this.datosProyectoGroupBox.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox nombreProyectoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.SplitContainer versionesSplitContainer;
        private C1.Win.C1FlexGrid.C1FlexGrid version1C1FlexGrid;
        private System.Windows.Forms.TableLayoutPanel sumatoriasVersionActualTableLayoutPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TableLayoutPanel sumatoriasVersionAnteriorTableLayoutPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private C1.Win.C1FlexGrid.C1FlexGrid version2C1FlexGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem eliminarActividadToolStripMenuItem;
		private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.CancelButton cerrarButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label monedaLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label paisLabel;
        private System.Windows.Forms.Label unidadNegocioLabel;
        private System.Windows.Forms.Label tipoEmpresaLabel;
        private System.Windows.Forms.Label tipoProyectoLabel;
        private System.Windows.Forms.Label contatoComercialLabel;
        private System.Windows.Forms.Label liderClienteLabel;
        private System.Windows.Forms.Label usuarioCreadorLabel;
        private System.Windows.Forms.TextBox usuarioCreadorTextBox;
        private System.Windows.Forms.TextBox liderClienteTextBox;
		private System.Windows.Forms.TextBox contactoComercialTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.Label observacionesLabel;
		private Comun.Controles.FKBoxes.ClienteFKBox clienteFKBox;
		private Comun.Controles.FKBoxes.MonedaFKBox monedaFKBox;
		private Comun.Controles.FKBoxes.PaisFKBox paisFKBox;
		private Comun.Controles.FKBoxes.UnidadNegocioFKBox unidadNegocioFKBox;
		private Comun.Controles.FKBoxes.TipoEmpresaFKBox tipoEmpresaFKBox;
		private Comun.Controles.FKBoxes.TipoProyectoFKBox tipoProyectoFKBox;
		private Comun.Controles.FKBoxes.ProyectoOTFKBox proyectoOTFKBox;
		private Comun.Controles.FKBoxes.ProyectoPadreFKBox proyectoPadreFKBox;
		private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.OkButton guardarButton;
		private System.Windows.Forms.TableLayoutPanel menuVersionActualTableLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel menuVersionActualAbajoTableLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel menuVersionActualArribaTableLayoutPanel;
		private System.Windows.Forms.Button agregarActividadButton;
		private System.Windows.Forms.Button crearVersionV1Button;
		private System.Windows.Forms.TextBox fechaVersionV1TextBox;
		private System.Windows.Forms.Button expandirPanelVersionButton;
		private System.Windows.Forms.Label versionV1Label;
		private System.Windows.Forms.ComboBox estadoVersionActualComboBox;
		private C1.Win.C1Input.C1DateEdit fechaInicioProyectoVersionActualC1DateEdit;
		private C1.Win.C1Input.C1NumericEdit probabilidadVersion1C1NumericEdit;
		private System.Windows.Forms.TableLayoutPanel menuVersionAnteriorTableLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel menuVersionAnteriorAbajoTableLayoutPanel;
		private System.Windows.Forms.ComboBox estadoVersionAnteriorComboBox;
		private System.Windows.Forms.TableLayoutPanel menuVersionAnteriorArribaTableLayoutPanel;
		private System.Windows.Forms.Button contraerPanelVersionButton;
		private System.Windows.Forms.Button crearVersionV2Button;
		private System.Windows.Forms.TextBox fechaVersionV2TextBox;
		private System.Windows.Forms.ComboBox versionAnteriorComboBox;
		private System.Windows.Forms.Button decrementarVersionAnteriorButton;
		private System.Windows.Forms.Button incrementarVersionAnteriorButton;
		private System.Windows.Forms.TextBox probabilidadVersion2TextBox;
		private System.Windows.Forms.TextBox fechaInicioProyectoVersionAnteriorTextBox;
		private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.OkButton crearProyectoButton;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.GroupBox asignacionGroupBox;
		private AsignacionPersonal asignacionPersonal1;
		private System.Windows.Forms.GroupBox datosProyectoGroupBox;
		private System.Windows.Forms.TabPage tabPage1;
		private AsignacionSemanal asignacionSemanal1;
    }
}