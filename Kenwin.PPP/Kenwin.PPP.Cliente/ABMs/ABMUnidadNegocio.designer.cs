﻿namespace Kenwin.PPP.Cliente.ABMs
{
	partial class ABMUnidadNegocio
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
			this.descripcionlLbl = new System.Windows.Forms.Label();
			this.descripcionTB = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
			this.SuspendLayout();
			// 
			// panelContainerDetail
			// 
			this.panelContainerDetail.Controls.Add(this.tableLayoutPanel1);
			// 
			// title
			// 
			this.title.SubTitle = "Altas Bajas y Modificaciones de Unidades de Negocio";
			this.title.Title = "Unidad de Negocio";
			// 
			// dgVemn
			// 
			this.dgVemn.AutoGenerateColumns = false;
			this.dgVemn.Rows.Count = 1;
			this.dgVemn.Rows.DefaultSize = 17;
			// 
			// descripcionlLbl
			// 
			this.descripcionlLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.descripcionlLbl.AutoSize = true;
			this.descripcionlLbl.CausesValidation = false;
			this.descripcionlLbl.Location = new System.Drawing.Point(3, 9);
			this.descripcionlLbl.Name = "descripcionlLbl";
			this.descripcionlLbl.Size = new System.Drawing.Size(63, 13);
			this.descripcionlLbl.TabIndex = 1;
			this.descripcionlLbl.Text = "Descripción";
			this.descripcionlLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// descripcionTB
			// 
			this.descripcionTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.descripcionTB.Location = new System.Drawing.Point(72, 5);
			this.descripcionTB.MaxLength = 50;
			this.descripcionTB.Name = "descripcionTB";
			this.descripcionTB.Size = new System.Drawing.Size(457, 20);
			this.descripcionTB.TabIndex = 1;
			this.descripcionTB.Validating += new System.ComponentModel.CancelEventHandler(this.Descripcion_Validating);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.descripcionlLbl, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.descripcionTB, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 13);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 31);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// ABMUnidadNegocio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 358);
			this.ControlBox = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.GetDataPageAfterInsert = false;
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Name = "ABMUnidadNegocio";
			this.Text = "Unidad de Negocio";
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
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion Windows Form Designer generated code		

		private System.Windows.Forms.Label descripcionlLbl;
		private System.Windows.Forms.TextBox descripcionTB;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

