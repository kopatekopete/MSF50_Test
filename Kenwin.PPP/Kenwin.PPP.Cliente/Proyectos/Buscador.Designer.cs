using System.Windows.Forms;
using Kenwin.PPP.Cliente.Comun.Controles;

namespace Kenwin.PPP.Cliente.Proyectos
{
    partial class Buscador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador));
			this.panel1 = new System.Windows.Forms.Panel();
			this.proyectosC1FlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.filtrosGroupBox = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.filtroNombreProyectoLabel = new System.Windows.Forms.Label();
			this.filtroNombreProyectoTextBox = new System.Windows.Forms.TextBox();
			this.countryLabel = new System.Windows.Forms.Label();
			this.filtroPaisComboBox = new System.Windows.Forms.ComboBox();
			this.filtroCodigoOTTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.filtrosVariosGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.filtroClienteTextBox = new System.Windows.Forms.TextBox();
			this.filtroProyectoPadreTextBox = new System.Windows.Forms.TextBox();
			this.filtroProyectoPadreLabel = new System.Windows.Forms.Label();
			this.filtroUnidadNegocioComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.filtroFechaInicioDateTimeBox = new Vemn.Fwk.Windows.Controls.DateTimeBox();
			this.label4 = new System.Windows.Forms.Label();
			this.estadoGroupBox = new System.Windows.Forms.GroupBox();
			this.filtroEstadosCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.limpiarButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.ClearButton();
			this.searchButton1 = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.SearchButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.aceptarButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.OkButton();
			this.cerrarButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.CancelButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.proyectosC1FlexGrid)).BeginInit();
			this.panel3.SuspendLayout();
			this.filtrosGroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.filtrosVariosGroupBox.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.estadoGroupBox.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.proyectosC1FlexGrid);
			this.panel1.Controls.Add(this.panel3);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// proyectosC1FlexGrid
			// 
			this.proyectosC1FlexGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.proyectosC1FlexGrid.AutoGenerateColumns = false;
			this.proyectosC1FlexGrid.AutoResize = false;
			resources.ApplyResources(this.proyectosC1FlexGrid, "proyectosC1FlexGrid");
			this.proyectosC1FlexGrid.Name = "proyectosC1FlexGrid";
			this.proyectosC1FlexGrid.Rows.Count = 1;
			this.proyectosC1FlexGrid.Rows.DefaultSize = 17;
			this.proyectosC1FlexGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
			this.proyectosC1FlexGrid.StyleInfo = resources.GetString("proyectosC1FlexGrid.StyleInfo");
			this.proyectosC1FlexGrid.BeforeSort += new C1.Win.C1FlexGrid.SortColEventHandler(this.ProyectosC1FlexGrid_BeforeSort);
			this.proyectosC1FlexGrid.AfterSort += new C1.Win.C1FlexGrid.SortColEventHandler(this.ProyectosC1FlexGrid_AfterSort);
			this.proyectosC1FlexGrid.RowColChange += new System.EventHandler(this.ProyectosC1FlexGrid_RowColChange);
			this.proyectosC1FlexGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProyectosC1FlexGrid_MouseDoubleClick);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.filtrosGroupBox);
			this.panel3.Controls.Add(this.limpiarButton);
			this.panel3.Controls.Add(this.searchButton1);
			resources.ApplyResources(this.panel3, "panel3");
			this.panel3.Name = "panel3";
			// 
			// filtrosGroupBox
			// 
			resources.ApplyResources(this.filtrosGroupBox, "filtrosGroupBox");
			this.filtrosGroupBox.Controls.Add(this.groupBox1);
			this.filtrosGroupBox.Controls.Add(this.filtrosVariosGroupBox);
			this.filtrosGroupBox.Controls.Add(this.estadoGroupBox);
			this.filtrosGroupBox.Name = "filtrosGroupBox";
			this.filtrosGroupBox.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel2);
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.filtroNombreProyectoLabel, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.filtroNombreProyectoTextBox, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.countryLabel, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.filtroPaisComboBox, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.filtroCodigoOTTextBox, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// filtroNombreProyectoLabel
			// 
			resources.ApplyResources(this.filtroNombreProyectoLabel, "filtroNombreProyectoLabel");
			this.filtroNombreProyectoLabel.Name = "filtroNombreProyectoLabel";
			// 
			// filtroNombreProyectoTextBox
			// 
			resources.ApplyResources(this.filtroNombreProyectoTextBox, "filtroNombreProyectoTextBox");
			this.filtroNombreProyectoTextBox.Name = "filtroNombreProyectoTextBox";
			// 
			// countryLabel
			// 
			resources.ApplyResources(this.countryLabel, "countryLabel");
			this.countryLabel.Name = "countryLabel";
			// 
			// filtroPaisComboBox
			// 
			resources.ApplyResources(this.filtroPaisComboBox, "filtroPaisComboBox");
			this.filtroPaisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.filtroPaisComboBox.FormattingEnabled = true;
			this.filtroPaisComboBox.Name = "filtroPaisComboBox";
			// 
			// filtroCodigoOTTextBox
			// 
			resources.ApplyResources(this.filtroCodigoOTTextBox, "filtroCodigoOTTextBox");
			this.filtroCodigoOTTextBox.Name = "filtroCodigoOTTextBox";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// filtrosVariosGroupBox
			// 
			this.filtrosVariosGroupBox.Controls.Add(this.tableLayoutPanel1);
			resources.ApplyResources(this.filtrosVariosGroupBox, "filtrosVariosGroupBox");
			this.filtrosVariosGroupBox.Name = "filtrosVariosGroupBox";
			this.filtrosVariosGroupBox.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.filtroClienteTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.filtroProyectoPadreTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.filtroProyectoPadreLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.filtroUnidadNegocioComboBox, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.filtroFechaInicioDateTimeBox, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// filtroClienteTextBox
			// 
			resources.ApplyResources(this.filtroClienteTextBox, "filtroClienteTextBox");
			this.filtroClienteTextBox.Name = "filtroClienteTextBox";
			// 
			// filtroProyectoPadreTextBox
			// 
			resources.ApplyResources(this.filtroProyectoPadreTextBox, "filtroProyectoPadreTextBox");
			this.filtroProyectoPadreTextBox.Name = "filtroProyectoPadreTextBox";
			// 
			// filtroProyectoPadreLabel
			// 
			resources.ApplyResources(this.filtroProyectoPadreLabel, "filtroProyectoPadreLabel");
			this.filtroProyectoPadreLabel.Name = "filtroProyectoPadreLabel";
			// 
			// filtroUnidadNegocioComboBox
			// 
			resources.ApplyResources(this.filtroUnidadNegocioComboBox, "filtroUnidadNegocioComboBox");
			this.filtroUnidadNegocioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.filtroUnidadNegocioComboBox.FormattingEnabled = true;
			this.filtroUnidadNegocioComboBox.Name = "filtroUnidadNegocioComboBox";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// filtroFechaInicioDateTimeBox
			// 
			resources.ApplyResources(this.filtroFechaInicioDateTimeBox, "filtroFechaInicioDateTimeBox");
			this.filtroFechaInicioDateTimeBox.Name = "filtroFechaInicioDateTimeBox";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// estadoGroupBox
			// 
			this.estadoGroupBox.Controls.Add(this.filtroEstadosCheckedListBox);
			resources.ApplyResources(this.estadoGroupBox, "estadoGroupBox");
			this.estadoGroupBox.Name = "estadoGroupBox";
			this.estadoGroupBox.TabStop = false;
			// 
			// filtroEstadosCheckedListBox
			// 
			this.filtroEstadosCheckedListBox.CheckOnClick = true;
			resources.ApplyResources(this.filtroEstadosCheckedListBox, "filtroEstadosCheckedListBox");
			this.filtroEstadosCheckedListBox.FormattingEnabled = true;
			this.filtroEstadosCheckedListBox.Name = "filtroEstadosCheckedListBox";
			this.filtroEstadosCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FiltroEstadosCheckedListBox_ItemCheck);
			// 
			// limpiarButton
			// 
			resources.ApplyResources(this.limpiarButton, "limpiarButton");
			this.limpiarButton.ButtonType = Vemn.Fwk.Windows.Controls.VemnButton.ButtonTypeEnum.Custom;
			this.limpiarButton.Name = "limpiarButton";
			this.limpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
			// 
			// searchButton1
			// 
			resources.ApplyResources(this.searchButton1, "searchButton1");
			this.searchButton1.ButtonType = Vemn.Fwk.Windows.Controls.VemnButton.ButtonTypeEnum.Custom;
			this.searchButton1.Name = "searchButton1";
			this.searchButton1.Click += new System.EventHandler(this.BuscarButton_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.aceptarButton);
			this.panel2.Controls.Add(this.cerrarButton);
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Name = "panel2";
			// 
			// aceptarButton
			// 
			resources.ApplyResources(this.aceptarButton, "aceptarButton");
			this.aceptarButton.Name = "aceptarButton";
			this.aceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
			// 
			// cerrarButton
			// 
			resources.ApplyResources(this.cerrarButton, "cerrarButton");
			this.cerrarButton.ButtonType = Vemn.Fwk.Windows.Controls.VemnButton.ButtonTypeEnum.Cancel;
			this.cerrarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cerrarButton.Name = "cerrarButton";
			this.cerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
			// 
			// Buscador
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "Buscador";
			this.ShowIcon = false;
			this.Load += new System.EventHandler(this.Buscador_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.proyectosC1FlexGrid)).EndInit();
			this.panel3.ResumeLayout(false);
			this.filtrosGroupBox.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.filtrosVariosGroupBox.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.estadoGroupBox.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GroupBox filtrosGroupBox;
        private C1.Win.C1FlexGrid.C1FlexGrid proyectosC1FlexGrid;
        private System.Windows.Forms.CheckedListBox filtroEstadosCheckedListBox;
        private System.Windows.Forms.ComboBox filtroPaisComboBox;
        private System.Windows.Forms.Panel panel2;
        private Vemn.Fwk.Windows.Controls.DateTimeBox filtroFechaInicioDateTimeBox;
        private System.Windows.Forms.TextBox filtroCodigoOTTextBox;
        private System.Windows.Forms.TextBox filtroClienteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.GroupBox estadoGroupBox;
        private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.SearchButton searchButton1;
        private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.ClearButton limpiarButton;
        private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.OkButton aceptarButton;
        private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.CancelButton cerrarButton;
        private System.Windows.Forms.GroupBox filtrosVariosGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox filtroUnidadNegocioComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label filtroProyectoPadreLabel;
        private System.Windows.Forms.TextBox filtroProyectoPadreTextBox;
        private Label filtroNombreProyectoLabel;
        private TextBox filtroNombreProyectoTextBox;

    }
}