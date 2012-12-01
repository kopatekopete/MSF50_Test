namespace Kenwin.PPP.Cliente.ABMs
{
    partial class ABMIdioma
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
			this.descripcionLbl = new System.Windows.Forms.Label();
			this.descripcionTB = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
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
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelContainerDetail
			// 
			this.panelContainerDetail.Controls.Add(this.tableLayoutPanel);
			// 
			// title
			// 
			this.title.SubTitle = "Altas Bajas y Modificaciones de Idiomas";
			this.title.Title = "Idioma";
			// 
			// dgVemn
			// 
			this.dgVemn.AutoGenerateColumns = false;
			this.dgVemn.Rows.Count = 1;
			this.dgVemn.Rows.DefaultSize = 17;
			// 
			// descripcionLbl
			// 
			this.descripcionLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.descripcionLbl.AutoSize = true;
			this.descripcionLbl.CausesValidation = false;
			this.descripcionLbl.Location = new System.Drawing.Point(3, 12);
			this.descripcionLbl.Name = "descripcionLbl";
			this.descripcionLbl.Size = new System.Drawing.Size(63, 13);
			this.descripcionLbl.TabIndex = 1;
			this.descripcionLbl.Text = "Descripción";
			this.descripcionLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// descripcionTB
			// 
			this.descripcionTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.descripcionTB.Location = new System.Drawing.Point(72, 8);
			this.descripcionTB.MaxLength = 50;
			this.descripcionTB.Name = "descripcionTB";
			this.descripcionTB.Size = new System.Drawing.Size(457, 20);
			this.descripcionTB.TabIndex = 1;
			this.descripcionTB.Validating += new System.ComponentModel.CancelEventHandler(this.Descripcion_Validating);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.Controls.Add(this.descripcionLbl, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.descripcionTB, 1, 0);
			this.tableLayoutPanel.Location = new System.Drawing.Point(32, 13);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 1;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(554, 37);
			this.tableLayoutPanel.TabIndex = 2;
			// 
			// ABMIdioma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 358);
			this.ControlBox = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.GetDataPageAfterInsert = false;
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Name = "ABMIdioma";
			this.Text = "Idioma";
			this.Load += new System.EventHandler(this.ABMCliente_Load);
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
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion Windows Form Designer generated code		

		private System.Windows.Forms.Label descripcionLbl;
		private System.Windows.Forms.TextBox descripcionTB;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
	}
}

