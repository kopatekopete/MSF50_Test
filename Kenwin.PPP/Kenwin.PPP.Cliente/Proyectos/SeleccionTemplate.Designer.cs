using Kenwin.PPP.Cliente.Comun.Controles;

namespace Kenwin.PPP.Cliente.Proyectos
{
    partial class SeleccionTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionTemplate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.proyectosC1FlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aceptarButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.OkButton();
            this.cerrarButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.CancelButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosC1FlexGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.proyectosC1FlexGrid);
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
            this.proyectosC1FlexGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.proyectosC1FlexGrid_MouseDoubleClick);
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
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // cerrarButton
            // 
            resources.ApplyResources(this.cerrarButton, "cerrarButton");
            this.cerrarButton.ButtonType = Vemn.Fwk.Windows.Controls.VemnButton.ButtonTypeEnum.Cancel;
            this.cerrarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cerrarButton.Name = "cerrarButton";
            this.cerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // SeleccionTemplate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SeleccionTemplate";
            this.Load += new System.EventHandler(this.Buscador_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proyectosC1FlexGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1FlexGrid.C1FlexGrid proyectosC1FlexGrid;
        private System.Windows.Forms.Panel panel2;
        private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.OkButton aceptarButton;
        private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.CancelButton cerrarButton;

    }
}